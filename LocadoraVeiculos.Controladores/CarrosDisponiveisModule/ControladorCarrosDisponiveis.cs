using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Dominio.CarrosDisponiveisModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controladores.CarrosDisponiveisModule
{
    public class ControladorCarrosDisponiveis : Controlador<CarrosDisponiveis>
    {
        private const string sqlSelecionarCarrosDisponiveis =
          @"SELECT 
                [ID],
                [Marca],
                [IdGrupoVeiculos],
                [Placa]
            FROM
                [TBCARROSDISPONIVEIS] T";

        private const string sqlAdicionarCarrosDisponiveis =
           @"INSERT INTO TBCARROSDISPONIVEIS(
                [Marca],
                [IdGrupoVeiculos],
                [Placa]
                )
            VALUES(
                @Marca,
                @IdGrupoVeiculos,
                @Placa)
            ";

        private const string sqlExcluirCarroDisponivel =
           @"DELETE FROM [TBCARROSDISPONIVEIS]
                    WHERE 
                        [ID] = @ID";
        public override string Editar(int id, CarrosDisponiveis registro)
        {
            throw new NotImplementedException();
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirCarroDisponivel, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            throw new NotImplementedException();
        }

        public override string InserirNovo(CarrosDisponiveis registro)
        {
            string resultadoValidacao = registro.Validar();
            if (resultadoValidacao == "VALIDO")
            {
                registro.Id = Db.Insert(sqlAdicionarCarrosDisponiveis, ObtemParametros(registro));
            }
            return resultadoValidacao;
        }

        private Dictionary<string, object> ObtemParametros(CarrosDisponiveis registro)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("Id", registro.Id);
            parametros.Add("Marca", registro.Marca);
            parametros.Add("IdGrupoVeiculos", registro.IdGrupo);
            parametros.Add("Placa", registro.Placa);

            return parametros;
        }

        public override CarrosDisponiveis SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public override List<CarrosDisponiveis> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarCarrosDisponiveis, ConverterEmCarrosDisponiveis);
        }

        private CarrosDisponiveis ConverterEmCarrosDisponiveis(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["Id"]);
            string marca = Convert.ToString(reader["Marca"]);
            int idGrupo = Convert.ToInt32(reader["IdGrupoVeiculos"]);
            string placa = Convert.ToString(reader["Placa"]);
          
            CarrosDisponiveis carros = new CarrosDisponiveis(marca, idGrupo, placa);

            carros.Id = id;

            return carros;
        }
    }
}
