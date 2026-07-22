namespace RiskManagement.App.Forms;

partial class WizardForm
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

    private void InitializeComponent()
    {
        // Step indicators
        lblStep1 = new Label(); lblStep2 = new Label(); lblStep3 = new Label(); lblStep4 = new Label();
        lblStep1T = new Label(); lblStep2T = new Label(); lblStep3T = new Label(); lblStep4T = new Label();

        // Step 1
        pnlPaso1 = new Panel(); lblProyecto = new Label(); txtProyecto = new TextBox();
        lblArea = new Label(); cmbArea = new ComboBox();
        lblEvaluador = new Label(); txtEvaluador = new TextBox();

        // Step 2
        pnlPaso2 = new Panel(); lblNombre = new Label(); txtNombre = new TextBox();
        lblDescripcion = new Label(); txtDescripcion = new TextBox();

        // Step 3
        pnlPaso3 = new Panel();
        lblFuncion = new Label(); cmbFuncion = new ComboBox();
        lblSustitucion = new Label(); cmbSustitucion = new ComboBox();
        lblProfundidad = new Label(); cmbProfundidad = new ComboBox();
        lblExtension = new Label(); cmbExtension = new ComboBox();
        lblAgresion = new Label(); cmbAgresion = new ComboBox();
        lblVulnerabilidad = new Label(); cmbVulnerabilidad = new ComboBox();

        // Step 4
        pnlPaso4 = new Panel();
        lblSumProyectoT = new Label(); lblSumProyecto = new Label();
        lblSumAreaT = new Label(); lblSumArea = new Label();
        lblSumEvaluadorT = new Label(); lblSumEvaluador = new Label();
        lblSumNombreT = new Label(); lblSumNombre = new Label();
        lblSumDescT = new Label(); lblSumDescripcion = new Label();
        lblSumCriteriosT = new Label(); lblSumCriterios = new Label();
        lblSumIndT = new Label(); lblSumIndicadores = new Label();
        lblSumNivel = new Label();

        // Navigation
        btnAtras = new Button(); btnSiguiente = new Button(); btnGuardar = new Button();

        SuspendLayout();

        // === Step Indicators ===
        int sx = 20;
        SetupIndicator(lblStep1, lblStep1T, "1", "Datos", sx); sx += 130;
        SetupIndicator(lblStep2, lblStep2T, "2", "Descripcion", sx); sx += 130;
        SetupIndicator(lblStep3, lblStep3T, "3", "Criterios", sx); sx += 130;
        SetupIndicator(lblStep4, lblStep4T, "4", "Resumen", sx);

        // === STEP 1: Datos Generales ===
        pnlPaso1.Location = new Point(20, 75); pnlPaso1.Size = new Size(530, 320);
        pnlPaso1.BackColor = Color.White; pnlPaso1.BorderStyle = BorderStyle.FixedSingle;

        lblProyecto.Text = "Nombre del Proyecto:"; lblProyecto.AutoSize = true; lblProyecto.Font = new Font("Segoe UI", 10F, FontStyle.Bold); lblProyecto.Location = new Point(20, 25);
        txtProyecto.Font = new Font("Segoe UI", 10F); txtProyecto.Location = new Point(200, 22); txtProyecto.Size = new Size(300, 27);

        lblArea.Text = "Area:"; lblArea.AutoSize = true; lblArea.Font = new Font("Segoe UI", 10F, FontStyle.Bold); lblArea.Location = new Point(20, 70);
        cmbArea.DropDownStyle = ComboBoxStyle.DropDownList; cmbArea.Font = new Font("Segoe UI", 10F); cmbArea.Location = new Point(200, 67); cmbArea.Size = new Size(300, 27);

        lblEvaluador.Text = "Usuario Evaluador:"; lblEvaluador.AutoSize = true; lblEvaluador.Font = new Font("Segoe UI", 10F, FontStyle.Bold); lblEvaluador.Location = new Point(20, 115);
        txtEvaluador.Font = new Font("Segoe UI", 10F); txtEvaluador.Location = new Point(200, 112); txtEvaluador.Size = new Size(300, 27);

        pnlPaso1.Controls.AddRange(new Control[] { lblProyecto, txtProyecto, lblArea, cmbArea, lblEvaluador, txtEvaluador });

        // === STEP 2: Descripcion ===
        pnlPaso2.Location = new Point(20, 75); pnlPaso2.Size = new Size(530, 320);
        pnlPaso2.BackColor = Color.White; pnlPaso2.BorderStyle = BorderStyle.FixedSingle; pnlPaso2.Visible = false;

        lblNombre.Text = "Nombre del Riesgo:"; lblNombre.AutoSize = true; lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold); lblNombre.Location = new Point(20, 25);
        txtNombre.Font = new Font("Segoe UI", 10F); txtNombre.Location = new Point(180, 22); txtNombre.Size = new Size(320, 27);

        lblDescripcion.Text = "Descripcion Detallada:"; lblDescripcion.AutoSize = true; lblDescripcion.Font = new Font("Segoe UI", 10F, FontStyle.Bold); lblDescripcion.Location = new Point(20, 70);
        txtDescripcion.Font = new Font("Segoe UI", 10F); txtDescripcion.Location = new Point(180, 68); txtDescripcion.Size = new Size(320, 180);
        txtDescripcion.Multiline = true; txtDescripcion.ScrollBars = ScrollBars.Vertical;

        pnlPaso2.Controls.AddRange(new Control[] { lblNombre, txtNombre, lblDescripcion, txtDescripcion });

        // === STEP 3: Criterios MOSLER ===
        pnlPaso3.Location = new Point(20, 75); pnlPaso3.Size = new Size(530, 320);
        pnlPaso3.BackColor = Color.White; pnlPaso3.BorderStyle = BorderStyle.FixedSingle; pnlPaso3.Visible = false;

        int y = 10;
        AddCriterio(pnlPaso3, ref y, lblFuncion, "Que tan critica es la Funcion afectada?", cmbFuncion);
        AddCriterio(pnlPaso3, ref y, lblSustitucion, "Que tan dificil es la Sustitucion?", cmbSustitucion);
        AddCriterio(pnlPaso3, ref y, lblProfundidad, "Que tan profundo es el dano?", cmbProfundidad);
        AddCriterio(pnlPaso3, ref y, lblExtension, "A cuantas areas afecta?", cmbExtension);
        AddCriterio(pnlPaso3, ref y, lblAgresion, "Que tan probable es la amenaza?", cmbAgresion);
        AddCriterio(pnlPaso3, ref y, lblVulnerabilidad, "Que tan desprotegidos estamos?", cmbVulnerabilidad);

        // === STEP 4: Resumen ===
        pnlPaso4.Location = new Point(20, 75); pnlPaso4.Size = new Size(530, 320);
        pnlPaso4.BackColor = Color.White; pnlPaso4.BorderStyle = BorderStyle.FixedSingle; pnlPaso4.Visible = false;

        int sy = 10;
        AddSummaryRow(pnlPaso4, ref sy, lblSumProyectoT, "Proyecto:", lblSumProyecto);
        AddSummaryRow(pnlPaso4, ref sy, lblSumAreaT, "Area:", lblSumArea);
        AddSummaryRow(pnlPaso4, ref sy, lblSumEvaluadorT, "Evaluador:", lblSumEvaluador);
        AddSummaryRow(pnlPaso4, ref sy, lblSumNombreT, "Riesgo:", lblSumNombre);
        AddSummaryRow(pnlPaso4, ref sy, lblSumDescT, "Descripcion:", lblSumDescripcion);
        sy += 10;
        AddSummaryRow(pnlPaso4, ref sy, lblSumCriteriosT, "Criterios:", lblSumCriterios);
        AddSummaryRow(pnlPaso4, ref sy, lblSumIndT, "Indicadores:", lblSumIndicadores);
        sy += 10;

        lblSumNivel.Font = new Font("Segoe UI", 16F, FontStyle.Bold); lblSumNivel.ForeColor = Color.White;
        lblSumNivel.Location = new Point(100, sy); lblSumNivel.Size = new Size(320, 50);
        lblSumNivel.TextAlign = ContentAlignment.MiddleCenter; lblSumNivel.Text = "NIVEL: BAJO";
        lblSumNivel.BackColor = Color.FromArgb(34, 139, 34);

        pnlPaso4.Controls.AddRange(new Control[] {
            lblSumProyectoT, lblSumProyecto, lblSumAreaT, lblSumArea,
            lblSumEvaluadorT, lblSumEvaluador, lblSumNombreT, lblSumNombre,
            lblSumDescT, lblSumDescripcion, lblSumCriteriosT, lblSumCriterios,
            lblSumIndT, lblSumIndicadores, lblSumNivel
        });

        // === Navigation Buttons ===
        btnAtras.Text = "Atras"; btnAtras.Size = new Size(120, 40); btnAtras.Location = new Point(20, 410);
        btnAtras.BackColor = Color.Gray; btnAtras.FlatStyle = FlatStyle.Flat; btnAtras.ForeColor = Color.White;
        btnAtras.Font = new Font("Segoe UI", 10F, FontStyle.Bold); btnAtras.Click += btnAtras_Click;

        btnSiguiente.Text = "Siguiente"; btnSiguiente.Size = new Size(120, 40); btnSiguiente.Location = new Point(430, 410);
        btnSiguiente.BackColor = Color.FromArgb(30, 100, 180); btnSiguiente.FlatStyle = FlatStyle.Flat; btnSiguiente.ForeColor = Color.White;
        btnSiguiente.Font = new Font("Segoe UI", 10F, FontStyle.Bold); btnSiguiente.Click += btnSiguiente_Click;

        btnGuardar.Text = "Guardar Evaluacion"; btnGuardar.Size = new Size(180, 40); btnGuardar.Location = new Point(370, 410);
        btnGuardar.BackColor = Color.FromArgb(46, 139, 87); btnGuardar.FlatStyle = FlatStyle.Flat; btnGuardar.ForeColor = Color.White;
        btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold); btnGuardar.Click += btnGuardar_Click; btnGuardar.Visible = false;

        // WizardForm
        AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(570, 465);
        Controls.Add(lblStep1); Controls.Add(lblStep1T); Controls.Add(lblStep2); Controls.Add(lblStep2T);
        Controls.Add(lblStep3); Controls.Add(lblStep3T); Controls.Add(lblStep4); Controls.Add(lblStep4T);
        Controls.Add(pnlPaso1); Controls.Add(pnlPaso2); Controls.Add(pnlPaso3); Controls.Add(pnlPaso4);
        Controls.Add(btnAtras); Controls.Add(btnSiguiente); Controls.Add(btnGuardar);
        FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false;
        StartPosition = FormStartPosition.CenterParent; Text = "Evaluacion de Riesgos - Metodo MOSLER";
        ResumeLayout(false); PerformLayout();
    }

    private void SetupIndicator(Label lbl, Label lblT, string num, string text, int x)
    {
        lbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold); lbl.ForeColor = Color.White;
        lbl.BackColor = Color.LightGray; lbl.Location = new Point(x, 15); lbl.Size = new Size(30, 30);
        lbl.TextAlign = ContentAlignment.MiddleCenter; lbl.Text = num;
        lblT.AutoSize = true; lblT.Font = new Font("Segoe UI", 8F); lblT.Text = text;
        lblT.Location = new Point(x - 5, 50);
    }

    private void AddCriterio(Panel pnl, ref int y, Label lbl, string text, ComboBox cmb)
    {
        lbl.Text = text; lbl.AutoSize = true; lbl.Location = new Point(10, y); lbl.Font = new Font("Segoe UI", 8F);
        y += 18;
        cmb.DropDownStyle = ComboBoxStyle.DropDownList; cmb.Font = new Font("Segoe UI", 9F);
        cmb.Location = new Point(10, y); cmb.Size = new Size(505, 24); cmb.SelectedIndexChanged += Criterio_Changed;
        y += 32;
        pnl.Controls.Add(lbl); pnl.Controls.Add(cmb);
    }

    private void AddSummaryRow(Panel pnl, ref int y, Label lblT, string text, Label lblV)
    {
        lblT.Text = text; lblT.AutoSize = true; lblT.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblT.Location = new Point(10, y); lblV.Font = new Font("Segoe UI", 9F);
        lblV.Location = new Point(120, y); lblV.Size = new Size(390, 20); lblV.Text = "";
        y += 24;
    }

    // Fields
    private Label lblStep1, lblStep2, lblStep3, lblStep4, lblStep1T, lblStep2T, lblStep3T, lblStep4T;
    private Panel pnlPaso1, pnlPaso2, pnlPaso3, pnlPaso4;
    private Label lblProyecto; private TextBox txtProyecto;
    private Label lblArea; private ComboBox cmbArea;
    private Label lblEvaluador; private TextBox txtEvaluador;
    private Label lblNombre; private TextBox txtNombre;
    private Label lblDescripcion; private TextBox txtDescripcion;
    private Label lblFuncion; private ComboBox cmbFuncion;
    private Label lblSustitucion; private ComboBox cmbSustitucion;
    private Label lblProfundidad; private ComboBox cmbProfundidad;
    private Label lblExtension; private ComboBox cmbExtension;
    private Label lblAgresion; private ComboBox cmbAgresion;
    private Label lblVulnerabilidad; private ComboBox cmbVulnerabilidad;
    private Label lblSumProyectoT, lblSumProyecto, lblSumAreaT, lblSumArea;
    private Label lblSumEvaluadorT, lblSumEvaluador, lblSumNombreT, lblSumNombre;
    private Label lblSumDescT, lblSumDescripcion, lblSumCriteriosT, lblSumCriterios;
    private Label lblSumIndT, lblSumIndicadores, lblSumNivel;
    private Button btnAtras, btnSiguiente, btnGuardar;
}
