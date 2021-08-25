using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Dominio.SegurosModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controladores.SegurosModule
{
    public class ControladorSeguros : Controlador<Seguros>
    {
        private const string sqlInserirSeguros =
            @"INSERT INTO [TBSEGUROS]
                     (
                         [TIPOSEGURO],
                         [VALOR]
                     )
                     VALUES
                     (
                         @TIPOSEGURO,
                         @VALOR
                     )";

        private const string sqlEditarSeguros =
            @"UPDATE TBSEGUROS
                    SET
                        [TIPOSEGURO] = @TIPOSEGURO,
                        [VALOR] = @VALOR
                    WHERE 
                        ID = @ID";

        private const string sqlExcluirSeguros =
            @"DELETE FROM [TBSEGUROS]
                    WHERE 
                        [ID] = @ID";

        private const string sqlExisteSeguros =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBSEGUROS]
            WHERE 
                [ID] = @ID";

        private const string sqlSelecionarSegurosPorId =
            @"SELECT 
                [ID],
                [TIPOSEGURO],
                [VALOR]
             FROM
                [TBSEGUROS]
             WHERE 
                [ID] = @ID";

        private const string sqlSelecionarTodosSeguros =
            @"SELECT 
                [ID],
                [TIPOSEGURO],
                [VALOR]
            FROM
                [TBSEGUROS] T";

        public override string Editar(int id, Seguros registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarSeguros, ObtemParametrosSeguros(registro));
            }

            return resultadoValidacao;
        }

        private Dictionary<string, object> ObtemParametrosSeguros(Seguros registro)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", registro.Id);
            parametros.Add("TIPOSEGURO", registro.TipoSeguro);
            parametros.Add("VALOR", registro.Valor);

            return parametros;
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirSeguros, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteSeguros, AdicionarParametro("ID", id));
        }

        public override string InserirNovo(Seguros registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirSeguros, ObtemParametrosSeguros(registro));
            }

            return resultadoValidacao;
        }

        public override Seguros SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarSegurosPorId, ConverterEmSeguros, AdicionarParametro("ID", id));
        }

        private Seguros ConverterEmSeguros(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string tipoSeguros = Convert.ToString(reader["TIPOSEGURO"]);
            decimal valor = Convert.ToDecimal(reader["VALOR"]);

            Seguros seguros = new Seguros(tipoSeguros, valor);

            seguros.Id = id;

            return seguros;
        }

        public override List<Seguros> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosSeguros, ConverterEmSeguros);
        }
    }
}
