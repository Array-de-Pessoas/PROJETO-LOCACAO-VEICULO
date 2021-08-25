using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForm.Features.LoginModule
{
    public partial class TelaMudarImagem : Form
    {
        public TelaMudarImagem()
        {
            InitializeComponent();
            
        }

        private void btnImagem1_Click(object sender, EventArgs e)
        {
            MudarImagem.mudarImagem = "Imagem3";
        }

        private void btnImagem2_Click(object sender, EventArgs e)
        {
            MudarImagem.mudarImagem = "Imagem2";
        }

        private void btnImagem3_Click(object sender, EventArgs e)
        {
            MudarImagem.mudarImagem = "Imagem1";
        }

        private void btnImagem4_Click(object sender, EventArgs e)
        {
            MudarImagem.mudarImagem = "Imagem6";
        }

        private void btnImagem5_Click(object sender, EventArgs e)
        {
            MudarImagem.mudarImagem = "Imagem5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
