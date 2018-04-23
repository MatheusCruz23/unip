using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTriangulos.Modelo
{
    public class Validacao : absPropriedades
    {
        public Validacao(String lado1, String lado2, String lado3) 
            : base(lado1, lado2, lado3)
        {
            Validar();
        }

        private void Validar() 
        {
            this.Mensagem = "";
            try
            {
                this.L1 = Convert.ToDouble(Lado1);
            }
            catch (FormatException e)
            {
                this.Mensagem += "Erro de conversão do lado 1 \n";
            }

            try
            {
                this.L2 = Convert.ToDouble(Lado2);
            }
            catch (FormatException e)
            {
                this.Mensagem += "Erro de conversão do lado 2 \n";
            }

            try
            {
                this.L3 = Convert.ToDouble(Lado3);
            }
            catch (FormatException e)
            {
                this.Mensagem += "Erro de conversão do lado 3 \n";
            }

            if (this.Mensagem.Equals("")) 
            {
                if(this.L1 + this.L2 <= this.L3 ||
                    this.L1 + this.L3 <= this.L2 ||
                    this.L2 + this.L3 <= this.L3)
                {
                    this.Mensagem += "Não é triângulo \n";
                }       
            }
        }
    }
}
