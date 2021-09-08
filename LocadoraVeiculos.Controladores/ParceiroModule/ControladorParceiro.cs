using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Dominio.ParceiroModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controladores.ParceiroModule
{
    public class ControladorParceiro : Controlador<Parceiro>
    {
        private const string sqlInserirParceiro =
            @"INSERT INTO [TBPARCEIRO]
                     (
                         [NOMEPARCEIRO]
                     )
                     VALUES
                     (
                         @NOMEPARCEIRO
                     )";

        private const string sqlEditarParceiro =
            @"UPDATE TBPARCEIRO
                    SET
                        [NOMEPARCEIRO] = @NOMEPARCEIRO
                    WHERE 
                        [ID] = @ID";

        private const string sqlExcluirParceiro =
            @"DELETE FROM [TBPARCEIRO]
                    WHERE 
                        [ID] = @ID";

        private const string sqlExisteParceiro =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBPARCEIRO]
            WHERE 
                [ID] = @ID";

        private const string sqlSelecionarParceiroPorId =
            @"SELECT 
                [ID],
                [NOMEPARCEIRO]
             FROM
                [TBPARCEIRO]
             WHERE 
                [ID] = @ID";

        private const string sqlSelecionarTodosParceiro =
            @"SELECT 
                [ID],
                [NOMEPARCEIRO]
            FROM
                [TBPARCEIRO] T";

        public override string Editar(int id, Parceiro registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarParceiro, ObtemParametrosParceiro(registro));
            }

            return resultadoValidacao;
        }

        private Dictionary<string, object> ObtemParametrosParceiro(Parceiro registro)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", registro.Id);
            parametros.Add("NOMEPARCEIRO", registro.NomeParceiro);

            return parametros;
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirParceiro, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteParceiro, AdicionarParametro("ID", id));
        }

        public override string InserirNovo(Parceiro registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirParceiro, ObtemParametrosParceiro(registro));
            }

            return resultadoValidacao;
        }

        public override Parceiro SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarParceiroPorId, ConverterEmParceiro, AdicionarParametro("ID", id));
        }

        private Parceiro ConverterEmParceiro(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string NomeParceiro = Convert.ToString(reader["NOMEPARCEIRO"]);
     
            Parceiro parceiro = new Parceiro(NomeParceiro);

            parceiro.Id = id;

            return parceiro;
        }

        public override List<Parceiro> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosParceiro, ConverterEmParceiro);
        }
    }
}
