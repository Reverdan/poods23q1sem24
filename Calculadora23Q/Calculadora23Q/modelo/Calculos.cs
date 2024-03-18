using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora23Q.modelo
{
    public class Calculos
    {
        public int n1;
        public int n2;
        public string op;
        public int resultado;

        public void Calcular()
        {
            if (this.op.Equals("+"))
                resultado = n1 + n2;
            if (this.op.Equals("-"))
                resultado = n1 - n2;
            if (this.op.Equals("*"))
                resultado = n1 * n2;
            if (this.op.Equals("/"))
                resultado = n1 / n2;
        }
    }
}
