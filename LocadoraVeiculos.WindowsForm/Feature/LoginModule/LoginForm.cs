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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            StatusLogin.Text = "Entre com o seu Login";
        }

        public static string login;

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioParaValidacao.Usuario = textBox1.Text;
            UsuarioParaValidacao.Senha = textBox2.Text;

            if (textBox1.TextLength == 0)
            {
                StatusLogin.Text = "O campo usuário está vazio";
                return;
            }
            if (textBox2.TextLength == 0)
            {
                StatusLogin.Text = "O campo senha está vazio";
                return;
            }

            OperacoesLogin operacoesLogin = new OperacoesLogin();
            operacoesLogin.ValidarSeExiste();

            if (login == "Existe")
            {
                this.Close();
                UsuarioParaValidacao.MudarConta = "ContaAcessada";
                login = null;
            }
            if (login == "NaoExiste")
            {
                StatusLogin.Text = "Login não encontrado, tente novamente ou crie um novo";
            }
            if (login == "DadosIncorretos")
            {
                StatusLogin.Text = "Dados do usuário ou senha estão incorretos";
            }
        }

        public void LoginEncontrado()
        {
            login = "Existe";
        }

        public void LoginNaoEncontrado()
        {
            login = "NaoExiste";
        }

        public void DadosIncorretos()
        {
            login = "DadosIncorretos";
        }
    }
}
