using LocadoraLocacaos.WindowsForm.Features.LocacaoModule;
using LocadoraVeiculos.Controladores.ClienteModule;
using LocadoraVeiculos.Controladores.CombustivelModule;
using LocadoraVeiculos.Controladores.FuncionarioModule;
using LocadoraVeiculos.Controladores.GrupoVeiculosModule;
using LocadoraVeiculos.Controladores.LocacaoModule;
using LocadoraVeiculos.Controladores.SegurosModule;
using LocadoraVeiculos.Controladores.TaxasServicosModule;
using LocadoraVeiculos.Controladores.VeiculoModule;
using LocadoraVeiculos.WindowsForm.Features.ClienteModule;
using LocadoraVeiculos.WindowsForm.Features.CombustivelModule;
using LocadoraVeiculos.WindowsForm.Features.Dashboard;
using LocadoraVeiculos.WindowsForm.Features.FuncionarioModule;
using LocadoraVeiculos.WindowsForm.Features.GrupoVeiculosModule;
using LocadoraVeiculos.WindowsForm.Features.LoginModule;
using LocadoraVeiculos.WindowsForm.Features.SeguroModule;
using LocadoraVeiculos.WindowsForm.Features.TaxasServicosModule;
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
        private OperacoesLogin login;
        public static TelaPrincipalCadastros Instancia;
        Dashboard dashboard = new Dashboard();
        TabelaCarrosAlugados tabelaCarrosAlugados = new TabelaCarrosAlugados();
        TabelaCarrosDisponiveis tabelaCarrosDisponiveis = new TabelaCarrosDisponiveis();
        TabelaLocacoesPendentes tabelaLocacoes = new TabelaLocacoesPendentes();

        public TelaPrincipalCadastros()
        {
            InitializeComponent();
            Instancia = this;
            ConfiguracoesDeInicio();
            login = new OperacoesLogin();
            panelTelaContaRegistradas.Visible = false;
        }

        public void ConfiguracoesDeInicio()
        {
            btnCarrosAlugados.Visible = false;
            btnCarrosDisponiveis.Visible = false;
            btnLocacoesPendentes.Visible = false;
            txtV1.Visible = false;
            txtV2.Visible = false;
            txtV3.Visible = false;
            btnAdicionar.Visible = false;
            btnEditar.Visible = false;
            btnExcluir.Visible = false;
            btnFiltro.Visible = false;
            ImagemLinha.Visible = false;
            ImagemLinha2.Visible = false;
            TxtCadastroSelecionado.Text = "";
            if (panelTabelas.Controls.Count >= 1)
            {
                panelTabelas.Controls.Clear();
                ImagemChave.Visible = true;
                panelTabelas.Controls.Add(ImagemChave);
            }
            if (panelTabelas.Controls.Count == 0)
            {
                panelTabelas.Controls.Clear();
                ImagemChave.Visible = true;
                panelTabelas.Controls.Add(ImagemChave);
            }
        }

        public void ConfiguracaoMenu(bool valor)
        {
            OpcaoCadastroFuncionarios.Enabled = valor;
            OpcaoCadastroClientes.Enabled = valor;
            OpcaoCadastroServicos.Enabled = valor;
            OpcaoCadastroVeiculos.Enabled = valor;
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
            TxtCadastroSelecionado.Visible = true;
            TxtCadastroSelecionado.Text = "       FUNCIONÁRIO";
            panelTabelas.Controls.Clear();
            MostrarOpcoes();
            ImagemChave.Visible = false;
            operacoes = new OperacoesFuncionario(new ControladorFuncionario());
            ConfigurarPanelRegistros();
            btnFiltro.Visible = false;
        }

        private void OpcaoCadastroClientes_Click(object sender, EventArgs e)
        {
            TxtCadastroSelecionado.Visible = true;
            TxtCadastroSelecionado.Text = "           CLIENTE";
            panelTabelas.Controls.Clear();
            MostrarOpcoes();
            operacoes = new OperacoesCliente(new ControladorCliente());
            ConfigurarPanelRegistros();
            btnFiltro.Visible = false;
        }

        private void btnVizualizarConta_Click(object sender, EventArgs e)
        {
            if (panelTelaContaRegistradas.Controls.Count == 0)
            {
                panelTelaContaRegistradas.Controls.Add(new MostrarConta());
                panelTelaContaRegistradas.Visible = true;
                return;
            }
            if (panelTelaContaRegistradas.Controls.Count == 1)
            {
                if (panelTelaContaRegistradas.Visible == false)
                {
                    panelTelaContaRegistradas.Visible = true;
                    return;
                }
            }
            if (panelTelaContaRegistradas.Controls.Count == 1)
            {
                if (panelTelaContaRegistradas.Visible == true)
                {
                    panelTelaContaRegistradas.Visible = false;
                    return;
                }
            }
            
        }

        private void gRUPODEVEÍCULOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtCadastroSelecionado.Visible = true;
            TxtCadastroSelecionado.Text = " GRUPO DE VEÍCULOS";
            panelTabelas.Controls.Clear();
            MostrarOpcoes();
            ImagemChave.Visible = false;
            operacoes = new OperacoesGrupoVeiculos(new ControladorGrupoVeiculos());
            ConfigurarPanelRegistros();
            btnFiltro.Visible = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (login.GerarUsuario() == null)
            {
                ConfiguracoesDeInicio();
                MessageBox.Show("Cadastre uma conta válida");
                return;
            }
            operacoes.InserirNovoRegistro();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (login.GerarUsuario() == null)
            {
                ConfiguracoesDeInicio();
                MessageBox.Show("Cadastre uma conta válida");
                return;
            }
            operacoes.EditarRegistro();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (login.GerarUsuario() == null)
            {
                ConfiguracoesDeInicio();
                MessageBox.Show("Cadastre uma conta válida");
                return;
            }
            operacoes.ExcluirRegistro();
        }

        private void ConfigurarPanelRegistros()
        {
            UserControl tabela = operacoes.ObterTabela();

            tabela.Dock = DockStyle.Fill;

            panelTabelas.Controls.Clear();

            panelTabelas.Controls.Add(tabela);
        }

        private void vEÍCULOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtCadastroSelecionado.Visible = true;
            TxtCadastroSelecionado.Text = "           VEÍCULOS";
            panelTabelas.Controls.Clear();
            MostrarOpcoes();
            ImagemChave.Visible = false;
            operacoes = new OperacoesVeiculo(new ControladorVeiculo());
            ConfigurarPanelRegistros();
            btnFiltro.Visible = false;
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            if (login.GerarUsuario() == null)
            {
                ConfiguracoesDeInicio();
                MessageBox.Show("Cadastre uma conta válida");
                return;
            }
        }

        private void StripMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (login.GerarUsuario() == null)
            {
                ConfiguracoesDeInicio();
                ConfiguracaoMenu(false);
                MessageBox.Show("Cadastre uma conta válida");
                return;
            }
            else
            {
                ConfiguracaoMenu(true);
            }
        }

        private void tAXASESERVIÇOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtCadastroSelecionado.Visible = true;
            TxtCadastroSelecionado.Text = "    TAXAS E SERVIÇOS";
            panelTabelas.Controls.Clear();
            MostrarOpcoes();
            operacoes = new OperacoesTaxasServicos(new ControladorTaxasServicos());
            ConfigurarPanelRegistros();
            btnFiltro.Visible = false;
        }

        private void cOMBUSTÍVELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtCadastroSelecionado.Visible = true;
            TxtCadastroSelecionado.Text = "       COMBUSTÍVEL";
            panelTabelas.Controls.Clear();
            MostrarOpcoes();
            operacoes = new OperacoesCombustivel(new ControladorCombustivel());
            ConfigurarPanelRegistros();
            btnFiltro.Visible = false;
        }

        private void sEGUROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtCadastroSelecionado.Visible = true;
            TxtCadastroSelecionado.Text = "          SEGUROS";
            panelTabelas.Controls.Clear();
            MostrarOpcoes();
            operacoes = new OperacoesSeguros(new ControladorSeguros());
            ConfigurarPanelRegistros();
            btnFiltro.Visible = false;
        }

        private void btnCarrosAlugados_Click(object sender, EventArgs e)
        {
            panelTabelas.Controls.Remove(dashboard);
            panelTabelas.Controls.Add(tabelaCarrosAlugados);
            btnCarrosAlugados.Visible = false;
            btnCarrosDisponiveis.Visible = false;
            btnLocacoesPendentes.Visible = false;
        }

        private void btnCarrosDisponiveis_Click(object sender, EventArgs e)
        {
            panelTabelas.Controls.Remove(dashboard);
            panelTabelas.Controls.Add(tabelaCarrosDisponiveis);
            btnCarrosAlugados.Visible = false;
            btnCarrosDisponiveis.Visible = false;
            btnLocacoesPendentes.Visible = false;
        }

        private void btnLocacoesPendentes_Click(object sender, EventArgs e)
        {
            panelTabelas.Controls.Remove(dashboard);
            panelTabelas.Controls.Add(tabelaLocacoes);
            btnCarrosAlugados.Visible = false;
            btnCarrosDisponiveis.Visible = false;
            btnLocacoesPendentes.Visible = false;
        }

        private void TxtMenu_Click(object sender, EventArgs e)
        {
            if (login.GerarUsuario() != null)
            {
                if (operacoes != null)
                {
                    panelTabelas.Controls.Remove(operacoes.ObterTabela());
                    panelTabelas.Controls.Add(btnCarrosAlugados);
                    panelTabelas.Controls.Add(btnCarrosDisponiveis);
                    panelTabelas.Controls.Add(btnLocacoesPendentes);
                    panelTabelas.Controls.Add(txtV1);
                    panelTabelas.Controls.Add(txtV2);
                    panelTabelas.Controls.Add(txtV3);
                   
                }
                
                panelTabelas.Controls.Add(btnCarrosAlugados);
                panelTabelas.Controls.Add(btnCarrosDisponiveis);
                panelTabelas.Controls.Add(btnLocacoesPendentes);
                panelTabelas.Controls.Add(txtV1);
                panelTabelas.Controls.Add(txtV2);
                panelTabelas.Controls.Add(txtV3);
                panelTabelas.Controls.Remove(tabelaLocacoes);
                panelTabelas.Controls.Remove(tabelaCarrosDisponiveis);
                panelTabelas.Controls.Remove(tabelaCarrosAlugados);
                panelTabelas.Controls.Add(dashboard);
                ImagemChave.Visible = false;
                btnAdicionar.Visible = false;
                btnEditar.Visible = false;
                btnExcluir.Visible = false;
                TxtCadastroSelecionado.Visible = false;
                ImagemLinha.Visible = false;
                ImagemLinha2.Visible = false;
                btnCarrosDisponiveis.Visible = true;
                btnCarrosAlugados.Visible = true;
                btnLocacoesPendentes.Visible = true;
                txtV1.Visible = true;
                txtV2.Visible = true;
                txtV3.Visible = true;
            }
        }

        public TelaPrincipalCadastros MudarPanel()
        {
            return Instancia;
        }

        private void btnLocacoesPendentes_Click_1(object sender, EventArgs e)
        {
            panelTabelas.Controls.Remove(dashboard);
            panelTabelas.Controls.Add(tabelaLocacoes);
            btnCarrosAlugados.Visible = false;
            btnCarrosDisponiveis.Visible = false;
            btnLocacoesPendentes.Visible = false;
            txtV1.Visible = false;
            txtV2.Visible = false;
            txtV3.Visible = false;
        }

        private void btnCarrosDisponiveis_Click_1(object sender, EventArgs e)
        {
            panelTabelas.Controls.Remove(dashboard);
            panelTabelas.Controls.Add(tabelaCarrosDisponiveis);
            btnCarrosAlugados.Visible = false;
            btnCarrosDisponiveis.Visible = false;
            btnLocacoesPendentes.Visible = false;
            txtV1.Visible = false;
            txtV2.Visible = false;
            txtV3.Visible = false;
        }

        private void btnCarrosAlugados_Click_1(object sender, EventArgs e)
        {
            panelTabelas.Controls.Remove(dashboard);
            panelTabelas.Controls.Add(tabelaCarrosAlugados);
            btnCarrosAlugados.Visible = false;
            btnCarrosDisponiveis.Visible = false;
            btnLocacoesPendentes.Visible = false;
            txtV1.Visible = false;
            txtV2.Visible = false;
            txtV3.Visible = false;
        }

        private void lOCAÇÃOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtCadastroSelecionado.Text = "          LOCAÇÃO";
            panelTabelas.Controls.Clear();
            MostrarOpcoes();
            operacoes = new OperacoesLocacao(new ControladorLocacao());
            ConfigurarPanelRegistros();
            btnFiltro.Visible = false;
        }
    }
}
