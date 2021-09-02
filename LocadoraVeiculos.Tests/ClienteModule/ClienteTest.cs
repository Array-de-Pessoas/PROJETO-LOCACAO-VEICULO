using FluentAssertions;
using LocadoraVeiculos.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocadoraVeiculos.Tests.ClienteModule
{
    [TestClass]
    [TestCategory("Dominio")]
    public class ClienteTest
    {
        [TestMethod]
        public void DeveValidarTodosOsCampos()
        {
            var cliente = new Cliente("Lucas", "Lages SC", "30023254", "juca@gmail.com", "CPF", "Lucas", "3222548", "6.111.792", "5547", DateTime.Now);

            var resultadoValidacao = cliente.Validar();

            resultadoValidacao.Should().Be("ESTA_VALIDO");
        }

        [TestMethod]
        public void DeveValidarNomeCliente()
        {
            var cliente = new Cliente("", "Lages SC", "30023254", "juca@gmail.com", "CPF", "Lucas", "3222548", "6.111.792", "5547", DateTime.Now);

            var resultadoValidacao = cliente.Validar();

            resultadoValidacao.Should().Be("                                                     O campo nome do cliente não pode estar vazio");
        }

        [TestMethod]
        public void DeveValidarEndereco()
        {
            var cliente = new Cliente("Lucas", "", "30023254", "juca@gmail.com", "CPF", "Lucas", "3222548", "6.111.792", "5547", DateTime.Now);

            var resultadoValidacao = cliente.Validar();

            resultadoValidacao.Should().Be("                                                     O campo endereço não pode estar vazio");
        }

        [TestMethod]
        public void DeveValidarTelefone()
        {
            var cliente = new Cliente("Lucas", "Lages SC", "", "juca@gmail.com", "CPF", "Lucas", "3222548", "6.111.792", "5547", DateTime.Now);

            var resultadoValidacao = cliente.Validar();

            resultadoValidacao.Should().Be("                                                     O campo telefone não pode estar vazio");
        }

        [TestMethod]
        public void DeveValidarCPFouCNPJ()
        {
            var cliente = new Cliente("Lucas", "Lages SC", "45454554", "juca@gmail.com", "",  "Lucas", "3222548", "6.111.792", "5547", DateTime.Now);

            var resultadoValidacao = cliente.Validar();

            resultadoValidacao.Should().Be("                                                     O campo tipo de identidade não pode estar vazio");
        }

        [TestMethod]
        public void DeveValidarNomeCondutor()
        {
            var cliente = new Cliente("Lucas", "Lages SC", "45454554", "juca@gmail.com", "CPF", "", "3222548", "6.111.792", "5547", DateTime.Now);

            var resultadoValidacao = cliente.Validar();

            resultadoValidacao.Should().Be("                                                     O campo nome do condutor não pode estar vazio");
        }

        [TestMethod]
        public void DeveValidarCPFcondutor()
        {
            var cliente = new Cliente("Lucas", "Lages SC", "45454554", "juca@gmail.com", "CPF", "Lucas", "", "6.111.792", "5547", DateTime.Now);

            var resultadoValidacao = cliente.Validar();

            resultadoValidacao.Should().Be("                                                     O campo CPF do condutor não pode estar vazio");
        }

        [TestMethod]
        public void DeveValidarRG()
        {
            var cliente = new Cliente("Lucas", "Lages SC", "45454554", "juca@gmail.com", "CPF", "Lucas", "554874554", "", "5547", DateTime.Now);

            var resultadoValidacao = cliente.Validar();

            resultadoValidacao.Should().Be("                                                     O campo RG não pode estar vazio");
        }

        [TestMethod]
        public void DeveValidarCNH()
        {
            var cliente = new Cliente("Lucas", "Lages SC", "45454554", "juca@gmail.com", "CPF", "Lucas", "554874554", "554877", "", DateTime.Now);

            var resultadoValidacao = cliente.Validar();

            resultadoValidacao.Should().Be("                                                     O campo CNH não pode estar vazio");
        }
    }
}
