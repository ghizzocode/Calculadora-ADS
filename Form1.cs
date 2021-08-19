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
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.valor1 =  decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            this.operacao = "SOM";
            button4.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            this.button5.Enabled = false;
            if (operacao == "SOM")
            {
                decimal soma = (this.valor1 + this.valor2);
                txtResultado.Text = Convert.ToString(soma);
                button4.Enabled = true;
            } else if (operacao == "SUB")
            {
                decimal sub = (this.valor1 - this.valor2);
                txtResultado.Text = Convert.ToString(sub);
                button7.Enabled = true;
            } else if (operacao == "MUL")
            {
                decimal mul = (this.valor1 * this.valor2);
                txtResultado.Text = Convert.ToString(mul);
                button12.Enabled = true;
            } else if (operacao == "DIV")
            {
                decimal div = (this.valor1 / this.valor2);
                txtResultado.Text = Convert.ToString(div);
                button17.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            this.operacao = "SUB";
            button7.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            this.operacao = "MUL";
            button12.Enabled = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            this.operacao = "DIV";
            button17.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            this.valor1 = 0;
            this.valor2 = 0;
            if (operacao == "SOM")
            {
                button4.Enabled = true;
            }
            else if (operacao == "SUB")
            {
                button7.Enabled = true;
            }
            else if (operacao == "MUL")
            {
                button12.Enabled = true;
            }
            else if (operacao == "DIV")
            {
                button17.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }
    }
}
