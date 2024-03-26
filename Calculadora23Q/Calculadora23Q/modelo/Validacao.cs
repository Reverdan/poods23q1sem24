using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora23Q.modelo
{
    public class Validacao
    {
        private string num1;
        private string num2;
        private string op;

        private int n1;
        private int n2;
        private string mensagem;

        public int N1 { get => n1;}
        public int N2 { get => n2;}
        public string Mensagem { get => mensagem;}

        public Validacao(string num1, string num2, string op)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.op = op;
            this.Validar();
        }

        private void Validar()
        {
            this.mensagem = "";
            try
            {
                this.n1 = Convert.ToInt32(this.num1);
                this.n2 = Convert.ToInt32(this.num2);
                if (this.op.Equals("/") && this.n2.Equals(0))
                    this.mensagem = "Divisão por 0";
            }
            catch (Exception erro)
            {
                this.mensagem = "Digite valores corretos";
            }
        }
    }
}
