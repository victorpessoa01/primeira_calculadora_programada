using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FormCal : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string opera = "";
        public FormCal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxTela.Text += "1";
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            textBoxTela.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxTela.Text += "6";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonzero_Click(object sender, EventArgs e)
        {
           textBoxTela.Text += "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxTela.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxTela.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxTela.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxTela.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxTela.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxTela.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxTela.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxTela.Text += ".";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textBoxTela.Text, CultureInfo.InvariantCulture);

            labelOpera.Text = "=";

            if (opera == "SOMA")
            {
                textBoxTela.Text = Convert.ToString(valor1 + valor2);
            }

            else if (opera == "SUBT")
            {
                textBoxTela.Text = Convert.ToString(valor1 - valor2);
            }

           else if (opera == "MULT")
            {
                textBoxTela.Text = Convert.ToString(valor1 * valor2);
            }

           else if (opera == "DIVI")
            {
                textBoxTela.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBoxTela.Text, CultureInfo.InvariantCulture);
            textBoxTela.Text = "";
            opera = "SOMA";
            labelOpera.Text = "+";
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBoxTela.Text, CultureInfo.InvariantCulture);
            textBoxTela.Text = "";
            opera = "SUBT";
            labelOpera.Text = "-";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBoxTela.Text, CultureInfo.InvariantCulture);
            textBoxTela.Text = "";
            opera = "MULT";
            labelOpera.Text = "X";
        }

        private void buttonDivi_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBoxTela.Text, CultureInfo.InvariantCulture);
            textBoxTela.Text = "";
            opera = "DIVI";
            labelOpera.Text = "/";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBoxTela.Text = "";
            valor1 = 0;
            valor2 = 0;
            labelOpera.Text = "";

        }
    }
}
