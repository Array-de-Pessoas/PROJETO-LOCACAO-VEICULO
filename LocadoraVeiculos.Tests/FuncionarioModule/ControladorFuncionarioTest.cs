using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System;
using LocadoraVeiculos.Controladores.FuncionarioModule;
using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Dominio.FuncionarioModule;

namespace LocadoraVeiculos.Tests.FuncionarioModule
{
    [TestClass]
    [TestCategory("Controladores")]
    public class ControladorFuncionarioTest
    {
        ControladorFuncionario controlador = null;

        public ControladorFuncionarioTest()
        {
            controlador = new ControladorFuncionario();
            Db.Update("DELETE FROM [TBFUNCIONARIO]");
        }

        [TestMethod]
        public void DeveInserir_Funcionario()
        {
            var funcionario = new Funcionario("Maria Fernanda", "mariFer", "124321", new DateTime(2016, 10, 20, 0, 0, 0), 5000.50m);

            controlador.InserirNovo(funcionario);

            var funcionarioEncontrado = controlador.SelecionarPorId(funcionario.Id);
            funcionarioEncontrado.Should().Be(funcionario);
        }

        [TestMethod]
        public void DeveAtualizar_Funcionario()
        {
            var funcionario = new Funcionario("Maria Fernanda", "mariFer", "124321", new DateTime(2016, 10, 20, 0, 0, 0), 5000.50m);
            controlador.InserirNovo(funcionario);

            var novoFuncionario = new Funcionario("Maria Fernanda R.", "mariFer", "124321", new DateTime(2016, 10, 20, 0, 0, 0), 5000.50m);

            controlador.Editar(funcionario.Id, novoFuncionario);

            Funcionario funcionariosAtualizado = controlador.SelecionarPorId(funcionario.Id);
            funcionariosAtualizado.Should().Be(novoFuncionario);
        }

        [TestMethod]
        public void DeveExcluir_Funcionario()
        {           
            var funcionario = new Funcionario("Maria Fernanda", "mariFer", "124321", new DateTime(2016, 10, 20, 0, 0, 0), 5000.50m);
            controlador.InserirNovo(funcionario);
          
            controlador.Excluir(funcionario.Id);

            Funcionario contatoEncontrado = controlador.SelecionarPorId(funcionario.Id);
            contatoEncontrado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_Funcionario_PorId()
        {
            var funcionario = new Funcionario("Maria Fernanda", "mariFer", "124321", new DateTime(2016, 10, 20, 0, 0, 0), 5000.50m);
            controlador.InserirNovo(funcionario);

            Funcionario funcionarioEncontrado = controlador.SelecionarPorId(funcionario.Id);

            funcionarioEncontrado.Should().NotBeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosFuncionarios_OrdenadosPorNome()
        {
            var f1 = new Funcionario("Fernanda", "Fer", "124321", new DateTime(2016, 10, 20, 0, 0, 0), 5000.50m);
            controlador.InserirNovo(f1);

            var f2 = new Funcionario("Rosaria", "Ros", "237293", new DateTime(2015, 10, 20, 0, 0, 0), 6000.50m);
            controlador.InserirNovo(f2);

            var f3 = new Funcionario("Caroline", "Car", "092473", new DateTime(2019, 10, 20, 0, 0, 0), 3000.50m);
            controlador.InserirNovo(f3);

            var funcionarios = controlador.SelecionarTodos();

            funcionarios.Should().HaveCount(3);
            funcionarios[0].Nome.Should().Be("Caroline");
            funcionarios[1].Nome.Should().Be("Fernanda");
            funcionarios[2].Nome.Should().Be("Rosaria");
        }

    }
}
