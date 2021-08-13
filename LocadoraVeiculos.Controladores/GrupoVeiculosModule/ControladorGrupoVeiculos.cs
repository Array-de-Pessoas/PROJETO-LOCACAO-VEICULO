using eAgenda.Controladores.Shared;
using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Dominio.GrupoVeiculosModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controladores.GrupoVeiculosModule
{
    public class ControladorGrupoVeiculos : Controlador<GrupoVeiculos>
    {
        private const string sqlInserirGrupoVeiculo =
            @"INSERT INTO TBGRUPOVEICULOS
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
            @"DELETE 
	                FROM
                        TBGRUPOVEICULOS
                    WHERE 
                        ID = @ID";

        private const string sqlExisteGrupoVeiculos =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBGRUPOVEICULOS]
            WHERE 
                [ID] = @ID";

        public override string Editar(int id, GrupoVeiculos registro)
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
            throw new NotImplementedException();
        }

        public override List<GrupoVeiculos> SelecionarTodos()
        {
            throw new NotImplementedException();
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
