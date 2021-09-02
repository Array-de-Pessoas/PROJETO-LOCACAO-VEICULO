using LocadoraVeiculos.Controladores.ClienteModule;
using LocadoraVeiculos.Dominio;
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

namespace LocadoraVeiculos.WindowsForm.Features.ClienteModule
{
    public partial class TelaClienteForm : Form
    {
        public string TipoId;

        private Cliente cliente;
        private readonly ControladorCliente controladorCliente = null;

        public TelaClienteForm()
        {
            InitializeComponent();
            controladorCliente = new ControladorCliente();
        }

        public Cliente Cliente
        {
            get { return cliente; }

            set
            {
                cliente = value;

                txtId.Text = cliente.Id.ToString();
                txtNomeCliente.Text = cliente.NomeCliente;
                txtEndereco.Text = cliente.Endereco;
                txtTelefone.Text = cliente.Telefone;
                txtEmail.Text = cliente.Email;
                TipoId = cliente.TipoDeIdentidade;
                txtNomeCondutor.Text = cliente.NomeDoCondutor;
                txtCPFcondutor.Text = cliente.CPFDoCondutor;
                txtRG.Text = cliente.RGDoCondutor;
                txtCNH.Text = cliente.CNH;
                dateTimeValidacaoCNH.Value = cliente.DataValidadeCNH;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoId.SelectedItem == "CPF")
                TipoId = "CPF";

            if (comboBoxTipoId.SelectedItem == "CNPJ")
                TipoId = "CNPJ";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string NomeCliente = txtNomeCliente.Text;
            string Endereco = txtEndereco.Text;
            string Telefone = txtTelefone.Text;
            string Email = txtEmail.Text;
            string Tipoid = TipoId;
            string NomeCondutor = txtNomeCondutor.Text;
            string CNH = txtCNH.Text;
            string CPFCondutor = txtCPFcondutor.Text;
            string RG = txtRG.Text;
            DateTime Validacao = dateTimeValidacaoCNH.Value;

            cliente = new Cliente(NomeCliente,Endereco,Telefone,Email,Tipoid,NomeCondutor,CNH,CPFCondutor,RG,Validacao);

            string resultadoValidacao = cliente.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                DialogResult = DialogResult.None;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
