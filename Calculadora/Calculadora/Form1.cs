using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private const int V = 4;
        private double valor1;
        private double valor2;

        private double resultado;

        private int operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(textBox1.Text);

            switch (operacion)
            {
                case 1: // Suma
                    resultado = valor1 + valor2;
                    break;
                case 2: // Resta
                    resultado = valor1 - valor2;
                    break;
                case 3: // Multiplicación
                    resultado = valor1 * valor2;
                    break;
                case 4: // División
                    if (valor2 != 0)
                    {
                        resultado = valor1 / valor2;
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir por cero.");
                        return;
                    }
                    break;
                default:
                    MessageBox.Show("Operación no válida.");
                    return;
            }


            textBox1.Text = resultado.ToString();
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            operacion = 1;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            operacion = 2;
            valor1  = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            operacion = 3;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            operacion = 4;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }
    }
}
