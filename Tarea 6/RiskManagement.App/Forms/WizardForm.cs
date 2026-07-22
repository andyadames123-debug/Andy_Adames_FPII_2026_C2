using RiskManagement.App.Models;
using RiskManagement.App.Repositories;

namespace RiskManagement.App.Forms;

public partial class WizardForm : Form
{
    private readonly AreaRepository _areaRepo;
    private readonly RiskRepository _riskRepo;
    private int _currentStep = 1;
    private Guid? _editRiskId = null;

    public WizardForm()
    {
        InitializeComponent();
        _areaRepo = new AreaRepository();
        _riskRepo = new RiskRepository();
        LoadAreas();
        SetupCriterios();
        ShowStep(1);
    }

    public WizardForm(Guid riskId) : this()
    {
        var risk = _riskRepo.GetById(riskId);
        if (risk != null)
        {
            _editRiskId = risk.Id;
            txtProyecto.Text = risk.ProjectName;
            cmbArea.SelectedValue = risk.AreaId;
            txtEvaluador.Text = risk.EvaluatorUser;
            txtNombre.Text = risk.Name;
            txtDescripcion.Text = risk.Description;
            cmbFuncion.SelectedValue = risk.Funcion;
            cmbSustitucion.SelectedValue = risk.Sustitucion;
            cmbProfundidad.SelectedValue = risk.Profundidad;
            cmbExtension.SelectedValue = risk.Extension;
            cmbAgresion.SelectedValue = risk.Agresion;
            cmbVulnerabilidad.SelectedValue = risk.Vulnerabilidad;
        }
    }

    private void LoadAreas()
    {
        var areas = _areaRepo.GetAll();
        cmbArea.DataSource = areas;
        cmbArea.DisplayMember = "Name";
        cmbArea.ValueMember = "Id";
        cmbArea.SelectedIndex = -1;
    }

    private void SetupCriterios()
    {
        var vals = new[] { 1, 2, 3, 4, 5 };
        SetupComboBox(cmbFuncion, vals, new[] {
            "1 - Muy Baja (No afecta procesos)", "2 - Baja (Afecta areas secundarias)",
            "3 - Media (Afecta procesos importantes)", "4 - Alta (Dificulta procesos criticos)",
            "5 - Muy Alta (Detiene la organizacion)" });
        SetupComboBox(cmbSustitucion, vals, new[] {
            "1 - Muy Facil (Muchas alternativas rapidas)", "2 - Facil (Alternativas economicas)",
            "3 - Media (Busqueda moderada)", "4 - Dificil (Pocas alternativas viables)",
            "5 - Muy Dificil (Irremplazable)" });
        SetupComboBox(cmbProfundidad, vals, new[] {
            "1 - Minimo (Impacto irrelevante)", "2 - Bajo (Perdidas menores)",
            "3 - Moderado (Perdidas notables)", "4 - Alto (Perdidas significativas)",
            "5 - Catastrofico (Perdidas severas)" });
        SetupComboBox(cmbExtension, vals, new[] {
            "1 - Un solo punto (Aislado)", "2 - Pocas areas (Limitado)",
            "3 - Varias areas (Moderado)", "4 - Toda la organizacion",
            "5 - Externos (Clientes, sociedad)" });
        SetupComboBox(cmbAgresion, vals, new[] {
            "1 - Casi imposible", "2 - Poco probable",
            "3 - Posible", "4 - Probable",
            "5 - Casi seguro que ocurrira" });
        SetupComboBox(cmbVulnerabilidad, vals, new[] {
            "1 - Muy protegidos (Controles solidos)", "2 - Protegidos (Buenos controles)",
            "3 - Proteccion media (Controles basicos)", "4 - Expuestos (Pocos controles)",
            "5 - Muy desprotegidos (Sin controles)" });
    }

    private void SetupComboBox(ComboBox cmb, int[] values, string[] displayNames)
    {
        var data = values.Zip(displayNames, (v, d) => new { Value = v, Display = d }).ToList();
        cmb.DataSource = data;
        cmb.DisplayMember = "Display";
        cmb.ValueMember = "Value";
        cmb.SelectedIndex = -1;
    }

    private int GetCriterioValue(ComboBox cmb)
    {
        if (cmb.SelectedItem != null)
        {
            var prop = cmb.SelectedItem.GetType().GetProperty("Value");
            return (int)(prop?.GetValue(cmb.SelectedItem) ?? 1);
        }
        return 1;
    }

    private void ShowStep(int step)
    {
        _currentStep = step;
        pnlPaso1.Visible = step == 1;
        pnlPaso2.Visible = step == 2;
        pnlPaso3.Visible = step == 3;
        pnlPaso4.Visible = step == 4;

        btnAtras.Visible = step > 1;
        btnSiguiente.Visible = step < 4;
        btnGuardar.Visible = step == 4;

        UpdateStepIndicators(step);

        if (step == 4) UpdateSummary();
    }

