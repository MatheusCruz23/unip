using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTriangulos.Modelo
{
    public class absPropriedades
    {
        private Double l1;
        private Double l2;
        private Double l3;
        private String lado1;
        private String lado2;
        private String lado3;
        private String mensagem;
        private String resposta;

        public absPropriedades(Double l1, Double l2, Double l3) 
        {
            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
        }

        public absPropriedades(String lado1, String lado2, String lado3) 
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public String Resposta
        {
            get { return resposta; }
            set { resposta = value; }
        }

        public String Mensagem
        {
            get { return mensagem; }
            set { mensagem = value; }
        }

        public String Lado3
        {
            get { return lado3; }
            set { lado3 = value; }
        }

        public String Lado2
        {
            get { return lado2; }
            set { lado2 = value; }
        }

        public String Lado1
        {
            get { return lado1; }
            set { lado1 = value; }
        }

        public Double L3
        {
            get { return l3; }
            set { l3 = value; }
        }

        public Double L2
        {
            get { return l2; }
            set { l2 = value; }
        }

        public Double L1
        {
            get { return l1; }
            set { l1 = value; }
        }
    }
}
