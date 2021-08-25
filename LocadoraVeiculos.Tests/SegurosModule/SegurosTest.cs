using FluentAssertions;
using LocadoraVeiculos.Dominio.SegurosModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraVeiculos.Tests.SegurosModule
{
    [TestClass]
    [TestCategory("Dominio")]
    public class SegurosTest
    {
        [TestMethod]
        public void DeveValidarTodosOsCampos()
        {
            var seguros = new Seguros("Pneu furado", 5000.50m);

            var resultadoValidacao = seguros.Validar();

            resultadoValidacao.Should().Be("ESTA_VALIDO");
        }

        [TestMethod]
        public void DeveValidarTipoDeSeguro()
        {
            var seguros = new Seguros("", 5000.50m);

            var resultadoValidacao = seguros.Validar();

            resultadoValidacao.Should().Be("                                                     O campo tipo de seguro não pode estar vazio");
        }
    }
}
