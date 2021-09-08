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
        Locacao devolucao;
        private void GerarDevolucao()
        { 
            devolucao = new Locacao(1, 1, 1, 1, 1000, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.AddDays(1).Day), "LIVRE", DateTime.Now.Date, 0);
        }

        private void ResetarBancoDeDados()
        {
            Db.Update("DELETE FROM [TBLOCACAO]; DBCC CHECKIDENT('TBLOCACAO', RESEED, 0)");
        }

        [TestMethod]
        public void deveInserirUmaDevolucaoNoBanco()
        {
            //arrange                
            GerarDevolucao();
            //act
            controladorLocacao.InserirNovo(devolucao);
            //assert
            var devolucaoEncontrada = controladorLocacao.SelecionarPorId(devolucao.Id);
            Assert.AreEqual(0, devolucaoEncontrada.locacaoAtiva);


            controladorLocacao.Excluir(devolucao.Id);

        }
    
    }
}
