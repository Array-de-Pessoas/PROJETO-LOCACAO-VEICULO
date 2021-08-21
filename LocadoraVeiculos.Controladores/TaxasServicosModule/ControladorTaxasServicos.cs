using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Dominio.TaxasServicosModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controladores.TaxasServicosModule
{
    public class ControladorTaxasServicos : Controlador<TaxasServicos>
    {
        private const string sqlInserirTaxasServicos =
            @"INSERT INTO [TBTAXA]
                     (
                         [TIPOTAXA],
                         [NOME],
                         [VALOR]
                     )
                     VALUES
                     (
                         @TIPOTAXA,
                         @NOME,
                         @VALOR
                     )";

        private const string sqlEditarTaxasServicos =
            @"UPDATE TBTAXA
                    SET
                        [TIPOTAXA] = @TIPOTAXA,
                        [NOME] = @NOME,
                        [VALOR] = @VALOR
                    WHERE 
                        ID = @ID";

        private const string sqlExcluirTaxasServicos =
            @"DELETE FROM [TBTAXA]
                    WHERE 
                        [ID] = @ID";

        private const string sqlExisteTaxasServicos =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBTAXAS]
            WHERE 
                [ID] = @ID";

        private const string sqlSelecionarTaxasServicosPorId =
            @"SELECT 
                [ID],
                [TIPOTAXA],
                [NOME],
                [VALOR]
             FROM
                [TBTAXA]
             WHERE 
                [ID] = @ID";

        private const string sqlSelecionarTodosTaxasServicos =
            @"SELECT 
                [ID],
                [TIPOTAXA],
                [NOME],
                [VALOR]
            FROM
                [TBTAXA] T";

        public override string Editar(int id, TaxasServicos registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarTaxasServicos, ObtemParametrosGrupoVeiculos(registro));
            }

            return resultadoValidacao;
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirTaxasServicos, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteTaxasServicos, AdicionarParametro("ID", id));
        }

        public override string InserirNovo(TaxasServicos registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirTaxasServicos, ObtemParametrosGrupoVeiculos(registro));
            }

            return resultadoValidacao;
        }

        private Dictionary<string, object> ObtemParametrosGrupoVeiculos(TaxasServicos taxasServicos)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", taxasServicos.Id);
            parametros.Add("TIPOTAXA", taxasServicos.TipoTaxa);
            parametros.Add("NOME", taxasServicos.Nome);
            parametros.Add("VALOR", taxasServicos.Valor);

            return parametros;
        }

        public override TaxasServicos SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarTaxasServicosPorId, ConverterEmTaxasServicos, AdicionarParametro("ID", id));
        }

        private TaxasServicos ConverterEmTaxasServicos(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string tipoTaxas = Convert.ToString(reader["TIPOTAXA"]);
            string nome = Convert.ToString(reader["NOME"]);
            decimal valor = Convert.ToDecimal(reader["VALOR"]);

            TaxasServicos taxasServicos = new TaxasServicos(tipoTaxas,nome,valor);

            taxasServicos.Id = id;

            return taxasServicos;
        }

        public override List<TaxasServicos> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosTaxasServicos, ConverterEmTaxasServicos);
        }
    }
}
