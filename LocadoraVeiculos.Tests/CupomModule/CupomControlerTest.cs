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
    }
}
