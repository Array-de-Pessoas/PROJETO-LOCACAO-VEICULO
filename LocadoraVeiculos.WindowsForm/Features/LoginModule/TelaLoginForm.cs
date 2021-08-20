using LocadoraVeiculos.Controladores.FuncionarioModule;
using LocadoraVeiculos.Dominio.FuncionarioModule;
using LocadoraVeiculos.WindowsForm.Features.FuncionarioModule;
using LocadoraVeiculos.WindowsForm.Features.LoginModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForm.Features.LoginModule
{
    public partial class TelaLoginForm : Form
    {
        private OperacoesLogin operacoes;
        private Funcionario funcionario;
        public Funcionario LoginFuncionario
        {
            get { return funcionario; }
            set
            {
                funcionario = value;
            }
        }

        public TelaLoginForm()
        {
            InitializeComponent();
            StatusLogin.Text = "Entre com a sua conta";
            operacoes = new OperacoesLogin();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (string.IsNullOrEmpty(usuario))
            {
                StatusLogin.Text = "O campo usuário está inválido";
                MessageBox.Show("O campo usuário está inválido", "Tente novamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (string.IsNullOrEmpty(senha))
            {
                StatusLogin.Text = "O campo senha está inválido";
                MessageBox.Show("O campo senha está inválido", "Tente novamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                LoginFuncionario = operacoes.LoginTest(usuario, senha);
                if (LoginFuncionario == null)
                {
                    MessageBox.Show("O usuário está inválido", "Tente novamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void linkCriarLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            operacoes.NovoLogin();
        }
    }
}
