using FluentAssertions;
using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Controladores.TaxasServicosModule;
using LocadoraVeiculos.Dominio.TaxasServicosModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraVeiculos.Tests.TaxasServicosModule
{
    [TestClass]
    [TestCategory("Controladores")]
    public class ControladorTaxasServicosTest
    {
        ControladorTaxasServicos controlador;

        public ControladorTaxasServicosTest()
        {
            controlador = new ControladorTaxasServicos();
            Db.Update("DELETE FROM [TBTAXA]; DBCC CHECKIDENT('TBTAXA', RESEED, 0)");
        }
            
        [TestMethod]
        public void DeveInserir()
        {
            //arrange
            var novaTaxaServico = new TaxasServicos("Fixa","Lavar o carro", 5000.50m);

            //action
            controlador.InserirNovo(novaTaxaServico);

            //assert
            var TaxaEncontrada = controlador.SelecionarPorId(novaTaxaServico.Id);
            TaxaEncontrada.Should().Be(novaTaxaServico);
        }

        [TestMethod] 
        public void DeveAtualizar()
        {
            var taxasServicos = new TaxasServicos("Diária", "Melhor opção", 5000.50m);
            controlador.InserirNovo(taxasServicos);

            var NovataxasServicos = new TaxasServicos("Fixa", "Melhor opção", 5000.50m);

            controlador.Editar(taxasServicos.Id, NovataxasServicos);

            TaxasServicos TaxasServicosAtualizado = controlador.SelecionarPorId(taxasServicos.Id);
            TaxasServicosAtualizado.Should().Be(NovataxasServicos);
        }

        [TestMethod]
        public void DeveExcluir()
        {
            var taxasServicos = new TaxasServicos("Diária", "Melhor opção", 5000.50m);
            controlador.InserirNovo(taxasServicos);

            controlador.Excluir(taxasServicos.Id);

            TaxasServicos TaxasServicosAtualizado = controlador.SelecionarPorId(taxasServicos.Id);
            TaxasServicosAtualizado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TaxasServicos_PorId()
        {
            var taxasServicos = new TaxasServicos("Diária", "Melhor opção", 5000.50m);
            controlador.InserirNovo(taxasServicos);

            TaxasServicos TaxasServicosAtualizado = controlador.SelecionarPorId(taxasServicos.Id);

            TaxasServicosAtualizado.Should().NotBeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosFuncionarios_OrdenadosPorNome()
        {
            var TF1 = new TaxasServicos("Diária", "Cadeirinha", 5000.50m);
            controlador.InserirNovo(TF1);

            var TF2 = new TaxasServicos("Novo", "Gps", 5000.50m);
            controlador.InserirNovo(TF2);

            var TF3 = new TaxasServicos("Fixa", "Lavar o carro", 5000.50m);
            controlador.InserirNovo(TF3);

            var taxas = controlador.SelecionarTodos();

            taxas.Should().HaveCount(3);
            taxas[0].Nome.Should().Be("Cadeirinha");
            taxas[1].Nome.Should().Be("Gps");
            taxas[2].Nome.Should().Be("Lavar o carro");
        }
    }
}
