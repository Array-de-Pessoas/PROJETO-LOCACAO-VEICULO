using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Dominio.CombustivelModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controladores.CombustivelModule
{
    public class ControladorCombustivel : Controlador<Combustivel>
    {
        private const string sqlInserirCombustivel =
            @"INSERT INTO [TBCOMBUSTIVEL]
                     (
                         [TIPOCOMBUSTIVEL],
                         [VALOR]
                     )
                     VALUES
                     (
                         @TIPOCOMBUSTIVEL,
                         @VALOR
                     )";

        private const string sqlEditarCombustivel =
            @"UPDATE TBCOMBUSTIVEL
                    SET
                        [TIPOCOMBUSTIVEL] = @TIPOCOMBUSTIVEL,
                        [VALOR] = @VALOR
                    WHERE 
                        ID = @ID";

        private const string sqlExcluirCombustivel =
            @"DELETE FROM [TBCOMBUSTIVEL]
                    WHERE 
                        [ID] = @ID";

        private const string sqlExisteCombustivel =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBCOMBUSTIVEL]
            WHERE 
                [ID] = @ID";

        private const string sqlSelecionarCombustivelPorId =
            @"SELECT 
                [ID],
                [TIPOCOMBUSTIVEL],
                [VALOR]
             FROM
                [TBCOMBUSTIVEL]
             WHERE 
                [ID] = @ID";

        private const string sqlSelecionarTodosCombustivel =
            @"SELECT 
                [ID],
                [TIPOCOMBUSTIVEL],
                [VALOR]
            FROM
                [TBCOMBUSTIVEL] T";

        public override string Editar(int id, Combustivel registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarCombustivel, ObtemParametrosCombustivel(registro));
            }

            return resultadoValidacao;
        }

        private Dictionary<string, object> ObtemParametrosCombustivel(Combustivel registro)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", registro.Id);
            parametros.Add("TIPOCOMBUSTIVEL", registro.TipoCombustivel);
            parametros.Add("VALOR", registro.Valor);

            return parametros;
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirCombustivel, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteCombustivel, AdicionarParametro("ID", id));
        }

        public override string InserirNovo(Combustivel registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirCombustivel, ObtemParametrosCombustivel(registro));
            }

            return resultadoValidacao;
        }

        public override Combustivel SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarCombustivelPorId, ConverterEmCombustivel, AdicionarParametro("ID", id));
        }

        private Combustivel ConverterEmCombustivel(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string tipoCombustivel = Convert.ToString(reader["TIPOCOMBUSTIVEL"]);
            decimal valor = Convert.ToDecimal(reader["VALOR"]);

            Combustivel combustivel = new Combustivel(tipoCombustivel, valor);

            combustivel.Id = id;

            return combustivel;
        }

        public override List<Combustivel> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosCombustivel, ConverterEmCombustivel);
        }
    }
}
