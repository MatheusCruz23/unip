using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTriangulos.Modelo
{
    public class Controle : absPropriedades
    {
        public Controle(String lado1, String lado2, String lado3)
            : base(lado1, lado2, lado3)
        {
            Verificar();
        }

        private void Verificar() 
        {
            this.Mensagem = "";
            Validacao validacao = new Validacao(this.Lado1, this.Lado2, this.Lado3);
            if (validacao.Mensagem.Equals(""))
            {
                Triangulos triangulos = new Triangulos(validacao.L1, validacao.L2, validacao.L3);
                this.Resposta = triangulos.Resposta;
            }
            else 
            {
                this.Mensagem = validacao.Mensagem;
            }
        }
    }
}
