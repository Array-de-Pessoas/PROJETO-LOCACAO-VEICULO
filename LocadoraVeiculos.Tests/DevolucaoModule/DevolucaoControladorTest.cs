using FluentAssertions;
using LocadoraVeiculos.Controladores.CupomModule;
using LocadoraVeiculos.Controladores.LocacaoModule;
using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Dominio.LocacaoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraVeiculos.Tests.zDevolucaoModule
{
    [TestClass]
    public class DevolucaoControladorTest
    {
        ControladorLocacao controladorLocacao = new ControladorLocacao();
        ControladorCupom controladorCupom;
        Locacao devolucao;
        private void GerarDevolucaoComCupom()
        {
            controladorCupom = new ControladorCupom();
            devolucao = new Locacao(1, 1, 1, 1, 1000, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.AddDays(2).Day), "LIVRE", new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.AddDays(2).Day), 0, controladorCupom.SelecionarPorId(1));
        }
        private void GerarDevolucaoSemCupom()
        {
            controladorCupom = new ControladorCupom();
            devolucao = new Locacao(1, 1, 1, 1, 1000, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.AddDays(2).Day), "LIVRE", new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.AddDays(2).Day), 0, null);
        }

        private void GerarDevolucaoAtrasada()
        {
            controladorCupom = new ControladorCupom();
            devolucao = new Locacao(1, 1, 1, 1, 1000, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.AddDays(2).Day), "LIVRE", new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.AddDays(4).Day), 0, controladorCupom.SelecionarPorId(1));
        }

        private void ResetarBancoDeDados()
        {
            Db.Update("DELETE FROM [TBLOCACAO]; DBCC CHECKIDENT('TBLOCACAO', RESEED, 0)");
        }

        [TestMethod]
        public void deveInserirUmaDevolucaoNoBanco()
        {
            //arrange                
            GerarDevolucaoComCupom();
            //act
            controladorLocacao.InserirNovo(devolucao);
            //assert
            var devolucaoEncontrada = controladorLocacao.SelecionarPorId(devolucao.Id);
            Assert.AreEqual(0, devolucaoEncontrada.locacaoAtiva);


            controladorLocacao.Excluir(devolucao.Id);

        }
        [TestMethod]
        public void deveCalcularValorDaLocacaoComCupom()
        {
            //arrange
            GerarDevolucaoComCupom();
            //act
            //2*100 + 1000 + 1000*2 - 10% (320)
            double valor2dias = controladorLocacao.CalcularValorLocacao(devolucao);           
            //assert
            valor2dias.Should().Be(2880);
            
        }
        [TestMethod]
        public void deveCalcularValorDaLocacaoSemCupom()
        {
            //arrange
            GerarDevolucaoSemCupom();
            //act
            //2*100 + 1000 + 1000*2
            double valor2dias = controladorLocacao.CalcularValorLocacao(devolucao);
            //assert
            valor2dias.Should().Be(3200);

        }
        [TestMethod]
        public void deveCalcularValorDaLocacaoComMultaDe_DoisDias()
        {
            //arrange
            GerarDevolucaoAtrasada();
            //act
            //4*100 + 1000 + 1000*4 (5400) - 10% (540) + 2x540 (1080)
            double valor = controladorLocacao.CalcularValorLocacao(devolucao);
            //assert
            valor.Should().Be(5940);

        }

    }
}
