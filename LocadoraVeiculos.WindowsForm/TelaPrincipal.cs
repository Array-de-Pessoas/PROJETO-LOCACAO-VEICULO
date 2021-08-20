using LocadoraVeiculos.WindowsForm.Features.FuncionarioModule;
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

        public void AtualizarRodape(string mensagem)
        {
            StatusAplicacao.Text = mensagem;
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            MudarPannel();
            Text = "Locadora Veículos";
        }

        public void MudarPannel()
        {
            panelTelaPrincipal.Controls.Remove(ImagemInicio);
            panelTelaPrincipal.Controls.Add(new TelaPrincipalCadastros());
            btnAcessar.Visible = false;
            StatusAplicacao.Text = "                                                     Menu principal";
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção em desenvolvimento");
        }
    }
}
