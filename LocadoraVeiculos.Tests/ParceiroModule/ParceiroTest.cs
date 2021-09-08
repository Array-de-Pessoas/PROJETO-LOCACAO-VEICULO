using FluentAssertions;
using LocadoraVeiculos.Dominio.ParceiroModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraVeiculos.Tests.ParceiroModule
{
    [TestClass]
    [TestCategory("Dominio")]
    public class ParceiroTest
    {
        [TestMethod]
        public void DeveValidarNomeParceiro()
        {
            var parceiro = new Parceiro("");

            var resultadoValidacao = parceiro.Validar();

            resultadoValidacao.Should().Be("                                                     O campo nome do parceiro não pode estar vazio");
        }
    }
}
