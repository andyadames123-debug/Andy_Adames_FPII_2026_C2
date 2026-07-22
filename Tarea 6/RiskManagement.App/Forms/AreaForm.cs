using RiskManagement.App.Models;
using RiskManagement.App.Repositories;

namespace RiskManagement.App.Forms;

public partial class AreaForm : Form
{
    private readonly AreaRepository _areaRepo;
    private Guid? _selectedId = null;

    public AreaForm()
    {
        InitializeComponent();
        _areaRepo = new AreaRepository();
        LoadAreas();
    }

    private void LoadAreas()
    {
        var areas = _areaRepo.GetAll();
        dgvAreas.DataSource = null;
        dgvAreas.DataSource = areas;
        dgvAreas.Columns["Id"].Visible = false;
        dgvAreas.Columns["Name"].HeaderText = "Nombre";
        dgvAreas.Columns["Description"].HeaderText = "Descripcion";
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            MessageBox.Show("Ingrese un nombre para el area.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (_selectedId.HasValue)
        {
            var area = _areaRepo.GetById(_selectedId.Value);
            if (area != null)
            {
                area.Name = txtNombre.Text.Trim();
                area.Description = txtDescripcion.Text.Trim();
                _areaRepo.Update(area);
            }
        }
        else
        {
            var area = new Area
            {
                Name = txtNombre.Text.Trim(),
                Description = txtDescripcion.Text.Trim()
            };
            _areaRepo.Insert(area);
        }

        Limpiar();
        LoadAreas();
        MessageBox.Show("Area guardada correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        if (!_selectedId.HasValue)
        {
            MessageBox.Show("Seleccione un area para eliminar.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var result = MessageBox.Show("Desea eliminar esta area?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            _areaRepo.Delete(_selectedId.Value);
            Limpiar();
            LoadAreas();
        }
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        Limpiar();
    }

    private void Limpiar()
    {
        txtNombre.Text = string.Empty;
        txtDescripcion.Text = string.Empty;
        _selectedId = null;
        dgvAreas.ClearSelection();
    }

    private void dgvAreas_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && dgvAreas.Rows[e.RowIndex].DataBoundItem is Area area)
        {
            _selectedId = area.Id;
            txtNombre.Text = area.Name;
            txtDescripcion.Text = area.Description;
        }
    }
}
