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
using LocadoraVeiculos.Dominio.FuncionarioModule;

namespace LocadoraVeiculos.WindowsForm.Features.FuncionarioModule
{
    public partial class TelaFuncionarioForm : Form
    {
        private Funcionario funcionario;

        public TelaFuncionarioForm()
        {
            InitializeComponent();
        }

        public Funcionario Funcionario
        {
            get { return funcionario; }

            set
            {
                funcionario = value;

                txtId.Text = funcionario.Id.ToString();
                txtNome.Text = funcionario.Nome.ToString();
                txtUsuario.Text = funcionario.Usuario.ToString();
                txtSenha.Text = funcionario.Senha.ToString();
                dateDataEntrada.Text = funcionario.DataEntrada.ToShortDateString();
                txtSalario.Text = funcionario.Salario.ToString();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            DateTime dataEntrada = dateDataEntrada.Value;
            decimal salario = Convert.ToDecimal(txtSalario.Text);

            funcionario = new Funcionario(nome, usuario, senha, dataEntrada, salario);

            string resultadoValidacao = funcionario.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();
                TelaPrincipal.Instancia.AtualizarRodape(primeiroErro);
                DialogResult = DialogResult.None;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TelaPrincipal.Instancia.AtualizarRodape("");
        }

        private void TelaFuncionarioForm_Load(object sender, EventArgs e)
        {

        }
    }
}
