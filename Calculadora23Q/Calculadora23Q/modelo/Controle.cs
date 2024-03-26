using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora23Q.modelo
{
    public class Controle
    {
        private string num1;
        private string num2;
        private string op;

        private string resultado;
        private string mensagem;

        public string Resultado { get => resultado;}
        public string Mensagem { get => mensagem;}

        public Controle(string num1, string num2, string op)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.op = op;
            this.Executar();
        }

        private void Executar()
        {
            this.mensagem = "";
            Validacao validacao = new Validacao(this.num1, this.num2, this.op);
            if (validacao.Mensagem.Equals(""))
            {
                Calculos calculos = new Calculos(validacao.N1, validacao.N2, this.op);
                this.resultado = calculos.Resposta.ToString();
            }
            else
            {
                this.mensagem = validacao.Mensagem;
            }
        }
    }
}
