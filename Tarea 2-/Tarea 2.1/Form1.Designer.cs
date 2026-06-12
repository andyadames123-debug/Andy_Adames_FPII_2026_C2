namespace Tarea_2._1
{
    partial class LoteTech
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoteTech));
            this.textPrimeraJugada = new System.Windows.Forms.TextBox();
            this.textTerceraJugada = new System.Windows.Forms.TextBox();
            this.textApuesta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_1000 = new System.Windows.Forms.Button();
            this.button_100 = new System.Windows.Forms.Button();
            this.button_10 = new System.Windows.Forms.Button();
            this.textSegunda = new System.Windows.Forms.TextBox();
            this.textPrimera = new System.Windows.Forms.TextBox();
            this.textTercera = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textSegundaJugada = new System.Windows.Forms.TextBox();
            this.buttonNuevaJugada = new System.Windows.Forms.Button();
            this.NumeroSorteo = new System.Windows.Forms.Label();
            this.textPremio = new System.Windows.Forms.TextBox();
            this.labelGanador = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textPrimeraJugada
            // 
            this.textPrimeraJugada.Location = new System.Drawing.Point(3, 139);
            this.textPrimeraJugada.Name = "textPrimeraJugada";
            this.textPrimeraJugada.Size = new System.Drawing.Size(100, 20);
            this.textPrimeraJugada.TabIndex = 1;
            // 
            // textTerceraJugada
            // 
            this.textTerceraJugada.Location = new System.Drawing.Point(3, 191);
            this.textTerceraJugada.Name = "textTerceraJugada";
            this.textTerceraJugada.Size = new System.Drawing.Size(100, 20);
            this.textTerceraJugada.TabIndex = 2;
            // 
            // textApuesta
            // 
            this.textApuesta.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.textApuesta.Location = new System.Drawing.Point(254, 139);
            this.textApuesta.Name = "textApuesta";
            this.textApuesta.Size = new System.Drawing.Size(100, 20);
            this.textApuesta.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tu jugada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apuesta";
            // 
            // button_1000
            // 
            this.button_1000.Location = new System.Drawing.Point(353, 61);
            this.button_1000.Name = "button_1000";
            this.button_1000.Size = new System.Drawing.Size(75, 23);
            this.button_1000.TabIndex = 8;
            this.button_1000.Text = "1000";
            this.button_1000.UseVisualStyleBackColor = true;
            this.button_1000.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_100
            // 
            this.button_100.Location = new System.Drawing.Point(267, 61);
            this.button_100.Name = "button_100";
            this.button_100.Size = new System.Drawing.Size(75, 23);
            this.button_100.TabIndex = 9;
            this.button_100.Text = "100";
            this.button_100.UseVisualStyleBackColor = true;
            this.button_100.Click += new System.EventHandler(this.button_100_Click);
            // 
            // button_10
            // 
            this.button_10.Location = new System.Drawing.Point(170, 61);
            this.button_10.Name = "button_10";
            this.button_10.Size = new System.Drawing.Size(75, 23);
            this.button_10.TabIndex = 10;
            this.button_10.Text = "10";
            this.button_10.UseVisualStyleBackColor = true;
            this.button_10.Click += new System.EventHandler(this.button_10_Click);
            // 
            // textSegunda
            // 
            this.textSegunda.Location = new System.Drawing.Point(162, 276);
            this.textSegunda.Name = "textSegunda";
            this.textSegunda.Size = new System.Drawing.Size(100, 20);
            this.textSegunda.TabIndex = 11;
            // 
            // textPrimera
            // 
            this.textPrimera.Location = new System.Drawing.Point(37, 276);
            this.textPrimera.Name = "textPrimera";
            this.textPrimera.Size = new System.Drawing.Size(100, 20);
            this.textPrimera.TabIndex = 12;
            // 
            // textTercera
            // 
            this.textTercera.Location = new System.Drawing.Point(284, 276);
            this.textTercera.Name = "textTercera";
            this.textTercera.Size = new System.Drawing.Size(100, 20);
            this.textTercera.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(254, 191);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Jugar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Numero del Sorteo";
            // 
            // textSegundaJugada
            // 
            this.textSegundaJugada.Location = new System.Drawing.Point(3, 165);
            this.textSegundaJugada.Name = "textSegundaJugada";
            this.textSegundaJugada.Size = new System.Drawing.Size(100, 20);
            this.textSegundaJugada.TabIndex = 16;
            // 
            // buttonNuevaJugada
            // 
            this.buttonNuevaJugada.Location = new System.Drawing.Point(140, 407);
            this.buttonNuevaJugada.Name = "buttonNuevaJugada";
            this.buttonNuevaJugada.Size = new System.Drawing.Size(138, 23);
            this.buttonNuevaJugada.TabIndex = 17;
            this.buttonNuevaJugada.Text = "Nueva Jugada";
            this.buttonNuevaJugada.UseVisualStyleBackColor = true;
            this.buttonNuevaJugada.Click += new System.EventHandler(this.button5_Click);
            // 
            // NumeroSorteo
            // 
            this.NumeroSorteo.AutoSize = true;
            this.NumeroSorteo.Location = new System.Drawing.Point(184, 349);
            this.NumeroSorteo.Name = "NumeroSorteo";
            this.NumeroSorteo.Size = new System.Drawing.Size(39, 13);
            this.NumeroSorteo.TabIndex = 21;
            this.NumeroSorteo.Text = "Premio";
            // 
            // textPremio
            // 
            this.textPremio.Location = new System.Drawing.Point(162, 365);
            this.textPremio.Name = "textPremio";
            this.textPremio.Size = new System.Drawing.Size(100, 20);
            this.textPremio.TabIndex = 18;
            // 
            // labelGanador
            // 
            this.labelGanador.AutoSize = true;
            this.labelGanador.Location = new System.Drawing.Point(137, 368);
            this.labelGanador.Name = "labelGanador";
            this.labelGanador.Size = new System.Drawing.Size(0, 13);
            this.labelGanador.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tarea_2._1.Properties.Resources.Gemini_Generated_Image_982wpm982wpm982w__1_;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // LoteTech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 468);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelGanador);
            this.Controls.Add(this.NumeroSorteo);
            this.Controls.Add(this.textPremio);
            this.Controls.Add(this.buttonNuevaJugada);
            this.Controls.Add(this.textSegundaJugada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textTercera);
            this.Controls.Add(this.textPrimera);
            this.Controls.Add(this.textSegunda);
            this.Controls.Add(this.button_10);
            this.Controls.Add(this.button_100);
            this.Controls.Add(this.button_1000);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textApuesta);
            this.Controls.Add(this.textTerceraJugada);
            this.Controls.Add(this.textPrimeraJugada);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoteTech";
            this.Text = "LoteTech";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textPrimeraJugada;
        private System.Windows.Forms.TextBox textTerceraJugada;
        private System.Windows.Forms.TextBox textApuesta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_1000;
        private System.Windows.Forms.Button button_100;
        private System.Windows.Forms.Button button_10;
        private System.Windows.Forms.TextBox textSegunda;
        private System.Windows.Forms.TextBox textPrimera;
        private System.Windows.Forms.TextBox textTercera;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textSegundaJugada;
        private System.Windows.Forms.Button buttonNuevaJugada;
        private System.Windows.Forms.Label NumeroSorteo;
        private System.Windows.Forms.TextBox textPremio;
        private System.Windows.Forms.Label labelGanador;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

