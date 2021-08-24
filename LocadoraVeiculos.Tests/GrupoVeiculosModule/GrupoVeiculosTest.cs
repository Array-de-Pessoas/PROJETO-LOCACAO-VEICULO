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
        public void DeveValidarKMRodadoGrupo_Vazio()
        {
            // ARRANGE
            var grupoVeiculos = new GrupoVeiculos("A", 0, 100, 100, 100, 100, 100);

            // ACTION
            var resultadoValidacao = grupoVeiculos.Validar();

            //ASSERT
            resultadoValidacao.Should().Be("O campo Valor da Diária do Plano Diário é obrigatório");
        }

        [TestMethod]
        public void DeveValidarNomeGrupoCorreto()
        {
            // ARRANGE
            var grupoVeiculos = new GrupoVeiculos("SUV", 100, 100, 100, 100, 100, 100);

            // ACTION
            var resultadoValidacao = grupoVeiculos.Validar();

            //ASSERT
            resultadoValidacao.Should().Be("ESTA_VALIDO");
        }
    }
}
