using Calculadora23Q.modelo;

namespace Calculadora23Q
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.num1 = txbPrimeiroNumero.Text;
            controle.num2 = txbSegundoNumero.Text;
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


    }
}