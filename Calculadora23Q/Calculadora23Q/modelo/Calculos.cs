using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora23Q.modelo
{
    public class Calculos
    {
        private int n1;
        private int n2;
        private string op;

        private int resposta;

        public Calculos(int n1, int n2, string op)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.op = op;
            this.Calcular();
        }

        public int Resposta
        {
            get { return resposta; }
        }

        public void Calcular()
        {
            if (op.Equals("+"))
                resposta = n1 + n2;
            if (op.Equals("-"))
                resposta = n1 - n2;
            if (op.Equals("*"))
                resposta = n1 * n2;
            if (op.Equals("/"))
                resposta = n1 / n2;
        }
    }


}
