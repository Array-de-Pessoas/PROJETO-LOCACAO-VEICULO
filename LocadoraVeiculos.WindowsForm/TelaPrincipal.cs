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
        private ICadastravel operacoes;

        public static TelaPrincipal Instancia;

        public TelaPrincipal()
        {
            InitializeComponent();

            Instancia = this;
        }

        public void AtualizarRodape(string mensagem)
        {
            StatusAplicacao.Text = mensagem;
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
        }

        
    }
}
