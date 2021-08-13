using LocadoraVeiculos.Controladores.VeiculoModule;
using LocadoraVeiculos.Dominio.VeiculoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            var veiculo = new Veiculo("ETH-3000", "Azul", "FIAT", 2015, "Gasolina", 300, 4, 5, "G", 10000, 1);
            //act
            ControladorVeiculo controladorVeiculo = new ControladorVeiculo();
            controladorVe.InserirNovo(veiculo);
            //assert
            var veiculoEncontrado = controladorVeiculo.SelecionarPorId(veiculo.id);
            veiculoEncontrado.Should().Be(veiculo);

        }
    }
}
