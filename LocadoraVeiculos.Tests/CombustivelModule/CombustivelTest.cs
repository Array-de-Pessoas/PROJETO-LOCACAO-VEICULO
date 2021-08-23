using FluentAssertions;
using LocadoraVeiculos.Dominio.CombustivelModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraVeiculos.Tests.CombustivelModule
{
    [TestClass]
    [TestCategory("Dominio")]
    public class CombustivelTest
    {

        [TestMethod]
        public void DeveValidarTodosOsCampos()
        {
            var combustivel = new Combustivel("Diesel", 5000.50m);

            var resultadoValidacao = combustivel.Validar();

            resultadoValidacao.Should().Be("ESTA_VALIDO");
        }

        [TestMethod]
        public void DeveValidarTipoDeCombustivel()
        {
            var combustivel = new Combustivel("", 5000.50m);

            var resultadoValidacao = combustivel.Validar();

            resultadoValidacao.Should().Be("                                                     O campo tipo de combustível não pode estar vazio");
        }
    }
}
