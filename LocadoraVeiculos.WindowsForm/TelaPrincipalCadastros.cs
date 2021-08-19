using LocadoraVeiculos.Controladores.FuncionarioModule;
using LocadoraVeiculos.Controladores.GrupoVeiculosModule;
using LocadoraVeiculos.WindowsForm.Features.FuncionarioModule;
using LocadoraVeiculos.WindowsForm.Features.GrupoVeiculosModule;
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
        private ICadastravel operacoes;

        public static TelaPrincipalCadastros Instancia;

        public TelaPrincipalCadastros()
        {
            InitializeComponent();
            Instancia = this;
            ConfiguracoesDeInicio();

        }

        public void ConfiguracoesDeInicio()
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

        public void OpcaoCadastroFuncionarios_Click(object sender, EventArgs e)
        {
            panelTabelas.Controls.Clear();
            MostrarOpcoes();
            ImagemChave.Visible = false;
            operacoes = new OperacoesFuncionario(new ControladorFuncionario());
            ConfigurarPanelRegistros();
            btnFiltro.Visible = false;
        }

        private void OpcaoCadastroClientes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entre com uma conta válida para fazer o cadastro!");
            return;
        }

        private void OpcaoCadastroVeiculos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entre com uma conta válida para fazer o cadastro!");
            return;
            // implementação do João
        }

        private void OpcaoCadastroServicos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entre com uma conta válida para fazer o cadastro!");
            return;

        }

        private void btnVizualizarConta_Click(object sender, EventArgs e)
        {
        }

        private void gRUPODEVEÍCULOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarOpcoes();
            ImagemChave.Visible = false;
            operacoes = new OperacoesGrupoVeiculos(new ControladorGrupoVeiculos());
            ConfigurarPanelRegistros();
            btnFiltro.Visible = false;

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            operacoes.InserirNovoRegistro();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            operacoes.EditarRegistro();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            operacoes.ExcluirRegistro();
        }

        private void ConfigurarPanelRegistros()
        {
            UserControl tabela = operacoes.ObterTabela();

            tabela.Dock = DockStyle.Fill;

            panelTabelas.Controls.Clear();

            panelTabelas.Controls.Add(tabela);
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entre com uma conta válida para fazer o cadastro!");
            return;
        }
    }
}
