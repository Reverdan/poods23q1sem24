using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora23Q.modelo
{
    public class Validacao
    {
        public string num1;
        public string num2;
        public int n1;
        public int n2;
        public string mensagem;
        public string op;

        public void validar()
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
