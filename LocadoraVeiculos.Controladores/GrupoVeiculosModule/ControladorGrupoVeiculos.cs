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
                         [GRUPO]
                     )
                     VALUES
                     (
                         @GRUPO
                     )";

        private const string sqlEditarGrupoVeiculos =
            @"UPDATE TBGRUPOVEICULOS
                    SET
                        [GRUPO] = @GRUPO
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
                [ID],
                [GRUPO]      
             FROM
                [TBGRUPOVEICULOS]
             WHERE 
                [ID] = @ID";

        private const string sqlSelecionarTodosGruposVeiculos =
            @"SELECT 
                [ID],       
                [GRUPO]     
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
           
            GrupoVeiculos Grupo = new GrupoVeiculos(grupo);

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
          
            return parametros;
        }
    }
}
