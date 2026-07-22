using RiskManagement.App.Models;
using RiskManagement.App.Repositories;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Drawing;

namespace RiskManagement.App.Forms;

public partial class RiskListForm : Form
{
    private readonly AreaRepository _areaRepo;
    private readonly RiskRepository _riskRepo;
    private List<Risk> _allRisks = new();

    public RiskListForm()
    {
        InitializeComponent();
        _areaRepo = new AreaRepository();
        _riskRepo = new RiskRepository();
        ExcelPackage.License.SetNonCommercialPersonal("RiskUp");
        LoadFilters();
        LoadRisks();
    }

    private void LoadFilters()
    {
        var areas = _areaRepo.GetAll();
        var areaList = new List<Area> { new Area { Id = Guid.Empty, Name = "Todas" } };
        areaList.AddRange(areas);
        cmbArea.DataSource = areaList;
        cmbArea.DisplayMember = "Name";
        cmbArea.ValueMember = "Id";
        cmbArea.SelectedIndex = 0;

        cmbNivel.Items.AddRange(new object[] { "Todos", "Bajo", "Medio", "Alto", "Muy Alto" });
        cmbNivel.SelectedIndex = 0;
    }

    private void LoadRisks()
    {
        _allRisks = _riskRepo.GetAll();
        FilterRisks();
    }

    private void FilterRisks()
    {
        try
        {
            var filtered = _allRisks.AsEnumerable();
            if (cmbArea.SelectedIndex > 0 && cmbArea.SelectedValue is Guid areaId)
                filtered = filtered.Where(r => r.AreaId == areaId);
            if (cmbNivel.SelectedIndex > 0)
            {
                var nivel = cmbNivel.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(nivel))
                    filtered = filtered.Where(r => r.RiskLevel == nivel);
            }

            var result = filtered.OrderByDescending(r => r.ER).Select(r => new
            {
                r.Id, Proyecto = r.ProjectName, Area = GetAreaName(r.AreaId),
                Evaluador = r.EvaluatorUser, Riesgo = r.Name, Descripcion = r.Description,
                F = r.Funcion, S = r.Sustitucion, P = r.Profundidad, E = r.Extension,
                A = r.Agresion, V = r.Vulnerabilidad, I = r.I, D = r.D, C = r.C,
                PR = r.PR, ER = r.ER, Nivel = r.RiskLevel, Fecha = r.CreatedAt.ToString("dd/MM/yyyy")
            }).ToList();

            dgvRisks.DataSource = null;
            dgvRisks.DataSource = result;
            if (dgvRisks.Columns.Count > 0)
            {
                dgvRisks.Columns["Id"].Visible = false;
                dgvRisks.Columns["Proyecto"].Width = 120;
                dgvRisks.Columns["Area"].Width = 100;
                dgvRisks.Columns["Evaluador"].Width = 100;
                dgvRisks.Columns["Riesgo"].Width = 130;
                dgvRisks.Columns["Nivel"].Width = 80;
                dgvRisks.Columns["Fecha"].Width = 80;
            }
            lblTotal.Text = $"Total: {result.Count} riesgos";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al filtrar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private string GetAreaName(Guid areaId) => _areaRepo.GetById(areaId)?.Name ?? "Sin area";

    private void btnFiltrar_Click(object sender, EventArgs e) => FilterRisks();

    private void btnDetalle_Click(object sender, EventArgs e)
    {
        if (dgvRisks.CurrentRow == null) return;
        var idProp = dgvRisks.CurrentRow.Cells["Id"].Value;
        if (idProp != null && Guid.TryParse(idProp.ToString(), out Guid id))
        {
            var risk = _riskRepo.GetById(id);
            if (risk != null)
            {
                var form = new RiskDetailForm(risk);
                form.ShowDialog();
            }
        }
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
        if (dgvRisks.CurrentRow == null) return;
        var idProp = dgvRisks.CurrentRow.Cells["Id"].Value;
        if (idProp != null && Guid.TryParse(idProp.ToString(), out Guid id))
        {
            var form = new WizardForm(id);
            form.ShowDialog();
            LoadRisks();
        }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        if (dgvRisks.CurrentRow == null) return;
        var idProp = dgvRisks.CurrentRow.Cells["Id"].Value;
        if (idProp != null && Guid.TryParse(idProp.ToString(), out Guid id))
        {
            if (MessageBox.Show("Desea eliminar este riesgo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _riskRepo.Delete(id);
                LoadRisks();
            }
        }
    }

    private void btnExportar_Click(object sender, EventArgs e)
    {
        if (dgvRisks.Rows.Count == 0) { MessageBox.Show("No hay datos para exportar."); return; }

        try
        {
            var dialog = new SaveFileDialog { Filter = "Excel files (*.xlsx)|*.xlsx", FileName = $"Riesgos_Mosler_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using var package = new ExcelPackage();
                var ws = package.Workbook.Worksheets.Add("Riesgos");

                // Headers
                var headers = new[] { "Proyecto", "Area", "Evaluador", "Riesgo", "Descripcion", "F", "S", "P", "E", "A", "V", "I", "D", "C", "PR", "ER", "Nivel", "Fecha" };
                for (int i = 0; i < headers.Length; i++)
                {
                    ws.Cells[1, i + 1].Value = headers[i];
                    ws.Cells[1, i + 1].Style.Font.Bold = true;
                    ws.Cells[1, i + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws.Cells[1, i + 1].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(30, 100, 180));
                    ws.Cells[1, i + 1].Style.Font.Color.SetColor(Color.White);
                }

                // Data
                int row = 2;
                foreach (DataGridViewRow dgvRow in dgvRisks.Rows)
                {
                    ws.Cells[row, 1].Value = dgvRow.Cells["Proyecto"].Value?.ToString();
                    ws.Cells[row, 2].Value = dgvRow.Cells["Area"].Value?.ToString();
                    ws.Cells[row, 3].Value = dgvRow.Cells["Evaluador"].Value?.ToString();
                    ws.Cells[row, 4].Value = dgvRow.Cells["Riesgo"].Value?.ToString();
                    ws.Cells[row, 5].Value = dgvRow.Cells["Descripcion"].Value?.ToString();
                    ws.Cells[row, 6].Value = dgvRow.Cells["F"].Value;
                    ws.Cells[row, 7].Value = dgvRow.Cells["S"].Value;
                    ws.Cells[row, 8].Value = dgvRow.Cells["P"].Value;
                    ws.Cells[row, 9].Value = dgvRow.Cells["E"].Value;
                    ws.Cells[row, 10].Value = dgvRow.Cells["A"].Value;
                    ws.Cells[row, 11].Value = dgvRow.Cells["V"].Value;
                    ws.Cells[row, 12].Value = dgvRow.Cells["I"].Value;
                    ws.Cells[row, 13].Value = dgvRow.Cells["D"].Value;
                    ws.Cells[row, 14].Value = dgvRow.Cells["C"].Value;
                    ws.Cells[row, 15].Value = dgvRow.Cells["PR"].Value;
                    ws.Cells[row, 16].Value = dgvRow.Cells["ER"].Value;
                    ws.Cells[row, 17].Value = dgvRow.Cells["Nivel"].Value?.ToString();
                    ws.Cells[row, 18].Value = dgvRow.Cells["Fecha"].Value?.ToString();
                    row++;
                }

                ws.Cells[ws.Dimension.Address].AutoFitColumns();
                ws.Cells[1, 1, 1, headers.Length].AutoFilter = true;
                package.SaveAs(new FileInfo(dialog.FileName));
                MessageBox.Show("Exportado a Excel correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al exportar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
