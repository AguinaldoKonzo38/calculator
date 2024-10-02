using System;

namespace Calculadora_Akak
{
    public partial class Form1 : Form
    {
        public decimal resultado { get; set; }
        public decimal valor { get; set; }

        private operacoes operacao_selecionada {  get; set; }
    
        private enum operacoes{
            Adicao,
            Subtracao,
            Divisao,
            Multiplicacao

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butnZero_Click(object sender, EventArgs e)
        {
            txtREsultado.Text += "0";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtREsultado.Text += "3";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtREsultado.Text += "2";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtREsultado.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtREsultado.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtREsultado.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtREsultado.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtREsultado.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtREsultado.Text += "9";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtREsultado.Text += "1";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if(!txtREsultado.Text.Contains("."))
                txtREsultado.Text += ".";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (operacao_selecionada)
            {
                case operacoes.Adicao:
                    resultado = valor + Convert.ToDecimal(txtREsultado.Text);
                    break;
                case operacoes.Subtracao:
                    resultado = valor - Convert.ToDecimal(txtREsultado.Text);
                    break;
                case operacoes.Multiplicacao:
                    resultado = valor * Convert.ToDecimal(txtREsultado.Text);
                    break;
                case operacoes.Divisao:
                    resultado = valor / Convert.ToDecimal(txtREsultado.Text);
                    break;
            }
            txtREsultado.Text = Convert.ToString(resultado);
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            operacao_selecionada = operacoes.Adicao;
            valor = Convert.ToDecimal(txtREsultado.Text);
            txtREsultado.Text = "";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            operacao_selecionada = operacoes.Multiplicacao;
            valor = Convert.ToDecimal(txtREsultado.Text);
            txtREsultado.Text = "";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            operacao_selecionada = operacoes.Divisao;
            valor = Convert.ToDecimal(txtREsultado.Text);
            txtREsultado.Text = "";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            operacao_selecionada = operacoes.Subtracao;
            valor = Convert.ToDecimal(txtREsultado.Text);
            txtREsultado.Text = "";
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtREsultado.Text = "";
        }

        private void txtREsultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
