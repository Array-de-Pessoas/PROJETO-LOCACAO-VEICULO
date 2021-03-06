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
            var novoSeguro = new Seguros("Condutor", 1000m);

            //action
            controlador.InserirNovo(novoSeguro);

            //assert
            var SeguroEncontrada = controlador.SelecionarPorId(novoSeguro.Id);
            SeguroEncontrada.Should().Be(novoSeguro);
        }

        [TestMethod]
        public void DeveAtualizar()
        {
            var seguro = new Seguros("Condutor", 1000m);
            controlador.InserirNovo(seguro);

            var NovoSeguro = new Seguros("Condutor Plus", 1000m);

            controlador.Editar(seguro.Id, NovoSeguro);

            Seguros SeguroAtualizado = controlador.SelecionarPorId(seguro.Id);
            SeguroAtualizado.Should().Be(NovoSeguro);
        }

        [TestMethod]
        public void DeveExcluir()
        {
            var seguro = new Seguros("Condutor", 5000.50m);
            controlador.InserirNovo(seguro);

            controlador.Excluir(seguro.Id);

            Seguros TaxasServicosAtualizado = controlador.SelecionarPorId(seguro.Id);
            TaxasServicosAtualizado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TaxasServicos_PorId()
        {
            var seguro = new Seguros("Terceiros", 1000m);
            controlador.InserirNovo(seguro);

            Seguros SeguroAtualizado = controlador.SelecionarPorId(seguro.Id);

            SeguroAtualizado.Should().NotBeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosFuncionarios_OrdenadosPorNome()
        {
            var S1 = new Seguros("Condutor Plus", 1000m);
            controlador.InserirNovo(S1);

            var S2 = new Seguros("Condutor",1000m);
            controlador.InserirNovo(S2);

            var S3 = new Seguros("Terceiros", 1000m);
            controlador.InserirNovo(S3);

            var seguros = controlador.SelecionarTodos();

            seguros.Should().HaveCount(3);
            seguros[0].TipoSeguro.Should().Be("Condutor Plus");
            seguros[1].TipoSeguro.Should().Be("Condutor");
            seguros[2].TipoSeguro.Should().Be("Terceiros");
        }
    }
}
