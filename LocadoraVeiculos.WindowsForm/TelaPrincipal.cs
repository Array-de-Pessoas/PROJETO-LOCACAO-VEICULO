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
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Visible = true;
        }

        public void MudarPannel()
        {
            panelTelaPrincipal.Controls.Remove(ImagemInicio);
            panelTelaPrincipal.Controls.Add(new TelaPrincipalCadastros());
            this.Show( new TelaPrincipalCadastros());
            btnAcessar.Visible = false;
        }
    }
}
