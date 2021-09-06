using FluentAssertions;
using LocadoraVeiculos.Dominio.CupomModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocadoraVeiculos.Tests.CupomModule
{
    [TestClass]
    [TestCategory("Dominio")]
    public class CupomTest
    {
        [TestMethod]
        public void DeveValidarTodosOsCampos()
        {
            var novoCupom = new Cupom("GHTRS", "Desconto", 5000.50m, 5000.50m, "Lucas", DateTime.Now, 1);

            var resultadoValidacao = novoCupom.Validar();

            resultadoValidacao.Should().Be("ESTA_VALIDO");
        }

        [TestMethod]
        public void DeveValidarCodigo()
        {
            var novoCupom = new Cupom("", "Desconto", 5000.50m, 5000.50m, "Lucas", DateTime.Now, 1);

            var resultadoValidacao = novoCupom.Validar();

            resultadoValidacao.Should().Be("                                                     O campo código não pode estar vazio");
        }

        [TestMethod]
        public void DeveValidarTipo()
        {
            var novoCupom = new Cupom("GHTRS", "", 5000.50m, 5000.50m, "Lucas", DateTime.Now, 1);

            var resultadoValidacao = novoCupom.Validar();

            resultadoValidacao.Should().Be("                                                     O campo tipo não pode estar vazio");
        }

        [TestMethod]
        public void DeveValidarValor()
        {
            var novoCupom = new Cupom("GHTRS", "Desconto", 0, 5000.50m, "Lucas", DateTime.Now, 1);

            var resultadoValidacao = novoCupom.Validar();

            resultadoValidacao.Should().Be("                                                     O campo valor não pode ser 0");
        }

        [TestMethod]
        public void DeveValidarValorMinimo()
        {
            var novoCupom = new Cupom("GHTRS", "Desconto", 5000.50m, 0, "Lucas", DateTime.Now, 1);

            var resultadoValidacao = novoCupom.Validar();

            resultadoValidacao.Should().Be("                                                     O campo valor mínimo não pode ser 0");
        }
    }
}
