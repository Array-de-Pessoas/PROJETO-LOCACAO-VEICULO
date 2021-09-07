using LocadoraVeiculos.Dominio.LocacaoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Tests.LocacaoModule
{
    [TestClass]
    public class LocacaoTest
    {
        //cenário 1
        [TestMethod]
        public void deveRetornarVeiculoInvalido()
        {
            //arrange
            Locacao locacaoInvalida = new Locacao(0, 1, 1, 1,1000, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.AddDays(1).Day), "LIVRE", DateTime.Now.Date, 1);
            //act
            string resultado = locacaoInvalida.Validar();
           // assert
            Assert.AreEqual("O campo Cliente é obrigatório", resultado);
        }
        //cenário 2
        [TestMethod]
        public void deveRetornarVeiculoValido()
        {
            //arrange    
            Locacao locacaoInvalida = new Locacao(1, 1, 1, 1, 1000, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.AddDays(1).Day), "LIVRE",DateTime.Now.Date, 1);
            //act
            string resultado = locacaoInvalida.Validar();
            //assert
            Assert.AreEqual("ESTA_VALIDO", resultado);
        }
    }
}
