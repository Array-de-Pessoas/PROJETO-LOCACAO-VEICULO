using LocadoraVeiculos.Controladores.VeiculoModule;
using LocadoraVeiculos.Dominio.VeiculoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Tests.VeiculoModule
{
    [TestClass]
    public class ControladorVeiculoTest
    {
        ControladorVeiculo controladorVeiculo;
        Veiculo veiculo;

        public ControladorVeiculoTest()
        {
            DeletaTabela();
            controladorVeiculo = new ControladorVeiculo();
        }

        public void CriarVeiculoFiat()
        {
            veiculo = new Veiculo("ETH-3000", "Azul", "FIAT", 2015, "Gasolina", 300, 4, 5, "G", 10000, 1);
        }

        public void DeletaTabela()
        {
            SqlConnection con;
            SqlCommand comando;
            string enderecoDeConexao = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DB_ControleDeTarefa;Integrated Security=True;Pooling=False";
            //abre conexao
            con = new SqlConnection(enderecoDeConexao);
            con.Open();
            //config comando
            comando = new SqlCommand();
            comando.Connection = con;
            string sqlReseta = @"DELETE FROM TB_Compromisso; DBCC CHECKIDENT('TB_Compromisso', RESEED, 0)";

            comando.CommandText = sqlReseta;
            comando.ExecuteNonQuery();
            con.Close();
        }

        [TestMethod]
        public void deveCadastrarVeiculoNoBanco()
        {
            //arrange
            CriarVeiculoFiat();
            //act
            controladorVeiculo.InserirNovo(veiculo);
            //assert
            Assert.AreEqual(veiculo, controladorVeiculo.SelecionarPorId(0));
        }
    }
}
