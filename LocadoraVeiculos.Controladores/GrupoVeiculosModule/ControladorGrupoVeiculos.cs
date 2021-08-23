using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Dominio.GrupoVeiculosModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controladores.GrupoVeiculosModule
{
    public class ControladorGrupoVeiculos : Controlador<GrupoVeiculos>
    {
        private const string sqlInserirGrupoVeiculo =
            @"INSERT INTO [TBGRUPOVEICULOS]
                     (
                        [GRUPO],
                        [ValorDiariaPlanoDiario],
                        [ValorDiariaPlanoControlado],
                        [ValorDiariaPlanoLivre],
                        [ValorDoKMPlanoDiario],
                        [LimiteKMPlanoControlado],
                        [ValorKmExcedentePlanoControlado],

                     )
                     VALUES
                     (
                        @GRUPO,
                        @ValorDiariaPlanoDiario,
                        @ValorDiariaPlanoControlado,
                        @ValorDiariaPlanoLivre,
                        @ValorDoKMPlanoDiario,
                        @LimiteKMPlanoControlado,
                        @ValorKmExcedentePlanoControlado,
                     )";

        private const string sqlEditarGrupoVeiculos =
            @"UPDATE TBGRUPOVEICULOS
                    SET
                        [GRUPO] = @GRUPO
                        [ValorDiariaPlanoDiario] =        @ValorDiariaPlanoDiario,
                        [ValorDiariaPlanoControlado] =    @ValorDiariaPlanoControlado,
                        [ValorDiariaPlanoLivre] =         @ValorDiariaPlanoLivre,
                        [ValorDoKMPlanoDiario] =          @ValorDoKMPlanoDiario,
                        [LimiteKMPlanoControlado] =       @LimiteKMPlanoControlado,
                        [ValorKmExcedentePlanoControlado] @ValorKmExcedentePlanoControlado, 
                    WHERE 
                        ID = @ID";

        private const string sqlExcluirGrupoVeiculos =
            @"DELETE FROM [TBGRUPOVEICULOS]
                    WHERE 
                        [ID] = @ID";

        private const string sqlExisteGrupoVeiculos =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBGRUPOVEICULOS]
            WHERE 
                [ID] = @ID";

        private const string sqlSelecionarGrupoPorId =
            @"SELECT 
                *     
             FROM
                [TBGRUPOVEICULOS]
             WHERE 
                [ID] = @ID";

        private const string sqlSelecionarTodosGruposVeiculos =
            @"SELECT 
                *  
            FROM
                [TBGRUPOVEICULOS] T";

        public override string Editar(int id, GrupoVeiculos registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarGrupoVeiculos, ObtemParametrosGrupoVeiculos(registro));
            }

            return resultadoValidacao;
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirGrupoVeiculos, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteGrupoVeiculos, AdicionarParametro("ID", id));
        }

        public override string InserirNovo(GrupoVeiculos registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirGrupoVeiculo, ObtemParametrosGrupoVeiculos(registro));
            }

            return resultadoValidacao;
        }

        public override GrupoVeiculos SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarGrupoPorId, ConverterEmTarefa, AdicionarParametro("ID", id));
        }

        private GrupoVeiculos ConverterEmTarefa(IDataReader reader)
        {
            var grupo = Convert.ToString(reader["GRUPO"]);
            var valorDiariaPlanoDiario = Convert.ToDouble(reader["ValorDiariaPlanoDiario"]);
            var valorDiariaPlanoControlado = Convert.ToDouble(reader["ValorDiariaPlanoControlado"]);
            var valorDiariaPlanoLivre = Convert.ToDouble(reader["ValorDiariaPlanoLivre"]);
            var valorDoKMPlanoDiario = Convert.ToDouble(reader["ValorDoKMPlanoDiario"]);
            var limiteKMPlanoControlado = Convert.ToDouble(reader["LimiteKMPlanoControlado"]);
            var valorKmExcedentePlanoControlado = Convert.ToDouble(reader["ValorKmExcedentePlanoControlado"]);

            GrupoVeiculos Grupo = new GrupoVeiculos(grupo,valorDiariaPlanoDiario, valorDiariaPlanoControlado, valorDiariaPlanoLivre, valorDoKMPlanoDiario,limiteKMPlanoControlado,valorKmExcedentePlanoControlado);

            Grupo.Id = Convert.ToInt32(reader["ID"]);

            return Grupo;
        }

        public override List<GrupoVeiculos> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosGruposVeiculos, ConverterEmTarefa);
        }

        private Dictionary<string, object> ObtemParametrosGrupoVeiculos(GrupoVeiculos registro)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", registro.Id);
            parametros.Add("GRUPO", registro.Grupo);
            parametros.Add("ValorDiariaPlanoDiario", registro.ValorDiariaPlanoDiario);
            parametros.Add("ValorDiariaPlanoControlado", registro.ValorDiariaPlanoControlado);
            parametros.Add("ValorDiariaPlanoLivre", registro.ValorDiariaPlanoLivre);
            parametros.Add("ValorDoKMPlanoDiario", registro.ValorDoKMPlanoDiario);
            parametros.Add("LimiteKMPlanoControlado", registro.LimiteKMPlanoControlado);
            parametros.Add("ValorKmExcedentePlanoControlado", registro.ValorKmExcedentePlanoControlado);
          
            return parametros;
        }
    }
}