    private void UpdateStepIndicators(int step)
    {
        lblStep1.BackColor = step >= 1 ? Color.FromArgb(30, 100, 180) : Color.LightGray;
        lblStep2.BackColor = step >= 2 ? Color.FromArgb(30, 100, 180) : Color.LightGray;
        lblStep3.BackColor = step >= 3 ? Color.FromArgb(30, 100, 180) : Color.LightGray;
        lblStep4.BackColor = step >= 4 ? Color.FromArgb(30, 100, 180) : Color.LightGray;

        lblStep1.ForeColor = step >= 1 ? Color.White : Color.Gray;
        lblStep2.ForeColor = step >= 2 ? Color.White : Color.Gray;
        lblStep3.ForeColor = step >= 3 ? Color.White : Color.Gray;
        lblStep4.ForeColor = step >= 4 ? Color.White : Color.Gray;
    }

    private void UpdateSummary()
    {
        lblSumProyecto.Text = txtProyecto.Text;
        lblSumArea.Text = cmbArea.SelectedIndex >= 0 ? cmbArea.Text : "Sin area";
        lblSumEvaluador.Text = txtEvaluador.Text;
        lblSumNombre.Text = txtNombre.Text;
        lblSumDescripcion.Text = txtDescripcion.Text;

        int f = GetCriterioValue(cmbFuncion);
        int s = GetCriterioValue(cmbSustitucion);
        int p = GetCriterioValue(cmbProfundidad);
        int e = GetCriterioValue(cmbExtension);
        int a = GetCriterioValue(cmbAgresion);
        int v = GetCriterioValue(cmbVulnerabilidad);

        double i = f * s, d = p * e, c = i + d, pr = a * v, er = c * pr;

        lblSumCriterios.Text = $"F={f}  S={s}  P={p}  E={e}  A={a}  V={v}";
        lblSumIndicadores.Text = $"I={i}  D={d}  C={c}  PR={pr}  ER={er}";

        if (er <= 20) { lblSumNivel.Text = "NIVEL: BAJO"; lblSumNivel.BackColor = Color.FromArgb(34, 139, 34); }
        else if (er <= 40) { lblSumNivel.Text = "NIVEL: MEDIO"; lblSumNivel.BackColor = Color.FromArgb(218, 165, 32); lblSumNivel.ForeColor = Color.Black; }
        else if (er <= 60) { lblSumNivel.Text = "NIVEL: ALTO"; lblSumNivel.BackColor = Color.FromArgb(255, 140, 0); lblSumNivel.ForeColor = Color.Black; }
        else { lblSumNivel.Text = "NIVEL: MUY ALTO"; lblSumNivel.BackColor = Color.FromArgb(178, 34, 34); }
        lblSumNivel.ForeColor = Color.White;
    }

    private bool ValidateCurrentStep()
    {
        if (_currentStep == 1)
        {
            if (cmbArea.SelectedIndex < 0) { MessageBox.Show("Seleccione un area."); return false; }
        }
        if (_currentStep == 2)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) { MessageBox.Show("Ingrese el nombre del riesgo."); return false; }
        }
        return true;
    }

    private void btnAtras_Click(object sender, EventArgs e)
    {
        if (_currentStep > 1) ShowStep(_currentStep - 1);
    }

    private void btnSiguiente_Click(object sender, EventArgs e)
    {
        if (ValidateCurrentStep() && _currentStep < 4) ShowStep(_currentStep + 1);
    }

    private void Criterio_Changed(object? sender, EventArgs e)
    {
        if (_currentStep == 4) UpdateSummary();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        if (cmbArea.SelectedIndex < 0 || string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            MessageBox.Show("Complete los datos obligatorios (Area y Nombre).");
            return;
        }

        var risk = new Risk
        {
            Id = _editRiskId ?? Guid.NewGuid(),
            ProjectName = txtProyecto.Text.Trim(),
            AreaId = cmbArea.SelectedValue is Guid guid ? guid : Guid.Empty,
            EvaluatorUser = txtEvaluador.Text.Trim(),
            Name = txtNombre.Text.Trim(),
            Description = txtDescripcion.Text.Trim(),
            Funcion = GetCriterioValue(cmbFuncion),
            Sustitucion = GetCriterioValue(cmbSustitucion),
            Profundidad = GetCriterioValue(cmbProfundidad),
            Extension = GetCriterioValue(cmbExtension),
            Agresion = GetCriterioValue(cmbAgresion),
            Vulnerabilidad = GetCriterioValue(cmbVulnerabilidad)
        };

        if (_editRiskId.HasValue)
            _riskRepo.Update(risk);
        else
            _riskRepo.Insert(risk);

        MessageBox.Show("Evaluacion guardada correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        DialogResult = DialogResult.OK;
        Close();
    }

    private void btnExportar_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Exportacion a Excel disponible desde el listado de riesgos.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
