using FluentAssertions;
using LocadoraVeiculos.Dominio.GrupoVeiculosModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraVeiculos.Tests.GrupoVeiculosModule
{
    [TestClass]
    [TestCategory("Dominio")]
    public class GrupoVeiculosTest
    {
        [TestMethod]
        public void DeveValidarNomeGrupo()
        {
            // ARRANGE
            var grupoVeiculos = new GrupoVeiculos("SUV");

            // ACTION
            var resultadoValidacao = grupoVeiculos.Validar();

            //ASSERT
            resultadoValidacao.Should().Be("O campo Grupo está inválido");
        }
    }
}
