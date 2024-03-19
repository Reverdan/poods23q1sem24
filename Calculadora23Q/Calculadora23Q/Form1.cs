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
            Controle controle = new Controle();
            controle.num1 = txbPrimeiroNumero.Text;
            controle.num2 = txbSegundoNumero.Text;
            controle.op = op;
            controle.Executar();
            if (controle.mensagem.Equals(""))
            {
                lblResposta.Text = controle.resposta;
            }
            else
            {
                lblResposta.Text = controle.mensagem;
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