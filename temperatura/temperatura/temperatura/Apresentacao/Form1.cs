using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Model.Controle controle;
            if (rdbCF.Checked)
            {
                controle = new Model.Controle("CF", txbTemperatura.Text);
            }
            else
            {
                controle = new Model.Controle("FC", txbTemperatura.Text);
            }
            if (controle.mensagem.Equals(""))
            {
                lblResultado.Text = controle.resposta;
            }
            else 
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
