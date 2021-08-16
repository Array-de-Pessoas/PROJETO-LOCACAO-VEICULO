using LocadoraVeiculos.Controladores.GrupoVeiculosModule;
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
            ConfiguracoesDeInicio();
            Instancia = this;
        }

        private void ConfiguracoesDeInicio()
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
            TxtCadastroSelecionado.Text = "FUNCIONÁRIOS";
            MostrarOpcoes();
        }

        private void OpcaoCadastroClientes_Click(object sender, EventArgs e)
        {
            MostrarOpcoes();
            TxtCadastroSelecionado.Text = "CLIENTES";
        }

        private void OpcaoCadastroVeiculos_Click(object sender, EventArgs e)
        {
            MostrarOpcoes();
            
        }

        private void OpcaoCadastroServicos_Click(object sender, EventArgs e)
        {
            MostrarOpcoes();
            TxtCadastroSelecionado.Text = "SERVIÇOS";
        }

        private void btnVizualizarConta_Click(object sender, EventArgs e)
        {
            panelTelaContaRegistradas.Controls.Add(new MostrarConta());
        }

        private void gRUPODEVEÍCULOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtCadastroSelecionado.Text = "GRUPO DE VEÍCULOS";
           
            MostrarOpcoes();
            ImagemChave.Visible = false;
            operacoes = new OperacoesGrupoVeiculos(new ControladorGrupoVeiculos());
            ConfigurarPanelRegistros();
           
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (TxtCadastroSelecionado.Text == "GRUPO DE VEÍCULOS")
            {
                operacoes.InserirNovoRegistro();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (TxtCadastroSelecionado.Text == "GRUPO DE VEÍCULOS")
            {
                operacoes.EditarRegistro();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (TxtCadastroSelecionado.Text == "GRUPO DE VEÍCULOS")
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
    }
}
