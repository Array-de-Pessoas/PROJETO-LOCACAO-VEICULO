using FluentAssertions;
using LocadoraVeiculos.Dominio.TaxasServicosModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraVeiculos.Tests.TaxasServicosModule
{
    [TestClass]
    [TestCategory("Dominio")]
    public class FuncionarioTest
    {
        [TestMethod]
        public void DeveValidarTodosOsCampos()
        {
            var taxasServicos = new TaxasServicos("Diária", "Cadeirinha", 5000.50m);

            var resultadoValidacao = taxasServicos.Validar();

            resultadoValidacao.Should().Be("ESTA_VALIDO");
        }

        [TestMethod]
        public void DeveValidarTipoDeTaxa()
        {
            var taxasServicos = new TaxasServicos("", "Cadeirinha", 5000.50m);

            var resultadoValidacao = taxasServicos.Validar();

            resultadoValidacao.Should().Be("                                                     O campo tipo de taxa não pode estar vazio");
        }

        [TestMethod]
        public void DeveValidarNome()
        {
            var taxasServicos = new TaxasServicos("Diária", "", 5000.50m);

            var resultadoValidacao = taxasServicos.Validar();

            resultadoValidacao.Should().Be("                                                     O campo nome não pode estar vazio");
        }

    }
}
