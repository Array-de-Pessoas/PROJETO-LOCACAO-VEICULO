using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Dominio.CarrosAlugadosModule;
using LocadoraVeiculos.Dominio.LocacaoModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controladores.CarrosAlugadosModule
{
    public class ControladorCarrosAlugados : Controlador<CarrosAlugados>
    {
        private const string sqlCarrosAlugados =
             @"INSERT INTO [TBCARROSALUGADOS]
                     (
                        [Id_Cliente],
                        [Id_Veiculo]
                     )
                     VALUES
                     (
                        @Id_Cliente,
                        @Id_Veiculo
                     )";

        private const string sqlSelecionarCarrosAlugados =
            @"SELECT 
                [ID],
                [Id_Cliente],
                [Id_Veiculo]
            FROM
                [TBCARROSALUGADOS] T";

        public override string Editar(int id, CarrosAlugados registro)
        {
            throw new NotImplementedException();
        }

        public override bool Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Existe(int id)
        {
            throw new NotImplementedException();
        }

        public override string InserirNovo(CarrosAlugados registro)
        {
            string resultadoValidacao = "VALIDO";

            if (resultadoValidacao == "VALIDO")
            {
                registro.Id = Db.Insert(sqlCarrosAlugados, ObtemParametros(registro));
            }

            return resultadoValidacao;
        }

        private Dictionary<string, object> ObtemParametros(CarrosAlugados registro)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("Id", registro.Id);
            parametros.Add("Id_Cliente", registro.IdCliente);
            parametros.Add("Id_Veiculo", registro.IdVeiculo);
           
            return parametros;
        }

        public override CarrosAlugados SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public override List<CarrosAlugados> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarCarrosAlugados, ConverterEmCarrosAlugados);
        }

        private CarrosAlugados ConverterEmCarrosAlugados(IDataReader reader)
        {
            var id_cliente = Convert.ToInt32(reader["Id_Cliente"]);
            var id_veiculo = Convert.ToInt32(reader["Id_Veiculo"]);
           
            CarrosAlugados carros = new CarrosAlugados(id_cliente, id_veiculo);

            carros.Id = Convert.ToInt32(reader["Id"]);

            return carros;
        }
    }
}
