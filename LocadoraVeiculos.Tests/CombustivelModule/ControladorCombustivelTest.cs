using FluentAssertions;
using LocadoraVeiculos.Controladores.CombustivelModule;
using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Dominio.CombustivelModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraVeiculos.Tests.CombustivelModule
{
    [TestClass]
    [TestCategory("Controladores")]
    public class ControladorCombustivelTest
    {
        ControladorCombustivel controlador;

        public ControladorCombustivelTest()
        {
            controlador = new ControladorCombustivel();
            Db.Update("DELETE FROM [TBCOMBUSTIVEL]; DBCC CHECKIDENT('TBCOMBUSTIVEL', RESEED, 0)");
        }

        [TestMethod]
        public void DeveInserir()
        {
            //arrange
            var novoCombustivel = new Combustivel("Diesel", 5000.50m);

            //action
            controlador.InserirNovo(novoCombustivel);

            //assert
            var CombustivelEncontrado = controlador.SelecionarPorId(novoCombustivel.Id);
            CombustivelEncontrado.Should().Be(novoCombustivel);
        }

        [TestMethod]
        public void DeveAtualizar()
        {
            var combustivel = new Combustivel("Diesel", 5000.50m);
            controlador.InserirNovo(combustivel);

            var novoCombustivel = new Combustivel("Diesel", 5000.50m);

            controlador.Editar(combustivel.Id, novoCombustivel);

            Combustivel CombustivelSelecionado = controlador.SelecionarPorId(combustivel.Id);
            CombustivelSelecionado.Should().Be(novoCombustivel);
        }

        [TestMethod]
        public void DeveExcluir()
        {
            var combustivel = new Combustivel("Diesel", 5000.50m);
            controlador.InserirNovo(combustivel);

            controlador.Excluir(combustivel.Id);

            Combustivel CombustivelAtualizado = controlador.SelecionarPorId(combustivel.Id);
            CombustivelAtualizado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TaxasServicos_PorId()
        {
            var combustivel = new Combustivel("Diesel", 5000.50m);
            controlador.InserirNovo(combustivel);

            Combustivel CombustivelAtualizado = controlador.SelecionarPorId(combustivel.Id);

            CombustivelAtualizado.Should().NotBeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosFuncionarios_OrdenadosPorNome()
        {
            var C1 = new Combustivel("Diesel", 5000.50m);
            controlador.InserirNovo(C1);

            var C2 = new Combustivel("Diesel", 5000.50m);
            controlador.InserirNovo(C2);

            var C3 = new Combustivel("Diesel", 5000.50m);
            controlador.InserirNovo(C3);

            var combustiveis = controlador.SelecionarTodos();

            combustiveis.Should().HaveCount(3);
            combustiveis[0].TipoCombustivel.Should().Be("Diesel");
            combustiveis[1].TipoCombustivel.Should().Be("Diesel");
            combustiveis[2].TipoCombustivel.Should().Be("Diesel");
        }
    }
}
