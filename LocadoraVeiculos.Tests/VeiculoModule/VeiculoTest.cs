using LocadoraVeiculos.Dominio.VeiculoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Tests.VeiculoModule
{
    [TestClass]
    public class VeiculoTest
    {
        public VeiculoTest()
        {
               
        }
        //cenário 1
        [TestMethod]
        public void deveRetornarVeiculoInvalido()
        {
            //arrange
            Image foto = Image.FromFile(@"C:\Users\Cliente\Desktop\Re.jpg");
         
            Veiculo veiculoInvalido = new Veiculo("","Azul", "FIAT", 2015, "Gasolina",foto, 300, 4, 5, "G", 10000, 1);
            //act
            string resultado = veiculoInvalido.Validar();
            //assert
            Assert.AreEqual("Campo placa é obrigatório", resultado);
        }
        //cenário 2
        [TestMethod]
        public void deveRetornarVeiculoValido()
        {
            //arrange
            Image foto = Image.FromFile(@"C:\Users\Cliente\Desktop\Re.jpg");
            Veiculo veiculoInvalido = new Veiculo("ETH-3000", "Azul", "FIAT", 2015, "Gasolina",foto, 300, 4, 5, "G", 10000, 1);
            //act
            string resultado = veiculoInvalido.Validar();
            //assert
            Assert.AreEqual("VALIDO", resultado);
        }
    }
}
