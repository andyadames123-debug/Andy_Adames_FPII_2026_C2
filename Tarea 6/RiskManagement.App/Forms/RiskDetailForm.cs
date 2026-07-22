using RiskManagement.App.Models;
using RiskManagement.App.Repositories;

namespace RiskManagement.App.Forms;

public partial class RiskDetailForm : Form
{
    private readonly AreaRepository _areaRepo;

    public RiskDetailForm(Risk risk)
    {
        InitializeComponent();
        _areaRepo = new AreaRepository();
        LoadData(risk);
    }

    private void LoadData(Risk risk)
    {
        lblProyectoVal.Text = string.IsNullOrEmpty(risk.ProjectName) ? "(Sin proyecto)" : risk.ProjectName;
        lblAreaVal.Text = GetAreaName(risk.AreaId);
        lblEvaluadorVal.Text = string.IsNullOrEmpty(risk.EvaluatorUser) ? "(Sin evaluador)" : risk.EvaluatorUser;
        lblNombreVal.Text = risk.Name;
        lblDescVal.Text = risk.Description;
        lblFechaVal.Text = risk.CreatedAt.ToString("dd/MM/yyyy hh:mm tt");

        lblFVal.Text = $"F = {risk.Funcion}";
        lblSVal.Text = $"S = {risk.Sustitucion}";
        lblPVal.Text = $"P = {risk.Profundidad}";
        lblEVal.Text = $"E = {risk.Extension}";
        lblAVal.Text = $"A = {risk.Agresion}";
        lblVVal.Text = $"V = {risk.Vulnerabilidad}";

        lblIVal.Text = $"I = {risk.I}";
        lblDVal.Text = $"D = {risk.D}";
        lblCVal.Text = $"C = {risk.C}";
        lblPRVal.Text = $"PR = {risk.PR}";
        lblERVal.Text = $"ER = {risk.ER}";

        if (risk.ER <= 20) { lblNivel.Text = "NIVEL: BAJO"; lblNivel.BackColor = Color.FromArgb(34, 139, 34); }
        else if (risk.ER <= 40) { lblNivel.Text = "NIVEL: MEDIO"; lblNivel.BackColor = Color.FromArgb(218, 165, 32); lblNivel.ForeColor = Color.Black; }
        else if (risk.ER <= 60) { lblNivel.Text = "NIVEL: ALTO"; lblNivel.BackColor = Color.FromArgb(255, 140, 0); lblNivel.ForeColor = Color.Black; }
        else { lblNivel.Text = "NIVEL: MUY ALTO"; lblNivel.BackColor = Color.FromArgb(178, 34, 34); }
        lblNivel.ForeColor = Color.White;
    }

    private string GetAreaName(Guid areaId)
    {
        var area = _areaRepo.GetById(areaId);
        return area?.Name ?? "Sin area";
    }

    private void btnCerrar_Click(object sender, EventArgs e) => Close();
}
