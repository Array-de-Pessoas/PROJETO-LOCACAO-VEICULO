using LocadoraVeiculos.Controladores.FuncionarioModule;
using LocadoraVeiculos.Dominio.FuncionarioModule;
using LocadoraVeiculos.WindowsForm.Features.FuncionarioModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForm.Features.LoginModule
{
    public class OperacoesLogin
    {
        private readonly ControladorFuncionario controlador;
        private static string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public OperacoesLogin()
        {
            controlador = new ControladorFuncionario();
        }

        public void RealizarLogin()
        {
            LoginForm tela = new LoginForm();
            if (tela.ShowDialog() == DialogResult.OK)
            {
                if (tela.LoginFuncionario != null)
                    Usuario = tela.LoginFuncionario.Usuario;
            }
        }

        public Funcionario LoginTest(string usuario, string senha)
        {
            LoginForm tela = new LoginForm();
            List<Funcionario> funcionarios = controlador.SelecionarTodos();
            foreach (var item in funcionarios)
            {
                if (usuario == item.Usuario)
                {
                    if (senha == item.Senha)
                        return item;

                    else
                        return null;
                }
            }
            return null;
        }

        public void NovoLogin()
        {
            TelaFuncionarioForm tela = new TelaFuncionarioForm();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Funcionario);
            }
        }

        public string GerarUsuario()
        {
            return usuario;
        }
    }
}

