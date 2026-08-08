namespace ConsumoViajes.App.Forms;

partial class MainForm
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

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lblTitulo = new Label();
        grpVehiculo = new GroupBox();
        cmbVehiculo = new ComboBox();
        lblVehiculo = new Label();
        btnNuevoVehiculo = new Button();
        btnEditarVehiculo = new Button();
        btnEliminarVehiculo = new Button();
        grpViaje = new GroupBox();
        lblDistancia = new Label();
        numDistancia = new NumericUpDown();
        lblPrecio = new Label();
        numPrecio = new NumericUpDown();
        lblOcupantes = new Label();
        numOcupantes = new NumericUpDown();
        lblMixTitle = new Label();
        trkCiudad = new TrackBar();
        lblPctMix = new Label();
        btnCalcular = new Button();
        grpResultados = new GroupBox();
        lblCostoEtiqueta = new Label();
        lblCostoValor = new Label();
        lblCombustibleEtiqueta = new Label();
        lblCombustibleValor = new Label();
        lblRendimientoEtiqueta = new Label();
        lblRendimientoValor = new Label();
        lblTanqueEtiqueta = new Label();
        lblTanqueValor = new Label();
        prbTanque = new ProgressBar();
        lblDetalle = new Label();
        grpVehiculo.SuspendLayout();
        grpViaje.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numDistancia).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numOcupantes).BeginInit();
        ((System.ComponentModel.ISupportInitialize)trkCiudad).BeginInit();
        grpResultados.SuspendLayout();
        SuspendLayout();
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitulo.Location = new Point(20, 14);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(360, 37);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Calculadora de Consumo de Viajes";
        // 
        // grpVehiculo
        // 
        grpVehiculo.Controls.Add(cmbVehiculo);
        grpVehiculo.Controls.Add(lblVehiculo);
        grpVehiculo.Controls.Add(btnNuevoVehiculo);
        grpVehiculo.Controls.Add(btnEditarVehiculo);
        grpVehiculo.Controls.Add(btnEliminarVehiculo);
        grpVehiculo.Location = new Point(20, 55);
        grpVehiculo.Name = "grpVehiculo";
        grpVehiculo.Size = new Size(800, 96);
        grpVehiculo.TabIndex = 1;
        grpVehiculo.TabStop = false;
        grpVehiculo.Text = "1. Selección de vehículo";
        // 
        // lblVehiculo
        // 
        lblVehiculo.AutoSize = true;
        lblVehiculo.Location = new Point(14, 34);
        lblVehiculo.Name = "lblVehiculo";
        lblVehiculo.Size = new Size(74, 20);
        lblVehiculo.TabIndex = 0;
        lblVehiculo.Text = "Vehículo:";
        // 
        // cmbVehiculo
        // 
        cmbVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbVehiculo.FormattingEnabled = true;
        cmbVehiculo.Location = new Point(96, 30);
        cmbVehiculo.Name = "cmbVehiculo";
        cmbVehiculo.Size = new Size(340, 28);
        cmbVehiculo.TabIndex = 1;
        cmbVehiculo.SelectedIndexChanged += cmbVehiculo_SelectedIndexChanged;
        // 
        // btnNuevoVehiculo
        // 
        btnNuevoVehiculo.Location = new Point(456, 28);
        btnNuevoVehiculo.Name = "btnNuevoVehiculo";
        btnNuevoVehiculo.Size = new Size(104, 34);
        btnNuevoVehiculo.TabIndex = 2;
        btnNuevoVehiculo.Text = "Nuevo...";
        btnNuevoVehiculo.UseVisualStyleBackColor = true;
        btnNuevoVehiculo.Click += btnNuevoVehiculo_Click;
        // 
        // btnEditarVehiculo
        // 
        btnEditarVehiculo.Location = new Point(568, 28);
        btnEditarVehiculo.Name = "btnEditarVehiculo";
        btnEditarVehiculo.Size = new Size(104, 34);
        btnEditarVehiculo.TabIndex = 3;
        btnEditarVehiculo.Text = "Editar...";
        btnEditarVehiculo.UseVisualStyleBackColor = true;
        btnEditarVehiculo.Click += btnEditarVehiculo_Click;
        // 
        // btnEliminarVehiculo
        // 
        btnEliminarVehiculo.Location = new Point(680, 28);
        btnEliminarVehiculo.Name = "btnEliminarVehiculo";
        btnEliminarVehiculo.Size = new Size(100, 34);
        btnEliminarVehiculo.TabIndex = 4;
        btnEliminarVehiculo.Text = "Eliminar";
        btnEliminarVehiculo.UseVisualStyleBackColor = true;
        btnEliminarVehiculo.Click += btnEliminarVehiculo_Click;
        // 
        // grpViaje
        // 
        grpViaje.Controls.Add(lblDistancia);
        grpViaje.Controls.Add(numDistancia);
        grpViaje.Controls.Add(lblPrecio);
        grpViaje.Controls.Add(numPrecio);
        grpViaje.Controls.Add(lblOcupantes);
        grpViaje.Controls.Add(numOcupantes);
        grpViaje.Controls.Add(lblMixTitle);
        grpViaje.Controls.Add(trkCiudad);
        grpViaje.Controls.Add(lblPctMix);
        grpViaje.Location = new Point(20, 165);
        grpViaje.Name = "grpViaje";
        grpViaje.Size = new Size(800, 210);
        grpViaje.TabIndex = 2;
        grpViaje.TabStop = false;
        grpViaje.Text = "2. Datos del viaje";
        // 
        // lblDistancia
        // 
        lblDistancia.AutoSize = true;
        lblDistancia.Location = new Point(14, 33);
        lblDistancia.Name = "lblDistancia";
        lblDistancia.Size = new Size(191, 20);
        lblDistancia.TabIndex = 0;
        lblDistancia.Text = "Distancia total del viaje (Km):";
        // 
        // numDistancia
        // 
        numDistancia.Location = new Point(258, 30);
        numDistancia.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        numDistancia.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numDistancia.Name = "numDistancia";
        numDistancia.Size = new Size(140, 27);
        numDistancia.TabIndex = 1;
        numDistancia.Value = new decimal(new int[] { 100, 0, 0, 0 });
        numDistancia.ValueChanged += numDatos_ValueChanged;
        // 
        // lblPrecio
        // 
        lblPrecio.AutoSize = true;
        lblPrecio.Location = new Point(14, 70);
        lblPrecio.Name = "lblPrecio";
        lblPrecio.Size = new Size(231, 20);
        lblPrecio.TabIndex = 2;
        lblPrecio.Text = "Precio del combustible (RD$/Galón):";
        // 
        // numPrecio
        // 
        numPrecio.DecimalPlaces = 2;
        numPrecio.Increment = new decimal(new int[] { 5, 0, 0, 0 });
        numPrecio.Location = new Point(258, 67);
        numPrecio.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        numPrecio.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numPrecio.Name = "numPrecio";
        numPrecio.Size = new Size(140, 27);
        numPrecio.TabIndex = 3;
        numPrecio.Value = new decimal(new int[] { 200, 0, 0, 0 });
        numPrecio.ValueChanged += numDatos_ValueChanged;
        // 
        // lblOcupantes
        // 
        lblOcupantes.AutoSize = true;
        lblOcupantes.Location = new Point(14, 107);
        lblOcupantes.Name = "lblOcupantes";
        lblOcupantes.Size = new Size(236, 20);
        lblOcupantes.TabIndex = 4;
        lblOcupantes.Text = "Ocupantes (incluye al conductor):";
        // 
        // numOcupantes
        // 
        numOcupantes.Location = new Point(258, 104);
        numOcupantes.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
        numOcupantes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numOcupantes.Name = "numOcupantes";
        numOcupantes.Size = new Size(140, 27);
        numOcupantes.TabIndex = 5;
        numOcupantes.Value = new decimal(new int[] { 1, 0, 0, 0 });
        numOcupantes.ValueChanged += numDatos_ValueChanged;
        // 
        // lblMixTitle
        // 
        lblMixTitle.AutoSize = true;
        lblMixTitle.Location = new Point(14, 148);
        lblMixTitle.Name = "lblMixTitle";
        lblMixTitle.Size = new Size(149, 20);
        lblMixTitle.TabIndex = 6;
        lblMixTitle.Text = "Distribución del trayecto:";
        // 
        // trkCiudad
        // 
        trkCiudad.LargeChange = 10;
        trkCiudad.Location = new Point(170, 134);
        trkCiudad.Maximum = 100;
        trkCiudad.Name = "trkCiudad";
        trkCiudad.Size = new Size(330, 56);
        trkCiudad.SmallChange = 5;
        trkCiudad.TabIndex = 7;
        trkCiudad.TickFrequency = 10;
        trkCiudad.Value = 50;
        trkCiudad.Scroll += trkCiudad_Scroll;
        // 
        // lblPctMix
        // 
        lblPctMix.AutoSize = true;
        lblPctMix.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblPctMix.Location = new Point(510, 148);
        lblPctMix.Name = "lblPctMix";
        lblPctMix.Size = new Size(150, 20);
        lblPctMix.TabIndex = 8;
        lblPctMix.Text = "50% Ciudad / 50% Carretera";
        // 
        // btnCalcular
        // 
        btnCalcular.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnCalcular.Location = new Point(20, 390);
        btnCalcular.Name = "btnCalcular";
        btnCalcular.Size = new Size(800, 42);
        btnCalcular.TabIndex = 3;
        btnCalcular.Text = "Calcular viaje";
        btnCalcular.UseVisualStyleBackColor = true;
        btnCalcular.Click += btnCalcular_Click;
        // 
        // grpResultados
        // 
        grpResultados.Controls.Add(lblCostoEtiqueta);
        grpResultados.Controls.Add(lblCostoValor);
        grpResultados.Controls.Add(lblCombustibleEtiqueta);
        grpResultados.Controls.Add(lblCombustibleValor);
        grpResultados.Controls.Add(lblRendimientoEtiqueta);
        grpResultados.Controls.Add(lblRendimientoValor);
        grpResultados.Controls.Add(lblTanqueEtiqueta);
        grpResultados.Controls.Add(lblTanqueValor);
        grpResultados.Controls.Add(prbTanque);
        grpResultados.Controls.Add(lblDetalle);
        grpResultados.Location = new Point(20, 450);
        grpResultados.Name = "grpResultados";
        grpResultados.Size = new Size(800, 195);
        grpResultados.TabIndex = 4;
        grpResultados.TabStop = false;
        grpResultados.Text = "3. Resultados";
        // 
        // lblCostoEtiqueta
        // 
        lblCostoEtiqueta.AutoSize = true;
        lblCostoEtiqueta.Location = new Point(14, 32);
        lblCostoEtiqueta.Name = "lblCostoEtiqueta";
        lblCostoEtiqueta.Size = new Size(142, 20);
        lblCostoEtiqueta.TabIndex = 0;
        lblCostoEtiqueta.Text = "Costo total estimado:";
        // 
        // lblCostoValor
        // 
        lblCostoValor.AutoSize = true;
        lblCostoValor.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblCostoValor.Location = new Point(258, 28);
        lblCostoValor.Name = "lblCostoValor";
        lblCostoValor.Size = new Size(160, 25);
        lblCostoValor.TabIndex = 1;
        lblCostoValor.Text = "—";
        // 
        // lblCombustibleEtiqueta
        // 
        lblCombustibleEtiqueta.AutoSize = true;
        lblCombustibleEtiqueta.Location = new Point(14, 62);
        lblCombustibleEtiqueta.Name = "lblCombustibleEtiqueta";
        lblCombustibleEtiqueta.Size = new Size(179, 20);
        lblCombustibleEtiqueta.TabIndex = 2;
        lblCombustibleEtiqueta.Text = "Combustible total requerido:";
        // 
        // lblCombustibleValor
        // 
        lblCombustibleValor.AutoSize = true;
        lblCombustibleValor.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblCombustibleValor.Location = new Point(258, 58);
        lblCombustibleValor.Name = "lblCombustibleValor";
        lblCombustibleValor.Size = new Size(160, 25);
        lblCombustibleValor.TabIndex = 3;
        lblCombustibleValor.Text = "—";
        // 
        // lblRendimientoEtiqueta
        // 
        lblRendimientoEtiqueta.AutoSize = true;
        lblRendimientoEtiqueta.Location = new Point(14, 92);
        lblRendimientoEtiqueta.Name = "lblRendimientoEtiqueta";
        lblRendimientoEtiqueta.Size = new Size(172, 20);
        lblRendimientoEtiqueta.TabIndex = 4;
        lblRendimientoEtiqueta.Text = "Rendimiento promedio del viaje:";
        // 
        // lblRendimientoValor
        // 
        lblRendimientoValor.AutoSize = true;
        lblRendimientoValor.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblRendimientoValor.Location = new Point(258, 88);
        lblRendimientoValor.Name = "lblRendimientoValor";
        lblRendimientoValor.Size = new Size(160, 25);
        lblRendimientoValor.TabIndex = 5;
        lblRendimientoValor.Text = "—";
        // 
        // lblTanqueEtiqueta
        // 
        lblTanqueEtiqueta.AutoSize = true;
        lblTanqueEtiqueta.Location = new Point(14, 122);
        lblTanqueEtiqueta.Name = "lblTanqueEtiqueta";
        lblTanqueEtiqueta.Size = new Size(132, 20);
        lblTanqueEtiqueta.TabIndex = 6;
        lblTanqueEtiqueta.Text = "Consumo del tanque:";
        // 
        // lblTanqueValor
        // 
        lblTanqueValor.AutoSize = true;
        lblTanqueValor.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTanqueValor.Location = new Point(258, 118);
        lblTanqueValor.Name = "lblTanqueValor";
        lblTanqueValor.Size = new Size(160, 25);
        lblTanqueValor.TabIndex = 7;
        lblTanqueValor.Text = "—";
        // 
        // prbTanque
        // 
        prbTanque.Location = new Point(440, 120);
        prbTanque.Name = "prbTanque";
        prbTanque.Size = new Size(330, 22);
        prbTanque.TabIndex = 8;
        // 
        // lblDetalle
        // 
        lblDetalle.AutoSize = true;
        lblDetalle.ForeColor = SystemColors.GrayText;
        lblDetalle.Location = new Point(14, 154);
        lblDetalle.Name = "lblDetalle";
        lblDetalle.Size = new Size(770, 20);
        lblDetalle.TabIndex = 9;
        lblDetalle.Text = "";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(840, 665);
        Controls.Add(grpResultados);
        Controls.Add(btnCalcular);
        Controls.Add(grpViaje);
        Controls.Add(grpVehiculo);
        Controls.Add(lblTitulo);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Calculadora de Consumo de Viajes";
        grpVehiculo.ResumeLayout(false);
        grpVehiculo.PerformLayout();
        grpViaje.ResumeLayout(false);
        grpViaje.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numDistancia).EndInit();
        ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
        ((System.ComponentModel.ISupportInitialize)numOcupantes).EndInit();
        ((System.ComponentModel.ISupportInitialize)trkCiudad).EndInit();
        grpResultados.ResumeLayout(false);
        grpResultados.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTitulo;
    private GroupBox grpVehiculo;
    private ComboBox cmbVehiculo;
    private Label lblVehiculo;
    private Button btnNuevoVehiculo;
    private Button btnEditarVehiculo;
    private Button btnEliminarVehiculo;
    private GroupBox grpViaje;
    private Label lblDistancia;
    private NumericUpDown numDistancia;
    private Label lblPrecio;
    private NumericUpDown numPrecio;
    private Label lblOcupantes;
    private NumericUpDown numOcupantes;
    private Label lblMixTitle;
    private TrackBar trkCiudad;
    private Label lblPctMix;
    private Button btnCalcular;
    private GroupBox grpResultados;
    private Label lblCostoEtiqueta;
    private Label lblCostoValor;
    private Label lblCombustibleEtiqueta;
    private Label lblCombustibleValor;
    private Label lblRendimientoEtiqueta;
    private Label lblRendimientoValor;
    private Label lblTanqueEtiqueta;
    private Label lblTanqueValor;
    private ProgressBar prbTanque;
    private Label lblDetalle;
}
