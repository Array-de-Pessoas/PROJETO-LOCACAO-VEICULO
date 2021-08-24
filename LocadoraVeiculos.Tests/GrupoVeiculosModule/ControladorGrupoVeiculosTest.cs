using Microsoft.VisualStudio.TestTools.UnitTesting;
using LocadoraVeiculos.Controladores.GrupoVeiculosModule;
using LocadoraVeiculos.Dominio.GrupoVeiculosModule;
using FluentAssertions;
using System;
using LocadoraVeiculos.Controladores.Shared;
using System.Collections.Generic;

namespace LocadoraVeiculos.Tests.GrupoVeiculosModule
{
    [TestClass]
    [TestCategory("Controladores")]
    public class ControladorGrupoVeiculosTest
    {
        ControladorGrupoVeiculos controlador;

        public ControladorGrupoVeiculosTest()
        {
            controlador = new ControladorGrupoVeiculos();
            Db.Update("DELETE FROM [TBVEICULO]; DBCC CHECKIDENT('TBVEICULO', RESEED, 0)");
            Db.Update("DELETE FROM [TBGRUPOVEICULOS]; DBCC CHECKIDENT('TBVEICULO', RESEED, 0)");
        }

        [TestMethod]
        public void DeveInserir_GrupoVeiculos()
        {
            //arrange
            var novoGrupo = new GrupoVeiculos("SUV", 100,100,100,100,100,100);

            //action
            controlador.InserirNovo(novoGrupo);

            //assert
            var GrupoEncontrado = controlador.SelecionarPorId(novoGrupo.Id);
            GrupoEncontrado.Grupo.Should().Be(novoGrupo.Grupo);
        }

        [TestMethod]
        public void DeveAtualizar_GrupoVeiculos()
        {
            var grupoVeiculos = new GrupoVeiculos("SUV AD", 100, 100, 100, 100, 100, 100);
            controlador.InserirNovo(grupoVeiculos);

            var novogrupoVeiculos = new GrupoVeiculos("Suv", 100,100,100,100,100,100);

            controlador.Editar(grupoVeiculos.Id, novogrupoVeiculos);

            GrupoVeiculos funcionariosAtualizado = controlador.SelecionarPorId(grupoVeiculos.Id);
            funcionariosAtualizado.Should().Be(novogrupoVeiculos);
        }

        [TestMethod]
        public void DeveExcluir_GrupoVeiculos()
        {
            var grupoVeiculos = new GrupoVeiculos("SUV", 100, 100, 100, 100, 100, 100);
            controlador.InserirNovo(grupoVeiculos);

            controlador.Excluir(grupoVeiculos.Id);

            List<GrupoVeiculos> grupoveiculos = controlador.SelecionarTodos();
            grupoveiculos.Count.Should().Be(0);
        }

        [TestMethod]
        public void DeveSelecionar_GrupoVeiculos_PorId()
        {
            var grupoVeiculos = new GrupoVeiculos("SUV", 100, 100, 100, 100, 100, 100);
            controlador.InserirNovo(grupoVeiculos);

            GrupoVeiculos funcionarioEncontrado = controlador.SelecionarPorId(grupoVeiculos.Id);

            funcionarioEncontrado.Should().NotBeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosGrupoVeiculos()
        {
            var gf1 = new GrupoVeiculos("SUV A", 100, 100, 100, 100, 100, 100);
            controlador.InserirNovo(gf1);

            var gf2 = new GrupoVeiculos("SUV B", 100, 100, 100, 100, 100, 100);
            controlador.InserirNovo(gf2);

            var gf3 = new GrupoVeiculos("SUV C", 100, 100, 100, 100, 100, 100);
            controlador.InserirNovo(gf3);

            var grupoVeiculos = controlador.SelecionarTodos();

            grupoVeiculos.Should().HaveCount(3);
            grupoVeiculos[0].Grupo.Should().Be("SUV A");
            grupoVeiculos[1].Grupo.Should().Be("SUV B");
            grupoVeiculos[2].Grupo.Should().Be("SUV C");
        }
    }
}
