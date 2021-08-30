using LocadoraVeiculos.Controladores.GrupoVeiculosModule;
using LocadoraVeiculos.Controladores.SegurosModule;
using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Controladores.TaxasServicosModule;
using LocadoraVeiculos.Controladores.VeiculoModule;
using LocadoraVeiculos.Dominio.GrupoVeiculosModule;
using LocadoraVeiculos.Dominio.LocacaoModule;
using LocadoraVeiculos.Dominio.SegurosModule;
using LocadoraVeiculos.Dominio.TaxasServicosModule;
using LocadoraVeiculos.Dominio.VeiculoModule;
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
                        [id_seguro],
                        [dataLocacao],
                        [dataDevolucao],
                        [preco],
                        [plano]
                     )
                     VALUES
                     (
                        @id_cliente,
                        @id_veiculo,
                        @id_taxa,
                        @id_seguro,
                        @dataLocacao,
                        @dataDevolucao,
                        @preco,
                        @plano
                     )";

        private const string sqlEditarLocacao =
            @"UPDATE [TBLOCACAO]
                    SET
                        [id_cliente] = @id_cliente,
                        [id_veiculo] =        @id_veiculo,
                        [id_taxa] =    @id_taxa,
                        [id_seguro] = @id_seguro,
                        [dataLocacao] =         @dataLocacao,
                        [dataDevolucao] =          @dataDevolucao,
                        [preco] =       @preco,
                        [plano] = @plano
                       
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

        private const string sqlCarrosAlugados =
             @"INSERT INTO [TBCARROSALUGADOS]
                     (
                        [NomeCliente],
                        [IdVeiculo]
                     )
                     VALUES
                     (
                        @NomeCliente,
                        @IdVeiculo
                     )";

        private const string sqlLocacoesPendentes =
            @"INSERT INTO [TBLOCAOCESPENDENTES]
                     (
                        [NomeCliente],
                        [IdVeiculo],
                        [DataLocacao],
                        [DataDevolucao]
                     )
                     VALUES
                     (
                        @NomeCliente,
                        @IdVeiculo,
                        @DataLocacao,
                        @DataDevolucao
                     )";

        private const string sqlSelecionarTodasLocacoesPendentes =
            @"SELECT 
                [ID],
                [NOMECLIENTE],
                [IDVEICULO],
                [DATALOCACAO],
                [DATADEVOLUCAO]
            FROM
                [TBLOCACOESPENDETES] T";
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
            parametros.Add("id_seguro", registro.id_seguro);
            parametros.Add("preco", registro.preco);
            parametros.Add("dataLocacao", registro.dataLocacao);
            parametros.Add("dataDevolucao", registro.dataDevolucao);
            parametros.Add("plano", registro.plano);

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
                registro.Id = Db.Insert(sqlCarrosAlugados, ObtemParametrosAlugados(registro));
                registro.Id = Db.Insert(sqlLocacoesPendentes, ObtemParametrosLocacoesPendentes(registro));
            }

            return resultadoValidacao;
        }

        private Dictionary<string, object> ObtemParametrosLocacoesPendentes(Locacao registro)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("Id", registro.Id);
            parametros.Add("NomeCliente", registro.id_cliente);
            parametros.Add("IdVeiculo", registro.id_veiculo);
            parametros.Add("DataLocacao", registro.dataLocacao);
            parametros.Add("DataDevolucao", registro.dataDevolucao);

            return parametros;
        }

        private Dictionary<string, object> ObtemParametrosAlugados(Locacao registro)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("Id", registro.Id);
            parametros.Add("NomeCliente", registro.id_cliente);
            parametros.Add("IdVeiculo", registro.id_veiculo);

            return parametros;
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
            var plano = Convert.ToString(reader["plano"]);
            Locacao locacao = new Locacao(id_cliente, id_veiculo, id_taxas, id_seguro, preco, dataLocacao, dataDevolucao, plano);

            locacao.Id = Convert.ToInt32(reader["Id"]);

            return locacao;
        }

        public double CalcularValorLocacao(Locacao locacao)
        {
            TimeSpan diasAlugado = locacao.dataDevolucao - locacao.dataLocacao;

            ControladorVeiculo controladorVeiculo = new ControladorVeiculo();
            ControladorGrupoVeiculos controladorGrupoVeiculos = new ControladorGrupoVeiculos();
            ControladorTaxasServicos controladorTaxasServicos = new ControladorTaxasServicos();
            ControladorSeguros controladorSeguros = new ControladorSeguros();

            Veiculo veiculoDaLocacao = controladorVeiculo.SelecionarPorId(locacao.id_veiculo);
            GrupoVeiculos grupoVeiculoDaLocacao = controladorGrupoVeiculos.SelecionarPorId(veiculoDaLocacao.idGrupoVeiculo);
            TaxasServicos taxasDaLocacao = controladorTaxasServicos.SelecionarPorId(locacao.id_taxa);
            Seguros seguroDaLocacao = controladorSeguros.SelecionarPorId(locacao.id_seguro);

            double valorDiaria = 0;
            
            if (locacao.plano == "Diário")
            {
                valorDiaria = grupoVeiculoDaLocacao.ValorDiariaPlanoDiario;
            }
            else if (locacao.plano == "Livre")
            {
                valorDiaria = grupoVeiculoDaLocacao.ValorDiariaPlanoLivre;

            }
            else if(locacao.plano == "Controlado")
            {
                valorDiaria = grupoVeiculoDaLocacao.ValorDiariaPlanoControlado;

            }         

            return (diasAlugado.Days * valorDiaria) + Convert.ToDouble(taxasDaLocacao.Valor) + (Convert.ToDouble(seguroDaLocacao.Valor)*diasAlugado.Days);
            
        }

    }
}
