using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_2._1
{
    public partial class LoteTech : Form
    {
        public LoteTech()
        {
            InitializeComponent();
            string logoPath = Path.Combine(Application.StartupPath, "logo.png");
            if (File.Exists(logoPath))
            {
                pictureBox1.Image = new Bitmap(logoPath);
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textApuesta.Text = "1000";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textSegundaJugada.Text = "";
            textPrimeraJugada.Text = "";
            textTerceraJugada.Text = "";
            textApuesta.Text = "";
            textSegunda.Text = "";
            textPrimera.Text = "";
            textTercera.Text = "";
            textPremio.Text = "";
            textPremio.Visible = false;
            labelGanador.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textApuesta.Text) ||
    string.IsNullOrWhiteSpace(textPrimeraJugada.Text))
            {
                MessageBox.Show("Complete los campos de las jugadas y la apuesta.");
                return;
            }

            int Jugada1 = Convert.ToInt32(textPrimeraJugada.Text);
            int Jugada2 = string.IsNullOrWhiteSpace(textSegundaJugada.Text) ? -1 : Convert.ToInt32(textSegundaJugada.Text);
            int Jugada3 = string.IsNullOrWhiteSpace(textTerceraJugada.Text) ? -1 : Convert.ToInt32(textTerceraJugada.Text);

            if (Jugada1 < 0 || Jugada1 > 99 ||
                (Jugada2 != -1 && (Jugada2 < 0 || Jugada2 > 99)) ||
                (Jugada3 != -1 && (Jugada3 < 0 || Jugada3 > 99)))
            {
                MessageBox.Show("Los números deben estar entre 0 y 99.");
                return;
            }
            textPrimera.Text = "12";
            Random GeneradorNumeros = new Random();
            int Numero1 = GeneradorNumeros.Next(0, 99);
            int Numero2 = GeneradorNumeros.Next(0, 99);
            int Numero3 = GeneradorNumeros.Next(0, 99);

            textPrimera.Text = Numero1.ToString();
            textSegunda.Text = Numero2.ToString();
            textTercera.Text = Numero3.ToString();

            double Apuesta = Convert.ToDouble(textApuesta.Text);

            bool gano = false;
            double TotalPremio = 0;

            if (Jugada1 == Numero1)
            {
                TotalPremio += Apuesta * 1000;
                gano = true;
            }
            if (Jugada2 == Numero2)
            {
                TotalPremio += Apuesta * 100;
                gano = true;
            }
            if (Jugada3 == Numero3)
            {
                TotalPremio += Apuesta * 10;
                gano = true;
            }
            if (gano)
            {
                textPremio.Text = "RD$ " + TotalPremio.ToString();
                labelGanador.Text = "¡Ganaste!";
                labelGanador.ForeColor = Color.Green;
                textPremio.Visible = true;
            }
            else
            {
                labelGanador.Text = "No ganaste. Intenta de nuevo.";
                labelGanador.ForeColor = Color.Red;
                textPremio.Visible = false;
            }
        }

        private void button_100_Click(object sender, EventArgs e)
        {
            textApuesta.Text = "100";
        }

        private void button_10_Click(object sender, EventArgs e)
        {
            textApuesta.Text = "10";
        }


    }
}
