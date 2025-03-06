using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void AtribuirOperador(string operador)
        {
            lblOper.Text = operador;
            btIgual.Enabled = true;
        }
        private void btSoma_Click(object sender, EventArgs e)
        {
            AtribuirOperador(btSoma.Text);
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            AtribuirOperador(btSub.Text);
        }

        private void btMult_Click(object sender, EventArgs e)
        {
            AtribuirOperador(btMult.Text);
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            AtribuirOperador(btDiv.Text);
            TravarBotao();
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado = 0;
            num1 = (double)numOper1.Value;
            num2 = (double)numOper2.Value;

            if (lblOper.Text == btSoma.Text)
                resultado = num1 + num2;
            else if (lblOper.Text == btSub.Text)
                resultado = num1 - num2;
            else if (lblOper.Text == btMult.Text)
                resultado = num1 * num2;
            else resultado = num1 / num2;

            lblResultado.Text = resultado.ToString();

            btSeguir.Enabled  = true;
        }

        void TravarBotao()
        {
            if ((lblOper.Text == btDiv.Text && numOper2.Value == 0)
                || lblOper.Text == "...")
                btIgual.Enabled = false;
            else
                btIgual.Enabled = true;
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            TravarBotao();
        }

        private void Form1_Load(object sender, EventArgs e) //evento q executa o código logo após o forms ser compilado
        {
            btSeguir.Enabled = false; //desabilita o botao seguir qnd inicia a calculadora
            btLimpar.Enabled = false; //desabilita o botao limpar qnd inicia a calculadora
        }
        private void btSeguir_Click(object sender, EventArgs e)
        {
            // Verificar se a label de resultado tem um valor válido
            if (double.TryParse(lblResultado.Text, out double resultado))
            {
                numOper1.Value = (decimal)resultado;
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            numOper1.Value = 0;
            numOper2.Value = 0;

            lblResultado.Text = "";

            // Limpar o operador
            lblOper.Text = "";  // Nenhum operador selecionado

            btSeguir.Enabled = false;

            btIgual.Enabled = false;
        }
    }
}

// perguntar sobre "Travar Botao" e sobre a divisão por 0 ainda ocorrer