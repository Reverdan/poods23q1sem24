﻿using System;
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
        public string op;

        public void Executar()
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.num1 = this.num1;
            validacao.num2 = this.num2;
            validacao.op = this.op;
            validacao.validar();
            if (validacao.mensagem.Equals(""))
            {
                Calculos calculos = new Calculos();
                this.resposta = 
                    calculos.Calcular(validacao.n1, validacao.n2, this.op).ToString();
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
    }
}
