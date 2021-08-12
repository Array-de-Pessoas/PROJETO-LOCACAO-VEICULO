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
    public partial class TelaPrincipalCadastros : UserControl
    {
        public TelaPrincipalCadastros()
        {
            InitializeComponent();
            ConfiguracoesDeInicio();
        }

        private void ConfiguracoesDeInicio()
        {
            btnAdicionar.Visible = false;
            btnEditar.Visible = false;
            btnExcluir.Visible = false;
            btnFiltro.Visible = false;
            ImagemLinha.Visible = false;
            ImagemLinha2.Visible = false;
        }

        public void MostrarOpcoes()
        {
            btnAdicionar.Visible = true;
            btnEditar.Visible = true;
            btnExcluir.Visible = true;
            btnFiltro.Visible = true;
            ImagemLinha.Visible = true;
            ImagemLinha2.Visible = true;
        }

        private void OpcaoCadastroFuncionarios_Click(object sender, EventArgs e)
        {
            MostrarOpcoes();
        }

        private void OpcaoCadastroClientes_Click(object sender, EventArgs e)
        {
            MostrarOpcoes();
        }

        private void OpcaoCadastroVeiculos_Click(object sender, EventArgs e)
        {
            MostrarOpcoes();
        }

        private void OpcaoCadastroServicos_Click(object sender, EventArgs e)
        {
            MostrarOpcoes();
        }
    }
}
