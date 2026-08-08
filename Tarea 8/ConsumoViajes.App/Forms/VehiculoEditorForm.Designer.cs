namespace ConsumoViajes.App.Forms;

partial class VehiculoEditorForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblNombre = new Label();
        txtNombre = new TextBox();
        lblConsumoCiudad = new Label();
        numConsumoCiudad = new NumericUpDown();
        lblConsumoCarretera = new Label();
        numConsumoCarretera = new NumericUpDown();
        lblCapacidad = new Label();
        numCapacidad = new NumericUpDown();
        btnGuardar = new Button();
        btnCancelar = new Button();
        ((System.ComponentModel.ISupportInitialize)numConsumoCiudad).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numConsumoCarretera).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numCapacidad).BeginInit();
        SuspendLayout();
        // 
        // lblNombre
        // 
        lblNombre.AutoSize = true;
        lblNombre.Location = new Point(18, 18);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(139, 20);
        lblNombre.TabIndex = 0;
        lblNombre.Text = "Nombre / Modelo:";
        // 
        // txtNombre
        // 
        txtNombre.Location = new Point(175, 15);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(260, 27);
        txtNombre.TabIndex = 1;
        txtNombre.PlaceholderText = "Ej: Daihatsu Mira";
        // 
        // lblConsumoCiudad
        // 
        lblConsumoCiudad.AutoSize = true;
        lblConsumoCiudad.Location = new Point(18, 58);
        lblConsumoCiudad.Name = "lblConsumoCiudad";
        lblConsumoCiudad.Size = new Size(218, 20);
        lblConsumoCiudad.TabIndex = 2;
        lblConsumoCiudad.Text = "Consumo base ciudad (Km/Galón):";
        // 
        // numConsumoCiudad
        // 
        numConsumoCiudad.DecimalPlaces = 2;
        numConsumoCiudad.Location = new Point(175, 55);
        numConsumoCiudad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        numConsumoCiudad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numConsumoCiudad.Name = "numConsumoCiudad";
        numConsumoCiudad.Size = new Size(130, 27);
        numConsumoCiudad.TabIndex = 3;
        numConsumoCiudad.Value = new decimal(new int[] { 28, 0, 0, 0 });
        // 
        // lblConsumoCarretera
        // 
        lblConsumoCarretera.AutoSize = true;
        lblConsumoCarretera.Location = new Point(18, 98);
        lblConsumoCarretera.Name = "lblConsumoCarretera";
        lblConsumoCarretera.Size = new Size(226, 20);
        lblConsumoCarretera.TabIndex = 4;
        lblConsumoCarretera.Text = "Consumo base carretera (Km/Galón):";
        // 
        // numConsumoCarretera
        // 
        numConsumoCarretera.DecimalPlaces = 2;
        numConsumoCarretera.Location = new Point(175, 95);
        numConsumoCarretera.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        numConsumoCarretera.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numConsumoCarretera.Name = "numConsumoCarretera";
        numConsumoCarretera.Size = new Size(130, 27);
        numConsumoCarretera.TabIndex = 5;
        numConsumoCarretera.Value = new decimal(new int[] { 40, 0, 0, 0 });
        // 
        // lblCapacidad
        // 
        lblCapacidad.AutoSize = true;
        lblCapacidad.Location = new Point(18, 138);
        lblCapacidad.Name = "lblCapacidad";
        lblCapacidad.Size = new Size(151, 20);
        lblCapacidad.TabIndex = 6;
        lblCapacidad.Text = "Capacidad del tanque (Galones):";
        // 
        // numCapacidad
        // 
        numCapacidad.DecimalPlaces = 2;
        numCapacidad.Location = new Point(175, 135);
        numCapacidad.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
        numCapacidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numCapacidad.Name = "numCapacidad";
        numCapacidad.Size = new Size(130, 27);
        numCapacidad.TabIndex = 7;
        numCapacidad.Value = new decimal(new int[] { 9, 0, 0, 0 });
        // 
        // btnGuardar
        // 
        btnGuardar.Location = new Point(236, 180);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(100, 34);
        btnGuardar.TabIndex = 8;
        btnGuardar.Text = "Guardar";
        btnGuardar.UseVisualStyleBackColor = true;
        btnGuardar.Click += btnGuardar_Click;
        // 
        // btnCancelar
        // 
        btnCancelar.DialogResult = DialogResult.Cancel;
        btnCancelar.Location = new Point(342, 180);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(100, 34);
        btnCancelar.TabIndex = 9;
        btnCancelar.Text = "Cancelar";
        btnCancelar.UseVisualStyleBackColor = true;
        // 
        // VehiculoEditorForm
        // 
        AcceptButton = btnGuardar;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = btnCancelar;
        ClientSize = new Size(458, 232);
        Controls.Add(btnCancelar);
        Controls.Add(btnGuardar);
        Controls.Add(numCapacidad);
        Controls.Add(lblCapacidad);
        Controls.Add(numConsumoCarretera);
        Controls.Add(lblConsumoCarretera);
        Controls.Add(numConsumoCiudad);
        Controls.Add(lblConsumoCiudad);
        Controls.Add(txtNombre);
        Controls.Add(lblNombre);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "VehiculoEditorForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Vehículo";
        ((System.ComponentModel.ISupportInitialize)numConsumoCiudad).EndInit();
        ((System.ComponentModel.ISupportInitialize)numConsumoCarretera).EndInit();
        ((System.ComponentModel.ISupportInitialize)numCapacidad).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblNombre;
    private TextBox txtNombre;
    private Label lblConsumoCiudad;
    private NumericUpDown numConsumoCiudad;
    private Label lblConsumoCarretera;
    private NumericUpDown numConsumoCarretera;
    private Label lblCapacidad;
    private NumericUpDown numCapacidad;
    private Button btnGuardar;
    private Button btnCancelar;
}
