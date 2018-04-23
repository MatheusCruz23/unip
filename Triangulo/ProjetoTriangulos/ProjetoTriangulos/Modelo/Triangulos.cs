using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTriangulos.Modelo
{
    public class Triangulos : absPropriedades
    {
        public Triangulos(Double l1, Double l2, Double l3)
            : base(l1, l2, l3)
        {
            Verificar();
        }

        private void Verificar() 
        {
            if (this.L1.Equals(this.L2) && this.L2.Equals(this.L3))
            {
                this.Resposta = "Triângulo equilátero";
            }
            else 
            {
                if (!this.L1.Equals(this.L2) &&
                    !this.L1.Equals(this.L3) &&
                    !this.L2.Equals(this.L3))
                {
                    this.Resposta = "Triângulo escaleno";
                }
                else 
                {
                    this.Resposta = "Triângulo isosceles";
                }
            }
        }
    }
}
