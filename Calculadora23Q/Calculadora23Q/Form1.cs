using Calculadora23Q.modelo;

namespace Calculadora23Q
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Calcular(String op)
        {
            Controle controle = new Controle(txbPrimeiroNumero.Text, txbSegundoNumero.Text, op);
            if (controle.Mensagem.Equals(""))
            {
                lblResposta.Text = controle.Resultado;
            }
            else
            {
                lblResposta.Text = controle.Mensagem;
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            this.Calcular("+");
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            this.Calcular("-");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            this.Calcular("*");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            this.Calcular("/");
        }
    }
}