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
            UsuarioParaValidacao.Senha = "124321";

            OperacoesLogin operacoes = new OperacoesLogin();
            operacoes.ValidarSeExiste();

            UsuarioParaValidacao.Usuario = null;
            UsuarioParaValidacao.Senha = null;
        }
    }
}
