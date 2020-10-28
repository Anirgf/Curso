using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoModulo6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Double numero1;
        private Double numero2;
        private String operacao;

        private Boolean PressionouIgual;

        private void Form1_Load(object sender, EventArgs e)
        {
            LimparCampo();
        }

        private void LimparCampo()
        {
            txtDisplay.Clear();
            numero1 = 0;
            numero2 = 0;
            operacao = string.Empty;
            PressionouIgual = false;
        }

        private void AdicionarCaracterNumerico(String caracter)
        {
            if(PressionouIgual == true)
            {
                txtDisplay.Clear();
                PressionouIgual = false;
            }
            if (txtDisplay.Text.Trim().Equals("0"))
            {
                txtDisplay.Text = caracter;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + caracter;
            }
        }

        private void AdicionarCaracterOperacao(String caracter)
        {
            if (!txtDisplay.Text.Trim().Equals(String.Empty))
            {
                if (txtDisplay.Text.Trim().Contains("."))
                {
                    numero1 = Convert.ToDouble(txtDisplay.Text.Trim().Replace(".", ","));
                }
                else
                {
                    numero1 = Convert.ToDouble(txtDisplay.Text.Trim());
                }
                operacao = caracter;
                txtDisplay.Clear();
            }
        }

        private void Calcular()
        {
            switch (operacao)
            {
                case "/":
                    if(numero2 == 0)
                    {
                        MessageBox.Show("Divisão por zero!");
                        break;
                    }
                    txtDisplay.Text = (numero1 / numero2).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (numero1 * numero2).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (numero1 - numero2).ToString();
                    break;
                case "+":
                    txtDisplay.Text = (numero1 + numero2).ToString();
                    break;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Equals("0"))
            {
                txtDisplay.Text = txtDisplay.Text + "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AdicionarCaracterNumerico ("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AdicionarCaracterNumerico("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AdicionarCaracterNumerico("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AdicionarCaracterNumerico("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AdicionarCaracterNumerico("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AdicionarCaracterNumerico("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AdicionarCaracterNumerico("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AdicionarCaracterNumerico("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AdicionarCaracterNumerico("9");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            AdicionarCaracterOperacao("/");
        }

        private void btnMutiplicacao_Click(object sender, EventArgs e)
        {
            AdicionarCaracterOperacao("*");
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            AdicionarCaracterOperacao("-");
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            AdicionarCaracterOperacao("+");
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Equals(String.Empty))
            {
                numero2 = Convert.ToDouble(txtDisplay.Text.Trim());
                Calcular();
                PressionouIgual = true;
            }
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Trim().Equals(String.Empty)) txtDisplay.Text = "0.";
            if (txtDisplay.Text.Trim().Contains(".")) return;
            txtDisplay.Text = txtDisplay.Text + ".";
            
        }
    }
}
