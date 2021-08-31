using LocadoraVeiculos.Controladores.ClienteModule;
using LocadoraVeiculos.Controladores.SegurosModule;
using LocadoraVeiculos.Controladores.TaxasServicosModule;
using LocadoraVeiculos.Controladores.VeiculoModule;
using LocadoraVeiculos.Dominio;
using LocadoraVeiculos.Dominio.CarrosAlugadosModule;
using LocadoraVeiculos.Dominio.LocacaoModule;
using LocadoraVeiculos.Dominio.LocacoesPendentesModule;
using LocadoraVeiculos.Dominio.SegurosModule;
using LocadoraVeiculos.Dominio.TaxasServicosModule;
using LocadoraVeiculos.Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForm.Features.LocacaoModule
{
    public partial class TelaLocacaoForm : Form
    {
        ControladorCliente controladorCliente;
        ControladorVeiculo controladorVeiculo;
        ControladorTaxasServicos controladorTaxasServicos;
        ControladorSeguros controladorSeguros;
        Locacao locacao;
        CarrosAlugados carrosAlugados;
        LocacoesPendentes locacoes;
        public TelaLocacaoForm()
        {
            InitializeComponent();
            controladorCliente = new ControladorCliente();
            controladorVeiculo = new ControladorVeiculo();
            controladorTaxasServicos = new ControladorTaxasServicos();
            controladorSeguros = new ControladorSeguros();
        }
        public Locacao Locacao
        {
            get { return locacao; }

            set
            {
                locacao = value;

                txtId.Text = locacao.Id.ToString();
                cbCliente.ValueMember = locacao.id_cliente.ToString();
                cbVeiculo.ValueMember = locacao.id_veiculo.ToString();
                cbTaxa.ValueMember = locacao.id_taxa.ToString();
                cbSeguro.ValueMember = locacao.id_seguro.ToString();
                txtPreco.Text = locacao.preco.ToString();
                dtLocacao.Value = Convert.ToDateTime(locacao.dataLocacao.ToShortDateString());
                dtDevolucao.Value = Convert.ToDateTime(locacao.dataDevolucao.ToShortDateString());
                cbPlano.ValueMember = locacao.plano;
            }
        }

        public CarrosAlugados CarrosAlugados
        {
            get { return carrosAlugados; }

            set
            {
                carrosAlugados = value;

                cbCliente.ValueMember = carrosAlugados.IdCliente.ToString();
                cbVeiculo.ValueMember = carrosAlugados.IdVeiculo.ToString();
            }
        }

        public LocacoesPendentes LocacoesPendentes
        {
            get { return locacoes; }
            set
            {
                locacoes = value;

                cbCliente.ValueMember = locacoes.IdCliente.ToString();
                cbVeiculo.ValueMember = locacoes.IdVeiculos.ToString();
                dtLocacao.Value = Convert.ToDateTime(locacoes.DataLocacao.ToShortDateString());
                dtDevolucao.Value = Convert.ToDateTime(locacoes.DataDevolucao.ToShortDateString());

            }
        }

        private void TelaLocacaoForm_Load(object sender, EventArgs e)
        {
            CarregarComboBoxs();
        }
        private void CarregarComboBoxs()
        {

            List<Cliente> clientes = controladorCliente.SelecionarTodos();

            cbCliente.DisplayMember = "NomeCliente";
            cbCliente.ValueMember = "Id";
            cbCliente.DataSource = clientes;

            List<Veiculo> veiculos = controladorVeiculo.SelecionarTodos();

            cbVeiculo.DisplayMember = "Placa";
            cbVeiculo.ValueMember = "Id";
            cbVeiculo.DataSource = veiculos;

            string[] planos= new string[3] { "Diário","Controlado","Livre"};

            cbPlano.DataSource = planos;

            List<TaxasServicos> taxasServicos = controladorTaxasServicos.SelecionarTodos();

            cbTaxa.DisplayMember = "Nome";
            cbTaxa.ValueMember = "Id";
            cbTaxa.DataSource = taxasServicos;

            List<Seguros> seguros = controladorSeguros.SelecionarTodos();

            cbSeguro.DisplayMember = "TipoSeguro";
            cbSeguro.ValueMember = "Id";
            cbSeguro.DataSource = seguros;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            double preco =0;

            string plano = Convert.ToString(cbPlano.SelectedValue);
            int id_seguro = Convert.ToInt32(cbSeguro.SelectedValue);
            int id_cliente = Convert.ToInt32(cbCliente.SelectedValue);
            int id_veiculo = Convert.ToInt32(cbVeiculo.SelectedValue);
            int id_taxa = Convert.ToInt32(cbTaxa.SelectedValue);      

            DateTime dataLocacao = dtLocacao.Value;
            DateTime dataDevolucao = dtDevolucao.Value;

            locacao = new Locacao(id_cliente, id_veiculo, id_taxa, id_seguro, preco, dataLocacao, dataDevolucao, plano, DateTime.Now.Date, 1);

            carrosAlugados = new CarrosAlugados(id_cliente, id_veiculo);

            locacoes = new LocacoesPendentes(id_cliente, id_veiculo, dataLocacao, dataDevolucao);

            if (locacao.Validar() != "VALIDO")
            {
                string primeiroErro = new StringReader(locacao.Validar()).ReadLine();
                TelaPrincipal.Instancia.AtualizarRodape(primeiroErro);
                DialogResult = DialogResult.None;
            }
        }
    }
}
