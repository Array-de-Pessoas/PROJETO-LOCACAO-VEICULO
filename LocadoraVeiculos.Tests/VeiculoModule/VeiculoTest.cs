using LocadoraVeiculos.Dominio.VeiculoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FluentAssertions;

namespace LocadoraVeiculos.Tests.VeiculoModule
{
    [TestClass]
    public class VeiculoTest
    {
        [TestMethod]
        public void DeveRetornarVeiculoValido()
        {
            Veiculo veiculo = new Veiculo();

            string validacao = veiculo.Validar();

            validacao.Should().Be("VALIDO");
        }
    }
}
