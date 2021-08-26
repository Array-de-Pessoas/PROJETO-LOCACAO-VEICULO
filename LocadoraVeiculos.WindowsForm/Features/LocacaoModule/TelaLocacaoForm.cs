using LocadoraVeiculos.Controladores.ClienteModule;
using LocadoraVeiculos.Controladores.TaxasServicosModule;
using LocadoraVeiculos.Controladores.VeiculoModule;
using LocadoraVeiculos.Dominio;
using LocadoraVeiculos.Dominio.LocacaoModule;
using LocadoraVeiculos.Dominio.TaxasServicosModule;
using LocadoraVeiculos.Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        Locacao locacao;
        public TelaLocacaoForm()
        {
            InitializeComponent();
            controladorCliente = new ControladorCliente();
            controladorVeiculo = new ControladorVeiculo();
            controladorTaxasServicos = new ControladorTaxasServicos();

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
                txtPreco.Text = locacao.preco.ToString();
                dtLocacao.Value = Convert.ToDateTime(locacao.dataLocacao.ToShortDateString());
                dtDevolucao.Value = Convert.ToDateTime(locacao.dataDevolucao.ToShortDateString());
            }
        }
        private void TelaLocacaoForm_Load(object sender, EventArgs e)
        {
            CarregarComboBoxs();
        }
        private void CarregarComboBoxs()
        {
            List<Veiculo> veiculos = controladorVeiculo.SelecionarTodos();

            cbVeiculo.DisplayMember = "Placa";
            cbVeiculo.ValueMember = "Id";
            cbVeiculo.DataSource = veiculos;

            List<Cliente> clientes = controladorCliente.SelecionarTodos();

            cbCliente.DisplayMember = "Nome";
            cbCliente.ValueMember = "Id";
            cbCliente.DataSource = clientes;

            List<TaxasServicos> taxasServicos = controladorTaxasServicos.SelecionarTodos();

            cbTaxa.DisplayMember = "TipoTaxa";
            cbTaxa.ValueMember = "Id";
            cbTaxa.DataSource = taxasServicos;
        }
         
        private void btnGravar_Click(object sender, EventArgs e)
        {
            int id_cliente, id_veiculo, id_taxa;

            DateTime dataLocacao = dtLocacao.Value;
            DateTime dataDevolucao = dtDevolucao.Value;

            //if (veiculo.Validar() != "VALIDO")
            //{
            //    string primeiroErro = new StringReader(veiculo.Validar()).ReadLine();
            //    TelaPrincipal.Instancia.AtualizarRodape(primeiroErro);
            //    DialogResult = DialogResult.None;
            //}
        }
    }
}
