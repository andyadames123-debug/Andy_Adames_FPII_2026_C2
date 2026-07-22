namespace RiskManagement.App.Forms;

partial class RiskListForm
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

    private void InitializeComponent()
    {
        lblFiltroArea = new Label(); cmbArea = new ComboBox();
        lblFiltroNivel = new Label(); cmbNivel = new ComboBox();
        btnFiltrar = new Button(); btnDetalle = new Button();
        btnEditar = new Button(); btnEliminar = new Button();
        btnExportar = new Button();
        dgvRisks = new DataGridView(); lblTotal = new Label();
        ((System.ComponentModel.ISupportInitialize)dgvRisks).BeginInit();
        SuspendLayout();

        lblFiltroArea.AutoSize = true; lblFiltroArea.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblFiltroArea.Location = new Point(20, 18); lblFiltroArea.Text = "Area:";
        cmbArea.DropDownStyle = ComboBoxStyle.DropDownList; cmbArea.Location = new Point(70, 15); cmbArea.Size = new Size(180, 27);

        lblFiltroNivel.AutoSize = true; lblFiltroNivel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblFiltroNivel.Location = new Point(270, 18); lblFiltroNivel.Text = "Nivel:";
        cmbNivel.DropDownStyle = ComboBoxStyle.DropDownList; cmbNivel.Location = new Point(320, 15); cmbNivel.Size = new Size(130, 27);

        btnFiltrar.Text = "Filtrar"; btnFiltrar.Size = new Size(80, 32); btnFiltrar.Location = new Point(470, 13);
        btnFiltrar.BackColor = Color.FromArgb(30, 100, 180); btnFiltrar.FlatStyle = FlatStyle.Flat;
        btnFiltrar.ForeColor = Color.White; btnFiltrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnFiltrar.Click += btnFiltrar_Click;

        btnDetalle.Text = "Ver Detalle"; btnDetalle.Size = new Size(100, 32); btnDetalle.Location = new Point(560, 13);
        btnDetalle.BackColor = Color.FromArgb(80, 80, 160); btnDetalle.FlatStyle = FlatStyle.Flat;
        btnDetalle.ForeColor = Color.White; btnDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnDetalle.Click += btnDetalle_Click;

        btnEditar.Text = "Editar"; btnEditar.Size = new Size(80, 32); btnEditar.Location = new Point(670, 13);
        btnEditar.BackColor = Color.FromArgb(218, 165, 32); btnEditar.FlatStyle = FlatStyle.Flat;
        btnEditar.ForeColor = Color.Black; btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnEditar.Click += btnEditar_Click;

        btnEliminar.Text = "Eliminar"; btnEliminar.Size = new Size(80, 32); btnEliminar.Location = new Point(760, 13);
        btnEliminar.BackColor = Color.FromArgb(178, 34, 34); btnEliminar.FlatStyle = FlatStyle.Flat;
        btnEliminar.ForeColor = Color.White; btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnEliminar.Click += btnEliminar_Click;

        btnExportar.Text = "Exportar Excel"; btnExportar.Size = new Size(110, 32); btnExportar.Location = new Point(850, 13);
        btnExportar.BackColor = Color.FromArgb(46, 139, 87); btnExportar.FlatStyle = FlatStyle.Flat;
        btnExportar.ForeColor = Color.White; btnExportar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnExportar.Click += btnExportar_Click;

        dgvRisks.AllowUserToAddRows = false; dgvRisks.AllowUserToDeleteRows = false;
        dgvRisks.BackgroundColor = Color.White; dgvRisks.BorderStyle = BorderStyle.Fixed3D;
        dgvRisks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvRisks.Location = new Point(20, 55); dgvRisks.ReadOnly = true;
        dgvRisks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvRisks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        dgvRisks.Size = new Size(940, 420);

        lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold); lblTotal.Location = new Point(20, 485);
        lblTotal.AutoSize = true; lblTotal.Text = "Total: 0 riesgos";

        AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(980, 515);
        Controls.Add(lblFiltroArea); Controls.Add(cmbArea); Controls.Add(lblFiltroNivel); Controls.Add(cmbNivel);
        Controls.Add(btnFiltrar); Controls.Add(btnDetalle); Controls.Add(btnEditar); Controls.Add(btnEliminar);
        Controls.Add(btnExportar); Controls.Add(dgvRisks); Controls.Add(lblTotal);
        FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false;
        StartPosition = FormStartPosition.CenterParent; Text = "Listado de Riesgos - Metodo MOSLER";
        ((System.ComponentModel.ISupportInitialize)dgvRisks).EndInit();
        ResumeLayout(false); PerformLayout();
    }

    private Label lblFiltroArea; private ComboBox cmbArea;
    private Label lblFiltroNivel; private ComboBox cmbNivel;
    private Button btnFiltrar, btnDetalle, btnEditar, btnEliminar, btnExportar;
    private DataGridView dgvRisks; private Label lblTotal;
}
