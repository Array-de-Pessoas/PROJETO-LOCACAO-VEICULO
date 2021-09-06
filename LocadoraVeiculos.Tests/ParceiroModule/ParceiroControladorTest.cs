using FluentAssertions;
using LocadoraVeiculos.Controladores.ParceiroModule;
using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Dominio.ParceiroModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocadoraVeiculos.Tests.ParceiroModule
{
  
    [TestClass]
    [TestCategory("Controladores")]
    public class ParceiroControladorTest
    {
        ControladorParceiro controlador;

        public ParceiroControladorTest()
        {
            controlador = new ControladorParceiro();
            Db.Update("DELETE FROM [TBPARCEIRO]; DBCC CHECKIDENT('TBPARCEIRO', RESEED, 0)");
        }

        [TestMethod]
        public void DeveInserir()
        {
            //arrange
            var novoParceiro = new Parceiro("Diesel");

            //action
            controlador.InserirNovo(novoParceiro);

            //assert
            var ParceiroEncontrado = controlador.SelecionarPorId(novoParceiro.Id);
            ParceiroEncontrado.NomeParceiro.Should().Be(novoParceiro.NomeParceiro);
        }

        [TestMethod]
        public void DeveExcluir()
        {
            
            var novoParceiro = new Parceiro("Lucas");
            controlador.InserirNovo(novoParceiro);
           
         
            controlador.Excluir(novoParceiro.Id);

            Parceiro ParceiroExcluido = controlador.SelecionarPorId(novoParceiro.Id);
            ParceiroExcluido.Should().BeNull();
        }

        [TestMethod]
        public void DeveAtualizar()
        {

            var parceiro = new Parceiro("Lucas");
            controlador.InserirNovo(parceiro);

            var Novoparceiro = new Parceiro("João");
            controlador.Editar(parceiro.Id, Novoparceiro);


            Parceiro ParceiroAtualizado = controlador.SelecionarPorId(parceiro.Id);
            ParceiroAtualizado.Should().Be(Novoparceiro);
        }

        [TestMethod]
        public void DeveSelecionarTodosPorID()
        {

            var parceiro = new Parceiro("Lucas");
            controlador.InserirNovo(parceiro);

            Parceiro parceiroSelecionadoId = controlador.SelecionarPorId(parceiro.Id);

            parceiroSelecionadoId.Should().NotBeNull();
        }

        [TestMethod]
        public void DeveSelecionarTodosPorNome()
        {

            var P1 = new Parceiro("Lucas");
            controlador.InserirNovo(P1);

            var P2 = new Parceiro("Lucas");
            controlador.InserirNovo(P2);

            var P3 = new Parceiro("Lucas");
            controlador.InserirNovo(P3);

            var parceiros = controlador.SelecionarTodos();

            parceiros.Should().HaveCount(3);
            parceiros[0].NomeParceiro.Should().Be("Lucas");
            parceiros[1].NomeParceiro.Should().Be("Lucas");
            parceiros[2].NomeParceiro.Should().Be("Lucas");
        }
    }
}
