﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace temperatura.Model
{
    public class Validacao:absPropriedades, intMetodos
    {
        public Validacao(String temp) : base(temp)
        {
            Executar();
        }

        public void Executar()
        {
            this.mensagem = "";
            try
            {
                this.temperatura = Convert.ToDouble(this.temp);
            }
            catch (FormatException e)
            {
                this.mensagem = "Erro de conversão";                
            }
        }
    }
}
