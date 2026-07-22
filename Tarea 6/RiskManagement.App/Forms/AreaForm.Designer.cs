namespace RiskManagement.App.Forms;

partial class AreaForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblNombre = new Label();
        txtNombre = new TextBox();
        lblDescripcion = new Label();
        txtDescripcion = new TextBox();
        btnGuardar = new Button();
        btnEliminar = new Button();
        btnLimpiar = new Button();
        dgvAreas = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvAreas).BeginInit();
        SuspendLayout();

        // lblNombre
        lblNombre.AutoSize = true;
        lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblNombre.Location = new Point(20, 20);
        lblNombre.Text = "Nombre:";

        // txtNombre
        txtNombre.Location = new Point(120, 18);
        txtNombre.Size = new Size(350, 27);

        // lblDescripcion
        lblDescripcion.AutoSize = true;
        lblDescripcion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblDescripcion.Location = new Point(20, 60);
        lblDescripcion.Text = "Descripcion:";

        // txtDescripcion
        txtDescripcion.Location = new Point(120, 58);
        txtDescripcion.Size = new Size(350, 60);
        txtDescripcion.Multiline = true;
        txtDescripcion.ScrollBars = ScrollBars.Vertical;

        // btnGuardar
        btnGuardar.BackColor = Color.FromArgb(46, 139, 87);
        btnGuardar.FlatStyle = FlatStyle.Flat;
        btnGuardar.ForeColor = Color.White;
        btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnGuardar.Location = new Point(120, 135);
        btnGuardar.Size = new Size(110, 35);
        btnGuardar.Text = "Guardar";
        btnGuardar.Click += btnGuardar_Click;

        // btnEliminar
        btnEliminar.BackColor = Color.FromArgb(178, 34, 34);
        btnEliminar.FlatStyle = FlatStyle.Flat;
        btnEliminar.ForeColor = Color.White;
        btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnEliminar.Location = new Point(245, 135);
        btnEliminar.Size = new Size(110, 35);
        btnEliminar.Text = "Eliminar";
        btnEliminar.Click += btnEliminar_Click;

        // btnLimpiar
        btnLimpiar.BackColor = Color.FromArgb(100, 100, 100);
        btnLimpiar.FlatStyle = FlatStyle.Flat;
        btnLimpiar.ForeColor = Color.White;
        btnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnLimpiar.Location = new Point(370, 135);
        btnLimpiar.Size = new Size(110, 35);
        btnLimpiar.Text = "Limpiar";
        btnLimpiar.Click += btnLimpiar_Click;

        // dgvAreas
        dgvAreas.AllowUserToAddRows = false;
        dgvAreas.AllowUserToDeleteRows = false;
        dgvAreas.BackgroundColor = Color.White;
        dgvAreas.BorderStyle = BorderStyle.Fixed3D;
        dgvAreas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvAreas.Location = new Point(20, 190);
        dgvAreas.ReadOnly = true;
        dgvAreas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvAreas.Size = new Size(450, 280);
        dgvAreas.CellClick += dgvAreas_CellClick;

        // AreaForm
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(490, 490);
        Controls.Add(lblNombre);
        Controls.Add(txtNombre);
        Controls.Add(lblDescripcion);
        Controls.Add(txtDescripcion);
        Controls.Add(btnGuardar);
        Controls.Add(btnEliminar);
        Controls.Add(btnLimpiar);
        Controls.Add(dgvAreas);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Gestion de Areas";
        ((System.ComponentModel.ISupportInitialize)dgvAreas).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblNombre;
    private TextBox txtNombre;
    private Label lblDescripcion;
    private TextBox txtDescripcion;
    private Button btnGuardar;
    private Button btnEliminar;
    private Button btnLimpiar;
    private DataGridView dgvAreas;
}
