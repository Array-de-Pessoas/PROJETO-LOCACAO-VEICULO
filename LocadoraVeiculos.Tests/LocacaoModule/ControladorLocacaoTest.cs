using FluentAssertions;
using LocadoraVeiculos.Controladores.LocacaoModule;
using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Dominio.LocacaoModule;
using LocadoraVeiculos.Tests.GrupoVeiculosModule;
using LocadoraVeiculos.Tests.VeiculoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace LocadoraVeiculos.Tests.LocacaoModule
{
    /// <summary>
    /// Summary description for ControladorLocacaoTest
    /// </summary>
    [TestClass]
    public class ControladorLocacaoTest
    {
        ControladorLocacao controladorLocacao;
        Locacao locacaoX, locacaoY;
        private void GerarLocacaoY()
        {
            locacaoY = new Locacao(1, 1, 1, 1000, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.AddDays(1).Day));
        }
        private void GerarLocacaoX()
        {
            locacaoX = new Locacao(1, 1, 1, 1000, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.AddDays(1).Day));
        }
        public ControladorLocacaoTest()
        {
            controladorLocacao = new ControladorLocacao();
        }

        private void ResetarBancoDeDados()
        {
           
            Db.Update("DELETE FROM [TBLOCACAO]; DBCC CHECKIDENT('TBLOCACAO', RESEED, 0)"); 
            
        }    

        [TestMethod]
        public void deveCadastrarLocacaoNoBanco()
        {
            //arrange                
            GerarLocacaoX();
            //act
            controladorLocacao.InserirNovo(locacaoX);

            //assert
            var locacaoEncontrada = controladorLocacao.SelecionarPorId(locacaoX.Id);
            Assert.AreEqual(locacaoX.preco, locacaoEncontrada.preco);
            ResetarBancoDeDados();
        }
     
        [TestMethod]
        public void deveEditarLocacaoNoBanco()
        {
            //arrange
            GerarLocacaoX();
            GerarLocacaoY();
            //act
            controladorLocacao.InserirNovo(locacaoX);
            controladorLocacao.Editar(1, locacaoY);
            //assert
            var locacaoEncontrada = controladorLocacao.SelecionarPorId(1);
            Assert.AreEqual(locacaoY.id_cliente, locacaoEncontrada.id_cliente);
            ResetarBancoDeDados();

        }
        [TestMethod]
        public void deveExcluirLocacaoNoBanco()
        {
            //arrange
            GerarLocacaoX();
            //act
            controladorLocacao.InserirNovo(locacaoX);
            controladorLocacao.Excluir(1);
            //assert
            var locacaoEncontrada = controladorLocacao.SelecionarPorId(1);
            Assert.IsNull(locacaoEncontrada);
            ResetarBancoDeDados();
        }
        [TestMethod]
        public void deveSelecionarTodosLocacaoDoBanco()
        {
            //arrange
            GerarLocacaoX();
            GerarLocacaoY();

            //act
            controladorLocacao.InserirNovo(locacaoX);
            controladorLocacao.InserirNovo(locacaoY);
            List<Locacao> locacoes = controladorLocacao.SelecionarTodos();
            //assert
            locacoes.Count.Should().Be(2);
            ResetarBancoDeDados();
        }
     
        [TestMethod]
        public void deveVerificarSeExisteLocacaoNoBanco()
        {
            //arrange
            GerarLocacaoX();
            //act
            controladorLocacao.InserirNovo(locacaoX);
            var resultado = controladorLocacao.Existe(1);
            //assert
            resultado.Should().Be(true);
            ResetarBancoDeDados();
        }
    }
}
