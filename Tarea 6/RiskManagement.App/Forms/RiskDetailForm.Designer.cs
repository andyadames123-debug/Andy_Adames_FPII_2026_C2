namespace RiskManagement.App.Forms;

partial class RiskDetailForm
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

    private void InitializeComponent()
    {
        lblTitle = new Label();
        lblNivel = new Label();
        grpInfo = new GroupBox();
        lblProyectoT = new Label(); lblProyectoVal = new Label();
        lblAreaT = new Label(); lblAreaVal = new Label();
        lblEvaluadorT = new Label(); lblEvaluadorVal = new Label();
        lblNombreT = new Label(); lblNombreVal = new Label();
        lblDescT = new Label(); lblDescVal = new Label();
        lblFechaT = new Label(); lblFechaVal = new Label();
        grpCriterios = new GroupBox();
        lblFTitle = new Label(); lblFVal = new Label();
        lblSTitle = new Label(); lblSVal = new Label();
        lblPTitle = new Label(); lblPVal = new Label();
        lblETitle = new Label(); lblEVal = new Label();
        lblATitle = new Label(); lblAVal = new Label();
        lblVTitle = new Label(); lblVVal = new Label();
        grpIndicadores = new GroupBox();
        lblITitle = new Label(); lblIVal = new Label();
        lblDTitle = new Label(); lblDVal = new Label();
        lblCTitle = new Label(); lblCVal = new Label();
        lblPRTitle = new Label(); lblPRVal = new Label();
        lblERTitle = new Label(); lblERVal = new Label();
        btnCerrar = new Button();
        SuspendLayout();

        lblTitle.Text = "Detalle de Evaluacion de Riesgo"; lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(30, 60, 120); lblTitle.Location = new Point(0, 10);
        lblTitle.Size = new Size(700, 35); lblTitle.TextAlign = ContentAlignment.MiddleCenter;

        lblNivel.Font = new Font("Segoe UI", 14F, FontStyle.Bold); lblNivel.ForeColor = Color.White;
        lblNivel.Location = new Point(250, 50); lblNivel.Size = new Size(200, 40);
        lblNivel.TextAlign = ContentAlignment.MiddleCenter; lblNivel.Text = "NIVEL: BAJO";
        lblNivel.BackColor = Color.FromArgb(34, 139, 34);

        grpInfo.Text = "Informacion General"; grpInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        grpInfo.Location = new Point(20, 100); grpInfo.Size = new Size(330, 210);

        int iy = 25;
        AddDetailRow(grpInfo, ref iy, lblProyectoT, "Proyecto:", lblProyectoVal);
        AddDetailRow(grpInfo, ref iy, lblAreaT, "Area:", lblAreaVal);
        AddDetailRow(grpInfo, ref iy, lblEvaluadorT, "Evaluador:", lblEvaluadorVal);
        AddDetailRow(grpInfo, ref iy, lblNombreT, "Riesgo:", lblNombreVal);
        AddDetailRow(grpInfo, ref iy, lblFechaT, "Fecha:", lblFechaVal);
        iy += 5;
        lblDescT.Text = "Descripcion:"; lblDescT.AutoSize = true; lblDescT.Font = new Font("Segoe UI", 8F, FontStyle.Bold); lblDescT.Location = new Point(10, iy);
        iy += 18;
        lblDescVal.Font = new Font("Segoe UI", 8F); lblDescVal.Location = new Point(10, iy); lblDescVal.Size = new Size(310, 40);

        grpInfo.Controls.AddRange(new Control[] { lblProyectoT, lblProyectoVal, lblAreaT, lblAreaVal, lblEvaluadorT, lblEvaluadorVal, lblNombreT, lblNombreVal, lblFechaT, lblFechaVal, lblDescT, lblDescVal });

        grpCriterios.Text = "Criterios MOSLER"; grpCriterios.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        grpCriterios.Location = new Point(360, 100); grpCriterios.Size = new Size(320, 210);

        int cy = 25;
        AddCriterioRow(grpCriterios, ref cy, lblFTitle, "Funcion:", lblFVal);
        AddCriterioRow(grpCriterios, ref cy, lblSTitle, "Sustitucion:", lblSVal);
        AddCriterioRow(grpCriterios, ref cy, lblPTitle, "Profundidad:", lblPVal);
        AddCriterioRow(grpCriterios, ref cy, lblETitle, "Extension:", lblEVal);
        AddCriterioRow(grpCriterios, ref cy, lblATitle, "Agresion:", lblAVal);
        AddCriterioRow(grpCriterios, ref cy, lblVTitle, "Vulnerabilidad:", lblVVal);

        grpCriterios.Controls.AddRange(new Control[] { lblFTitle, lblFVal, lblSTitle, lblSVal, lblPTitle, lblPVal, lblETitle, lblEVal, lblATitle, lblAVal, lblVTitle, lblVVal });

        grpIndicadores.Text = "Indicadores Calculados"; grpIndicadores.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        grpIndicadores.Location = new Point(20, 320); grpIndicadores.Size = new Size(660, 80);

        int ix = 15;
        AddIndicator(grpIndicadores, ref ix, lblITitle, "I", lblIVal);
        AddIndicator(grpIndicadores, ref ix, lblDTitle, "D", lblDVal);
        AddIndicator(grpIndicadores, ref ix, lblCTitle, "C", lblCVal);
        AddIndicator(grpIndicadores, ref ix, lblPRTitle, "PR", lblPRVal);
        AddIndicator(grpIndicadores, ref ix, lblERTitle, "ER", lblERVal);

        grpIndicadores.Controls.AddRange(new Control[] { lblITitle, lblIVal, lblDTitle, lblDVal, lblCTitle, lblCVal, lblPRTitle, lblPRVal, lblERTitle, lblERVal });

        btnCerrar.Text = "Cerrar"; btnCerrar.Size = new Size(120, 35); btnCerrar.Location = new Point(290, 415);
        btnCerrar.BackColor = Color.FromArgb(100, 100, 100); btnCerrar.FlatStyle = FlatStyle.Flat;
        btnCerrar.ForeColor = Color.White; btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnCerrar.Click += btnCerrar_Click;

        AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(700, 465);
        Controls.Add(lblTitle); Controls.Add(lblNivel);
        Controls.Add(grpInfo); Controls.Add(grpCriterios); Controls.Add(grpIndicadores);
        Controls.Add(btnCerrar);
        FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false;
        StartPosition = FormStartPosition.CenterParent; Text = "Detalle de Riesgo";
        ResumeLayout(false); PerformLayout();
    }

    private void AddDetailRow(GroupBox grp, ref int y, Label lblT, string text, Label lblV)
    {
        lblT.Text = text; lblT.AutoSize = true; lblT.Font = new Font("Segoe UI", 8F, FontStyle.Bold); lblT.Location = new Point(10, y);
        lblV.Font = new Font("Segoe UI", 8F); lblV.Location = new Point(100, y); lblV.Size = new Size(220, 18);
        y += 22;
    }

    private void AddCriterioRow(GroupBox grp, ref int y, Label lblT, string text, Label lblV)
    {
        lblT.Text = text; lblT.AutoSize = true; lblT.Font = new Font("Segoe UI", 9F); lblT.Location = new Point(10, y);
        lblV.Font = new Font("Segoe UI", 9F, FontStyle.Bold); lblV.Location = new Point(120, y); lblV.Size = new Size(180, 18);
        y += 24;
    }

    private void AddIndicator(GroupBox grp, ref int x, Label lblT, string title, Label lblV)
    {
        lblT.Text = title; lblT.Font = new Font("Segoe UI", 9F); lblT.Location = new Point(x, 25); lblT.AutoSize = true;
        lblV.Font = new Font("Segoe UI", 11F, FontStyle.Bold); lblV.ForeColor = Color.FromArgb(30, 60, 120);
        lblV.Location = new Point(x - 5, 48); lblV.Size = new Size(115, 20); lblV.TextAlign = ContentAlignment.TopCenter;
        x += 130;
    }

    private Label lblTitle, lblNivel;
    private GroupBox grpInfo;
    private Label lblProyectoT, lblProyectoVal, lblAreaT, lblAreaVal, lblEvaluadorT, lblEvaluadorVal;
    private Label lblNombreT, lblNombreVal, lblDescT, lblDescVal, lblFechaT, lblFechaVal;
    private GroupBox grpCriterios;
    private Label lblFTitle, lblFVal, lblSTitle, lblSVal, lblPTitle, lblPVal;
    private Label lblETitle, lblEVal, lblATitle, lblAVal, lblVTitle, lblVVal;
    private GroupBox grpIndicadores;
    private Label lblITitle, lblIVal, lblDTitle, lblDVal, lblCTitle, lblCVal;
    private Label lblPRTitle, lblPRVal, lblERTitle, lblERVal;
    private Button btnCerrar;
}
