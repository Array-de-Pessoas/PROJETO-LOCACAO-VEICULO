using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Dominio.LocacaoModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controladores.LocacaoModule
{
    public class ControladorLocacao : Controlador<Locacao>
    {
        #region queries sql
        private const string sqlInserirlocacaoVeiculo =
           @"INSERT INTO [TBLOCACAO]
                     (
                        [id_cliente],
                        [id_veiculo],
                        [id_taxa],
                        [dataLocacao],
                        [dataDevolucao],
                        [preco]             
                     )
                     VALUES
                     (
                        @id_cliente,
                        @id_veiculo,
                        @id_taxa,
                        @dataLocacao,
                        @dataDevolucao,
                        @preco                   
                     )";

        private const string sqlEditarLocacao =
            @"UPDATE [TBLOCACAO]
                    SET
                        [id_cliente] = @id_cliente,
                        [id_veiculo] =        @id_veiculo,
                        [id_taxa] =    @id_taxa,
                        [dataLocacao] =         @dataLocacao,
                        [dataDevolucao] =          @dataDevolucao,
                        [preco] =       @preco
                       
                    WHERE 
                        Id = @Id";

        private const string sqlExcluirLocacao =
            @"DELETE FROM [TBLOCACAO]
                    WHERE 
                        [Id] = @Id";

        private const string sqlExisteLocacao =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBLOCACAO]
            WHERE 
                [Id] = @Id";

        private const string sqlSelecionarlocacaoPorId =
            @"SELECT 
                *     
             FROM
                [TBLOCACAO]
             WHERE 
                [Id] = @Id";

        private const string sqlSelecionarTodaslocacoes =
            @"SELECT 
                *  
            FROM
                [TBLOCACAO] T";

        #endregion
        public override string Editar(int id, Locacao registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarLocacao, ObtemParametrosLocacao(registro));
            }

            return resultadoValidacao;
        }

        private Dictionary<string, object> ObtemParametrosLocacao(Locacao registro)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("Id", registro.Id);
            parametros.Add("id_cliente", registro.id_cliente);
            parametros.Add("id_veiculo", registro.id_veiculo);
            parametros.Add("id_taxa", registro.id_taxa);
            parametros.Add("preco", registro.preco);
            parametros.Add("dataLocacao", registro.dataLocacao);
            parametros.Add("dataDevolucao", registro.dataDevolucao);

            return parametros;
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirLocacao, AdicionarParametro("Id", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteLocacao, AdicionarParametro("Id", id));
        }

        public override string InserirNovo(Locacao registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirlocacaoVeiculo, ObtemParametrosLocacao(registro));
            }

            return resultadoValidacao;
        }

        public override Locacao SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarlocacaoPorId, ConverterEmLocacao, AdicionarParametro("Id", id));
        }

        public override List<Locacao> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodaslocacoes, ConverterEmLocacao);
        }

        private Locacao ConverterEmLocacao(IDataReader reader)
        {
            var id_cliente = Convert.ToInt32(reader["id_cliente"]);
            var id_veiculo = Convert.ToInt32(reader["id_veiculo"]);
            var id_taxas = Convert.ToInt32(reader["id_taxa"]);
            var id_seguro = Convert.ToInt32(reader["id_seguro"]);
            var preco = Convert.ToDouble(reader["preco"]);
            var dataLocacao = Convert.ToDateTime(reader["dataLocacao"]);
            var dataDevolucao = Convert.ToDateTime(reader["dataDevolucao"]);
            var plano = Convert.ToString(reader["planos"]);
            Locacao locacao = new Locacao(id_cliente, id_veiculo,id_taxas, id_seguro, preco, dataLocacao, dataDevolucao,plano );

            locacao.Id = Convert.ToInt32(reader["Id"]);

            return locacao;
        }
    }
}
