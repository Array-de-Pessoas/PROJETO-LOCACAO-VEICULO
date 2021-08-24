using LocadoraVeiculos.Controladores.VeiculoModule;
using LocadoraVeiculos.Dominio.VeiculoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Controladores.GrupoVeiculosModule;
using LocadoraVeiculos.Dominio.GrupoVeiculosModule;
using NUnit.Framework;

namespace LocadoraVeiculos.Tests.VeiculoModule
{
    [TestClass]
    public partial class ControladorVeiculoTest
    {
        ControladorVeiculo controladorVeiculo;
        ControladorGrupoVeiculos controladorGrupoVeiculo;
        Veiculo veiculoFIAT;
        Veiculo veiculoFORD;           

        public ControladorVeiculoTest()
        {
            controladorVeiculo = new ControladorVeiculo();
            controladorGrupoVeiculo = new ControladorGrupoVeiculos();        
        }

        private void ResetarBanco()
        {
            Db.Update("DELETE FROM [TBVEICULO]; DBCC CHECKIDENT('TBVEICULO', RESEED, 0)");
            Db.Update("DELETE FROM [TBGRUPOVEICULOS]; DBCC CHECKIDENT('TBVEICULO', RESEED, 0)");

        }
        private void GerarVeiculoFIAT()
        {

            byte[] foto = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
            var novoGrupo = new GrupoVeiculos("SUV", 100, 100, 100, 100, 100, 100);
            controladorGrupoVeiculo.InserirNovo(novoGrupo);
            veiculoFIAT = new Veiculo("ETH-3000", "Azul", "FIAT", 2015, "Gasolina", foto, 300, 4, 5, "G", 10000, novoGrupo.Id);
        }

        private void GerarVeiculoFORD()
        {
            var novoGrupo = new GrupoVeiculos("SUV", 100, 100, 100, 100, 100, 100);
            controladorGrupoVeiculo.InserirNovo(novoGrupo);
            byte[] foto = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
            veiculoFORD = new Veiculo("ADA-1000", "Preto", "Ford", 2015, "Gasolina", foto, 300, 4, 5, "G", 10000, novoGrupo.Id);
        }

        [TestMethod]
        public void deveCadastrarVeiculoNoBanco()
        {
            //arrange                
            GerarVeiculoFIAT();
            //act
            controladorVeiculo.InserirNovo(veiculoFIAT);
            
            //assert
            var veiculoEncontrado = controladorVeiculo.SelecionarPorId(veiculoFIAT.Id);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(veiculoFIAT.placa, veiculoEncontrado.placa);
            ResetarBanco();
        }
        [TestMethod]
        public void deveEditarVeiculoNoBanco()
        {
            //arrange
            GerarVeiculoFIAT();
            GerarVeiculoFORD();
            //act
            controladorVeiculo.InserirNovo(veiculoFIAT);
            controladorVeiculo.Editar(1,veiculoFORD);
            //assert
            var veiculoEncontrado = controladorVeiculo.SelecionarPorId(1);
            NUnit.Framework.Assert.AreEqual(veiculoFORD.placa, veiculoEncontrado.placa);

            ResetarBanco();
        }
        [TestMethod]
        public void deveExcluirVeiculoNoBanco()
        {
            //arrange
            GerarVeiculoFIAT();
            //act
            controladorVeiculo.InserirNovo(veiculoFIAT);
            controladorVeiculo.Excluir(1);
            //assert
            var veiculoEncontrado = controladorVeiculo.SelecionarPorId(1);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNull(veiculoEncontrado);
            ResetarBanco();
        }
        [TestMethod]
        public void deveSelecionarTodosVeiculosDoBanco()
        {
            //arrange
            GerarVeiculoFIAT();
            GerarVeiculoFORD();
     
            //act
            controladorVeiculo.InserirNovo(veiculoFORD);
            controladorVeiculo.InserirNovo(veiculoFIAT);
            List<Veiculo> veiculos = controladorVeiculo.SelecionarTodos();
            //assert
            veiculos.Count.Should().Be(2);
            ResetarBanco();
        }
        [TestMethod]
        public void deveVerificarSeExisteVeiculoNoBanco()
        {
            //arrange
            GerarVeiculoFIAT();
            //act
            controladorVeiculo.InserirNovo(veiculoFIAT);
            var resultado = controladorVeiculo.Existe(1);
            //assert
            resultado.Should().Be(true);
            ResetarBanco();
        }
        
    }
}
