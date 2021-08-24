using FluentAssertions;
using LocadoraVeiculos.Controladores.ClienteModule;
using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocadoraVeiculos.Tests.ClienteModule
{
    [TestClass]
    [TestCategory("Controladores")]
    public class ControladorClienteTest
    {
        ControladorCliente controlador;

        public ControladorClienteTest()
        {
            controlador = new ControladorCliente();
            Db.Update("DELETE FROM [TBCLIENTE]; DBCC CHECKIDENT('TBCLIENTE', RESEED, 0)");
        }

        [TestMethod]
        public void DeveInserir()
        {
            //arrange
            var novoCliente = new Cliente("Lucas","Lages SC","30023254","CPF","Lucas","3222548","6.111.792","5547", DateTime.Now);

            //action
            controlador.InserirNovo(novoCliente);

            //assert
            var ClienteEncontrado = controlador.SelecionarPorId(novoCliente.Id);
            ClienteEncontrado.NomeCliente.Should().Be("Lucas");
        }

        [TestMethod]
        public void DeveAtualizar()
        {
            var cliente = new Cliente("Lucas", "Lages SC", "30023254", "CPF", "Lucas", "3222548", "6.111.792", "5547", DateTime.Now);
            controlador.InserirNovo(cliente);

            var novoCliente = new Cliente("João", "Lages SC", "30023254", "CPF", "Lucas", "3222548", "6.111.792", "5547", DateTime.Now);

            controlador.Editar(cliente.Id, novoCliente);

            Cliente ClienteSelecionado = controlador.SelecionarPorId(cliente.Id);
            ClienteSelecionado.NomeCliente.Should().Be(novoCliente.NomeCliente);
        }

        [TestMethod]
        public void DeveExcluir()
        {
            var cliente = new Cliente("Lucas", "Lages SC", "30023254", "CPF", "Lucas", "3222548", "6.111.792", "5547", DateTime.Now);
            controlador.InserirNovo(cliente);

            controlador.Excluir(cliente.Id);

            Cliente ClienteAtualizado = controlador.SelecionarPorId(cliente.Id);
            ClienteAtualizado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TaxasServicos_PorId()
        {
            var cliente = new Cliente("Lucas", "Lages SC", "30023254", "CPF", "Lucas", "3222548", "6.111.792", "5547", DateTime.Now);
            controlador.InserirNovo(cliente);

            Cliente ClientePorId = controlador.SelecionarPorId(cliente.Id);

            ClientePorId.Should().NotBeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosFuncionarios_OrdenadosPorNome()
        {
            var C1 = new Cliente("Lucas", "Lages SC", "30023254", "CPF", "Lucas", "3222548", "6.111.792", "5547", DateTime.Now);
            controlador.InserirNovo(C1);

            var C2 = new Cliente("Daniel", "Lages SC", "30023254", "CPF", "Lucas", "3222548", "6.111.792", "5547", DateTime.Now);
            controlador.InserirNovo(C2);

            var C3 = new Cliente("Pedro", "Lages SC", "30023254", "CPF", "Lucas", "3222548", "6.111.792", "5547", DateTime.Now);
            controlador.InserirNovo(C3);

            var clientes = controlador.SelecionarTodos();

            clientes.Should().HaveCount(3);
            clientes[0].NomeCliente.Should().Be("Lucas");
            clientes[1].NomeCliente.Should().Be("Daniel");
            clientes[2].NomeCliente.Should().Be("Pedro");
        }
    }
}
