using FluentAssertions;
using LocadoraVeiculos.Controladores.CupomModule;
using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Dominio.CupomModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraVeiculos.Tests.CupomModule
{
    [TestClass]
    [TestCategory("Controladores")]
    public class CupomControlerTest
    {
        ControladorCupom controlador;

        public CupomControlerTest()
        {
            controlador = new ControladorCupom();
            Db.Update("DELETE FROM [TBCUPOM]; DBCC CHECKIDENT('TBCUPOM', RESEED, 0)");
        }

        [TestMethod]
        public void DeveInserir()
        {
            //arrange
            var novoCupom = new Cupom("GHTRS","Desconto", 5000.50m, 5000.50m, "Lucas", DateTime.Now, 1);

            //action
            controlador.InserirNovo(novoCupom);

            //assert
            var CupomEncontrado = controlador.SelecionarPorId(novoCupom.Id);
            CupomEncontrado.Codigo.Should().Be(novoCupom.Codigo);
        }

        [TestMethod]
        public void DeveExlcuir()
        {
            //arrange
            var novoCupom = new Cupom("GHTRS", "Desconto", 5000.50m, 5000.50m, "Lucas", DateTime.Now, 1);

            //action
            controlador.InserirNovo(novoCupom);
            controlador.Excluir(novoCupom.Id);

            //assert
            Cupom CupomExcluido = controlador.SelecionarPorId(novoCupom.Id);
            CupomExcluido.Should().BeNull();
        }

        [TestMethod]
        public void DeveEditar()
        {
            //arrange
            var Cupom = new Cupom("GHTRS", "Desconto", 5000.50m, 5000.50m, "Lucas", DateTime.Now, 1);

            //action
            controlador.InserirNovo(Cupom);

            var novoCupom = new Cupom("GHTRS", "Desconto", 5000.50m, 5000.50m, "Lucas", DateTime.Now, 1);

            controlador.Editar(Cupom.Id, novoCupom);

            //assert
            Cupom CupomSelecionado = controlador.SelecionarPorId(Cupom.Id);
            CupomSelecionado.Codigo.Should().Be(novoCupom.Codigo);
        }

        [TestMethod]
        public void DeveSelecionarTodosPorId()
        {
            //arrange
            var Cupom = new Cupom("GHTRS", "Desconto", 5000.50m, 5000.50m, "Lucas", DateTime.Now, 1);

            //action
            controlador.InserirNovo(Cupom);

            //assert
            Cupom CupomSelecionado = controlador.SelecionarPorId(Cupom.Id);

            CupomSelecionado.Should().NotBeNull();
        }

        [TestMethod]
        public void DeveSelecionarTodosCuponsOrdenadosPorNome()
        {
            //arrange
            var C1 = new Cupom("GHTRS", "Desconto", 5000.50m, 5000.50m, "Lucas", DateTime.Now, 1);
            controlador.InserirNovo(C1);

            var C2 = new Cupom("GHJSS", "Desconto", 5000.50m, 5000.50m, "Lucas", DateTime.Now, 1);
            controlador.InserirNovo(C2);

            var C3 = new Cupom("MJNHDS", "Desconto", 5000.50m, 5000.50m, "Lucas", DateTime.Now, 1);
            controlador.InserirNovo(C3);

            //action
            var cupoms = controlador.SelecionarTodos();

            cupoms.Should().HaveCount(3);
            cupoms[0].Codigo.Should().Be("GHTRS");
            cupoms[1].Codigo.Should().Be("GHJSS");
            cupoms[2].Codigo.Should().Be("MJNHDS");
        }
    }
}
