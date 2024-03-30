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
        string operacao;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            int n = 0;
            lbResultado.Text += n.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int n = 1;
            lbResultado.Text += n.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int n = 2;
            lbResultado.Text += n.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int n = 3;
            lbResultado.Text += n.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int n = 4;
            lbResultado.Text += n.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            int n = 5;
            lbResultado.Text += n.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            int n = 6;
            lbResultado.Text += n.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            int n = 7;
            lbResultado.Text += n.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            int n = 8;
            lbResultado.Text += n.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            int n = 9;
            lbResultado.Text += n.ToString();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbn1.Text) && !string.IsNullOrEmpty(lbResultado.Text))
            {
                double n1 = double.Parse(lbn1.Text);
                double n2 = double.Parse(lbResultado.Text);
                lbResultado.Text = Operacoes.Operacao(operacao, n1, n2).ToString();
            }
            else
            {
                lbResultado.Text = "0";
            }

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            operacao = "menos";
            lbn1.Text = lbResultado.Text;
            lbResultado.Text = null;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operacao = "div";
            lbn1.Text = lbResultado.Text;
            lbResultado.Text = null;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            operacao = "mult";
            lbn1.Text = lbResultado.Text;
            lbResultado.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbn1.Text = "";
            lbResultado.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbResultado.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operacao = "porcen";
            lbn1.Text = lbResultado.Text;
            lbResultado.Text = null;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            operacao = "mais";
            lbn1.Text = lbResultado.Text;
            lbResultado.Text = null;
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            lbResultado.Text += ",";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbResultado.Text))
            {
                lbResultado.Text = lbResultado.Text.Remove(lbResultado.Text.Length - 1);
            }
        }
    }
}