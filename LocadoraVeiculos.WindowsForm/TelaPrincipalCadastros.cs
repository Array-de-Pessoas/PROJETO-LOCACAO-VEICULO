using LocadoraVeiculos.Controladores.GrupoVeiculosModule;
using LocadoraVeiculos.WindowsForm.Feature.LoginModule;
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
            TxtCadastroSelecionado.Text = "";
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
            TxtCadastroSelecionado.Text = "       FUNCIONÁRIOS";
            MostrarOpcoes();
            ImagemChave.Visible = false;
            // Implementação da Carol
        }

        private void OpcaoCadastroClientes_Click(object sender, EventArgs e)
        {
            if(UsuarioParaValidacao.MudarConta == null)
            {
                MessageBox.Show("Entre com uma conta válida para fazer o cadastro!");
                return;
            }
            MostrarOpcoes();
            TxtCadastroSelecionado.Text = "           CLIENTES";
            panelTabelas.Controls.Clear();
        }

        private void OpcaoCadastroVeiculos_Click(object sender, EventArgs e)
        {
            if (UsuarioParaValidacao.MudarConta == null)
            {
                MessageBox.Show("Entre com uma conta válida para fazer o cadastro!");
                return;
            }
            panelTabelas.Controls.Clear();
            TxtCadastroSelecionado.Text = "           VEÍCULOS";
            MostrarOpcoes();
            ImagemChave.Visible = false;
            // implementação do João
        }

        private void OpcaoCadastroServicos_Click(object sender, EventArgs e)
        {
            if (UsuarioParaValidacao.MudarConta == null)
            {
                MessageBox.Show("Entre com uma conta válida para fazer o cadastro!");
                return;
            }
            panelTabelas.Controls.Clear();
            MostrarOpcoes();
            TxtCadastroSelecionado.Text = "           SERVIÇOS";
            
        }

        private void btnVizualizarConta_Click(object sender, EventArgs e)
        {
            if (panelTelaContaRegistradas.Controls.Count == 0)
            {
                panelTelaContaRegistradas.Controls.Add(new MostrarConta());
                return;
            }
            if (panelTelaContaRegistradas.Controls.Count == 1)
            {
                panelTelaContaRegistradas.Controls.Clear();
                return;
            }
        }

        private void gRUPODEVEÍCULOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UsuarioParaValidacao.MudarConta == null)
            {
                MessageBox.Show("Entre com uma conta válida para fazer o cadastro!");
                return;
            }
            TxtCadastroSelecionado.Text = " GRUPO DE VEÍCULOS";
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
            if (UsuarioParaValidacao.MudarConta == null)
            {
                MessageBox.Show("Entre com uma conta válida para fazer o cadastro!");
                return;
            }
            if (TxtCadastroSelecionado.Text == " GRUPO DE VEÍCULOS")
            {
                operacoes.EditarRegistro();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (UsuarioParaValidacao.MudarConta == null)
            {
                MessageBox.Show("Entre com uma conta válida para fazer o cadastro!");
                return;
            }
            if (TxtCadastroSelecionado.Text == " GRUPO DE VEÍCULOS")
            {
                operacoes.ExcluirRegistro();
            }
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
            if (UsuarioParaValidacao.MudarConta == null)
            {
                MessageBox.Show("Entre com uma conta válida para fazer o cadastro!");
                return;
            }
        }
    }
}
