using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

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
            this.textSegunda = new System.Windows.Forms.TextBox();
            this.textPrimera = new System.Windows.Forms.TextBox();
            this.textTercera = new System.Windows.Forms.TextBox();
            this.buttonPublicar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelGanador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textSegunda
            // 
            this.textSegunda.Location = new System.Drawing.Point(143, 185);
            this.textSegunda.Name = "textSegunda";
            this.textSegunda.Size = new System.Drawing.Size(100, 20);
            this.textSegunda.TabIndex = 11;
            // 
            // textPrimera
            // 
            this.textPrimera.Location = new System.Drawing.Point(37, 185);
            this.textPrimera.Name = "textPrimera";
            this.textPrimera.Size = new System.Drawing.Size(100, 20);
            this.textPrimera.TabIndex = 12;
            // 
            // textTercera
            // 
            this.textTercera.Location = new System.Drawing.Point(258, 185);
            this.textTercera.Name = "textTercera";
            this.textTercera.Size = new System.Drawing.Size(100, 20);
            this.textTercera.TabIndex = 13;
            // 
            // buttonPublicar
            // 
            this.buttonPublicar.Location = new System.Drawing.Point(147, 237);
            this.buttonPublicar.Name = "buttonPublicar";
            this.buttonPublicar.Size = new System.Drawing.Size(75, 23);
            this.buttonPublicar.TabIndex = 14;
            this.buttonPublicar.Text = "Publicar";
            this.buttonPublicar.UseVisualStyleBackColor = true;
            this.buttonPublicar.Click += new System.EventHandler(this.buttonPublicar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Numero del Sorteo";
            // 
            // labelGanador
            // 
            this.labelGanador.AutoSize = true;
            this.labelGanador.Location = new System.Drawing.Point(137, 368);
            this.labelGanador.Name = "labelGanador";
            this.labelGanador.Size = new System.Drawing.Size(0, 13);
            this.labelGanador.TabIndex = 22;
            // 
            // LoteTech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 468);
            this.Controls.Add(this.labelGanador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonPublicar);
            this.Controls.Add(this.textTercera);
            this.Controls.Add(this.textPrimera);
            this.Controls.Add(this.textSegunda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoteTech";
            this.Text = "LoteTech_Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textSegunda;
        private System.Windows.Forms.TextBox textPrimera;
        private System.Windows.Forms.TextBox textTercera;
        private System.Windows.Forms.Button buttonPublicar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelGanador;
    }
}

