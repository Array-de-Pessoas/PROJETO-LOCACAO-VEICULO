using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System;
using LocadoraVeiculos.Dominio.FuncionarioModule;

namespace LocadoraVeiculos.Tests.FuncionarioModule
{
    [TestClass]
    [TestCategory("Dominio")]
    public class FuncionarioTest
    {

        [TestMethod]
        public void DeveValidarTodosOsCampos()
        {
            var funcionario = new Funcionario("Maria Fernanda", "mariFer", "124321", new DateTime(2016, 10, 20, 0, 0, 0), 5000.50m);

            var resultadoValidacao = funcionario.Validar();

            resultadoValidacao.Should().Be("ESTA_VALIDO");
        }

        [TestMethod]
        public void DeveValidarNome()
        {
            var funcionario = new Funcionario("", "mariFer", "124321", new DateTime(2016, 10, 20, 0, 0, 0), 5000.50m);

            var resultadoValidacao = funcionario.Validar();

            resultadoValidacao.Should().Be("O campo nome não pode estar vazio");
        }

        [TestMethod]
        public void DeveValidarUsuario()
        {
            var funcionario = new Funcionario("Maria Fernanda", "", "124321", new DateTime(2016, 10, 20, 0, 0, 0), 5000.50m);

            var resultadoValidacao = funcionario.Validar();

            resultadoValidacao.Should().Be("O campo usuário não pode estar vazio");
        }

        [TestMethod]
        public void DeveValidarSenha()
        {
            var funcionario = new Funcionario("Maria Fernanda", "mariFer", "", new DateTime(2016, 10, 20, 0, 0, 0), 5000.50m);

            var resultadoValidacao = funcionario.Validar();

            resultadoValidacao.Should().Be("O campo senha não pode estar vazio");
        }

    }
}
