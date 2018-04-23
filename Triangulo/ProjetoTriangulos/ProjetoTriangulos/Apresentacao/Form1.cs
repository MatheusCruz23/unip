using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTriangulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click_Click(object sender, EventArgs e)
        {
            Modelo.Controle controle = new Modelo.Controle(txtPrimeiroLado.Text, txtSegundoLado.Text, txtTerceiroLado.Text);
            if (controle.Mensagem.Equals(""))
            {
                lblResposta.Text = controle.Resposta;
            }
            else 
            {
                MessageBox.Show(controle.Mensagem);
            }
        }
    }
}
