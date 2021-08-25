using FluentAssertions;
using LocadoraVeiculos.Controladores.SegurosModule;
using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Dominio.SegurosModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraVeiculos.Tests.SegurosModule
{
    [TestClass]
    [TestCategory("Controladores")]
    public class ControladorSegurosTest
    {
        ControladorSeguros controlador;

        public ControladorSegurosTest()
        {
            controlador = new ControladorSeguros();
            Db.Update("DELETE FROM [TBSEGUROS]; DBCC CHECKIDENT('TBSEGUROS', RESEED, 0)");
        }

        [TestMethod]
        public void DeveInserir()
        {
            //arrange
            var novoSeguro = new Seguros("Contra Incêndio", 5000.50m);

            //action
            controlador.InserirNovo(novoSeguro);

            //assert
            var SeguroEncontrada = controlador.SelecionarPorId(novoSeguro.Id);
            SeguroEncontrada.Should().Be(novoSeguro);
        }

        [TestMethod]
        public void DeveAtualizar()
        {
            var seguro = new Seguros("Contra Incêndio", 5000.50m);
            controlador.InserirNovo(seguro);

            var NovoSeguro = new Seguros("Pneu furado", 5000.50m);

            controlador.Editar(seguro.Id, NovoSeguro);

            Seguros SeguroAtualizado = controlador.SelecionarPorId(seguro.Id);
            SeguroAtualizado.Should().Be(NovoSeguro);
        }

        [TestMethod]
        public void DeveExcluir()
        {
            var seguro = new Seguros("Contra Incêndio", 5000.50m);
            controlador.InserirNovo(seguro);

            controlador.Excluir(seguro.Id);

            Seguros TaxasServicosAtualizado = controlador.SelecionarPorId(seguro.Id);
            TaxasServicosAtualizado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TaxasServicos_PorId()
        {
            var seguro = new Seguros("Contra Incêndio", 5000.50m);
            controlador.InserirNovo(seguro);

            Seguros SeguroAtualizado = controlador.SelecionarPorId(seguro.Id);

            SeguroAtualizado.Should().NotBeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosFuncionarios_OrdenadosPorNome()
        {
            var S1 = new Seguros("Pneu furado", 5000.50m);
            controlador.InserirNovo(S1);

            var S2 = new Seguros("Pegou fogo",5000.50m);
            controlador.InserirNovo(S2);

            var S3 = new Seguros("Barbeiro", 5000.50m);
            controlador.InserirNovo(S3);

            var seguros = controlador.SelecionarTodos();

            seguros.Should().HaveCount(3);
            seguros[0].TipoSeguro.Should().Be("Pneu furado");
            seguros[1].TipoSeguro.Should().Be("Pegou fogo");
            seguros[2].TipoSeguro.Should().Be("Barbeiro");
        }
    }
}
