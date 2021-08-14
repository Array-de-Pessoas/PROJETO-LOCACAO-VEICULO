using eAgenda.Controladores.Shared;
using LocadoraVeiculos.Controladores.VeiculoModule;
using LocadoraVeiculos.Dominio.VeiculoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LocadoraVeiculos.Tests.VeiculoModule
{
    [TestClass]
    public partial class ControladorVeiculoTest
    {
        ControladorVeiculo controladorVeiculo;

        public ControladorVeiculoTest()
        {
            ResetaTabela();
        
            controladorVeiculo = new ControladorVeiculo();
        }

        public void ResetaTabela()
        {
            SqlConnection con;
            SqlCommand comando;
            string enderecoDeConexao = @"Data Source=(LocalDb)\mssqlLocalDB;Initial Catalog=DBLocalVeiculo;Integrated Security=True;Pooling=False";
            //abre conexao
            con = new SqlConnection(enderecoDeConexao);
            con.Open();
            //config comando
            comando = new SqlCommand();
            comando.Connection = con;
            string sqlReseta = @"DELETE FROM TBVEICULO; DBCC CHECKIDENT('TBVEICULO', RESEED, 0)";

            comando.CommandText = sqlReseta;
            comando.ExecuteNonQuery();
            con.Close();
        }

        [TestMethod]
        public void deveCadastrarVeiculoNoBanco()
        {
            //arrange
            //Image foto = Image.FromFile(@"C:\Users\Cliente\Desktop\Re.jpg");
          
            var veiculo = new Veiculo("ETH-3000", "Azul", "FIAT", 2015, "Gasolina", null, 300, 4, 5, "G", 10000, 1);
            //act
            controladorVeiculo.InserirNovo(veiculo);
            //assert
            var veiculoEncontrado = controladorVeiculo.SelecionarPorId(veiculo.Id);
            Assert.AreEqual(veiculo.placa, veiculoEncontrado.placa);

        }
        [TestMethod]
        public void deveEditarVeiculoNoBanco()
        {
            //arrange
            Image foto = Image.FromFile(@"C:\Users\Cliente\Desktop\Re.jpg");

            var veiculo = new Veiculo("ETH-3000", "Azul", "FIAT", 2015, "Gasolina",null, 300, 4, 5, "G", 10000, 1);
            var veiculoEditado = new Veiculo("ADA-1000", "Preto", "Ford", 2015, "Gasolina",null, 300, 4, 5, "G", 10000, 1);
            //act
            controladorVeiculo.InserirNovo(veiculo);
            controladorVeiculo.Editar(1,veiculoEditado);
            //assert
            var veiculoEncontrado = controladorVeiculo.SelecionarPorId(1);
            Assert.AreEqual(veiculoEditado.placa, veiculoEncontrado.placa);
          

        }
        [TestMethod]
        public void deveExcluirVeiculoNoBanco()
        {
            //arrange
            Image foto = Image.FromFile(@"C:\Users\Cliente\Desktop\Re.jpg");

            var veiculo = new Veiculo("ETH-3000", "Azul", "FIAT", 2015, "Gasolina",null, 300, 4, 5, "G", 10000, 1);
         
            //act
            controladorVeiculo.InserirNovo(veiculo);
            controladorVeiculo.Excluir(1);
            //assert
            var veiculoEncontrado = controladorVeiculo.SelecionarPorId(1);
            Assert.IsNull(veiculoEncontrado);
        }
        [TestMethod]
        public void deveSelecionarTodosVeiculosDoBanco()
        {
            //arrange
            Image foto = Image.FromFile(@"C:\Users\Cliente\Desktop\Re.jpg");

            var veiculo = new Veiculo("ETH-3000", "Azul", "FIAT", 2015, "Gasolina",null, 300, 4, 5, "G", 10000, 1);
            var veiculo2 = new Veiculo("ADA-1000", "Preto", "Ford", 2015, "Gasolina",null, 300, 4, 5, "G", 10000, 1);
            //act
            controladorVeiculo.InserirNovo(veiculo);
            controladorVeiculo.InserirNovo(veiculo2);
            List<Veiculo> veiculos = controladorVeiculo.SelecionarTodos();
            //assert
            veiculos.Count.Should().Be(2);
        }
        [TestMethod]
        public void deveVerificarSeExisteVeiculoNoBanco()
        {
            //arrange
            Image foto = Image.FromFile(@"C:\Users\Cliente\Desktop\Re.jpg");

            var veiculo = new Veiculo("ETH-3000", "Azul", "FIAT", 2015, "Gasolina",null, 300, 4, 5, "G", 10000, 1);       
            //act
            controladorVeiculo.InserirNovo(veiculo);
            var resultado = controladorVeiculo.Existe(1);
            //assert
            resultado.Should().Be(true);
        }

    }
}
