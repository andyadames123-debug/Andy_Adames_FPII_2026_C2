namespace RiskManagement.App.Forms;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void btnNueva_Click(object sender, EventArgs e)
    {
        var form = new WizardForm();
        form.ShowDialog();
    }

    private void btnListado_Click(object sender, EventArgs e)
    {
        var form = new RiskListForm();
        form.ShowDialog();
    }

    private void btnAreas_Click(object sender, EventArgs e)
    {
        var form = new AreaForm();
        form.ShowDialog();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {

    }
}
