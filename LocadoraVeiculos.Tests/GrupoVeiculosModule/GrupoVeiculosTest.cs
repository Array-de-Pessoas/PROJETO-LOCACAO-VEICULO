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
        public void DeveValidarNomeGrupo_Vazio()
        {
            // ARRANGE
            var grupoVeiculos = new GrupoVeiculos(null);

            // ACTION
            var resultadoValidacao = grupoVeiculos.Validar();

            //ASSERT
            resultadoValidacao.Should().Be("O campo Nome do grupo é obrigatório");
        }

        [TestMethod]
        public void DeveValidarNomeGrupoCorreto()
        {
            // ARRANGE
            var grupoVeiculos = new GrupoVeiculos("SUV");

            // ACTION
            var resultadoValidacao = grupoVeiculos.Validar();

            //ASSERT
            resultadoValidacao.Should().Be("ESTA_VALIDO");
        }
    }
}
