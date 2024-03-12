using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora23Q.modelo
{
    public class Controle
    {
        public string num1;
        public string num2;
        public string resposta;
        public string mensagem;

        public void executar()
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.num1 = this.num1;
            validacao.num2 = this.num2;
            validacao.validar();
            if (validacao.mensagem.Equals(""))
            {
                Calculos calculos = new Calculos();
                calculos.n1 = validacao.n1;
                calculos.n2 = validacao.n2;
                calculos.somar();
                this.resposta = calculos.resultado.ToString();
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
    }
}
