using Microsoft.VisualStudio.TestTools.UnitTesting;
using LocadoraVeiculos.Controladores.GrupoVeiculosModule;
using LocadoraVeiculos.Dominio.GrupoVeiculosModule;
using FluentAssertions;
using System;
using eAgenda.Controladores.Shared;

namespace LocadoraVeiculos.Tests.GrupoVeiculosModule
{
    [TestClass]
    [TestCategory("Controladores")]
    public class ControladorGrupoVeiculosTest
    {
        ControladorGrupoVeiculos controlador;

        public ControladorGrupoVeiculosTest()
        {
            controlador = new ControladorGrupoVeiculos();
            Db.Update("DELETE FROM [TBGRUPOVEICULOS]");
        }

        [TestMethod]
        public void DeveInserirGrupoVeiculos()
        {
            //arrange
            var novoGrupo = new GrupoVeiculos("SUV");

            //action
            controlador.InserirNovo(novoGrupo);

            //assert
            var GrupoEncontrado = controlador.SelecionarPorId(novoGrupo.Id);
            GrupoEncontrado.Should().Be(novoGrupo);
        }
    }
}
