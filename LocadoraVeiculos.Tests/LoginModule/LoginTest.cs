using LocadoraVeiculos.WindowsForm.Feature.LoginModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraVeiculos.Tests.LoginModule
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void DeveValidarSeExiste()
        {
            UsuarioParaValidacao.Usuario = "Fer";
            UsuarioParaValidacao.Senha = "124321";

            OperacoesLogin operacoes = new OperacoesLogin();
            operacoes.ValidarSeExiste();

            UsuarioParaValidacao.Usuario = null;
            UsuarioParaValidacao.Senha = null;
        }

        [TestMethod]
        public void DeveValidarSeNaoExiste()
        {
            UsuarioParaValidacao.Usuario = "Lucas";
            UsuarioParaValidacao.Senha = "124321";

            OperacoesLogin operacoes = new OperacoesLogin();
            operacoes.ValidarSeExiste();

            UsuarioParaValidacao.Usuario = null;
            UsuarioParaValidacao.Senha = null;
        }
    }
}
