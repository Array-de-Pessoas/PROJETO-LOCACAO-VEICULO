using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForm
{
    public partial class TelaPrincipal : Form
    {
       
        public static TelaPrincipal Instancia;

        public TelaPrincipal()
        {
            InitializeComponent();
            StatusAplicacao.Text = "Início";
            Instancia = this;
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            MudarPannel();
        }

        public void MudarPannel()
        {
            panelTelaPrincipal.Controls.Remove(ImagemInicio);
            panelTelaPrincipal.Controls.Add(new TelaPrincipalCadastros());
            btnAcessar.Visible = false;
            StatusAplicacao.Text = "                                                     Menu principal";
        }

        
    }
}
