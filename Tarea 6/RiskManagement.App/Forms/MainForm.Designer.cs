namespace RiskManagement.App.Forms;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        pnlLogo = new Panel();
        lblLogo = new Label();
        lblSubtitulo = new Label();
        btnNueva = new Button();
        btnListado = new Button();
        btnAreas = new Button();
        pnlLogo.SuspendLayout();
        SuspendLayout();
        // 
        // pnlLogo
        // 
        pnlLogo.BackColor = Color.FromArgb(30, 60, 120);
        pnlLogo.Controls.Add(lblLogo);
        pnlLogo.Controls.Add(lblSubtitulo);
        pnlLogo.Location = new Point(0, 0);
        pnlLogo.Name = "pnlLogo";
        pnlLogo.Size = new Size(438, 100);
        pnlLogo.TabIndex = 0;
        // 
        // lblLogo
        // 
        lblLogo.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
        lblLogo.ForeColor = Color.White;
        lblLogo.Location = new Point(0, 10);
        lblLogo.Name = "lblLogo";
        lblLogo.Size = new Size(438, 50);
        lblLogo.TabIndex = 0;
        lblLogo.Text = "Calculo de Riesgos";
        lblLogo.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblSubtitulo
        // 
        lblSubtitulo.Font = new Font("Segoe UI", 9F);
        lblSubtitulo.ForeColor = Color.FromArgb(180, 200, 240);
        lblSubtitulo.Location = new Point(0, 60);
        lblSubtitulo.Name = "lblSubtitulo";
        lblSubtitulo.Size = new Size(438, 25);
        lblSubtitulo.TabIndex = 1;
        lblSubtitulo.Text = "Sistema de Gestion de Riesgos - Metodo MOSLER";
        lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnNueva
        // 
        btnNueva.BackColor = Color.FromArgb(46, 139, 87);
        btnNueva.FlatStyle = FlatStyle.Flat;
        btnNueva.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnNueva.ForeColor = Color.White;
        btnNueva.Location = new Point(107, 130);
        btnNueva.Name = "btnNueva";
        btnNueva.Size = new Size(220, 50);
        btnNueva.TabIndex = 1;
        btnNueva.Text = "Nueva Evaluacion";
        btnNueva.UseVisualStyleBackColor = false;
        btnNueva.Click += btnNueva_Click;
        // 
        // btnListado
        // 
        btnListado.BackColor = Color.FromArgb(30, 100, 180);
        btnListado.FlatStyle = FlatStyle.Flat;
        btnListado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnListado.ForeColor = Color.White;
        btnListado.Location = new Point(107, 195);
        btnListado.Name = "btnListado";
        btnListado.Size = new Size(220, 50);
        btnListado.TabIndex = 2;
        btnListado.Text = "Ver Evaluaciones";
        btnListado.UseVisualStyleBackColor = false;
        btnListado.Click += btnListado_Click;
        // 
        // btnAreas
        // 
        btnAreas.BackColor = Color.FromArgb(218, 165, 32);
        btnAreas.FlatStyle = FlatStyle.Flat;
        btnAreas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnAreas.ForeColor = Color.Black;
        btnAreas.Location = new Point(107, 260);
        btnAreas.Name = "btnAreas";
        btnAreas.Size = new Size(220, 50);
        btnAreas.TabIndex = 3;
        btnAreas.Text = "Gestionar Areas";
        btnAreas.UseVisualStyleBackColor = false;
        btnAreas.Click += btnAreas_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(438, 340);
        Controls.Add(pnlLogo);
        Controls.Add(btnNueva);
        Controls.Add(btnListado);
        Controls.Add(btnAreas);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "RiskUp - Sistema de Gestion de Riesgos";
        Load += MainForm_Load;
        pnlLogo.ResumeLayout(false);
        ResumeLayout(false);
    }

    private Panel pnlLogo;
    private Label lblLogo;
    private Label lblSubtitulo;
    private Button btnNueva;
    private Button btnListado;
    private Button btnAreas;
}
