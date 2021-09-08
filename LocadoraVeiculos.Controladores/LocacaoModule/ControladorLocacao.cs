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
                        [plano],
                        [dataDevolucaoRealizada],
                        [locacaoAtiva]
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
                        @plano,
                        @dataDevolucaoRealizada,
                        @locacaoAtiva
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
                        [plano] = @plano,
                        [dataDevolucaoRealizada] = @dataDevolucaoRealizada,
                        [locacaoAtiva] = @locacaoAtiva
                       
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

        private const string sqlSelecionarTodaslocacoesAtivas =
           @"SELECT 
                *  
            FROM
                [TBLOCACAO] 
            WHERE 
                locacaoAtiva = 1";

        private const string sqlSelecionarTodasDevolucoes =
           @"SELECT 
                *  
            FROM
                [TBLOCACAO] 
            WHERE 
                locacaoAtiva = 0";

        private const string sqlSelecionarCarrosAlugados =
            @"SELECT 
                [ID],
                [NOMECLIENTE],
                [IDVEICULO]
            FROM
                [TBCARROSALUGADOS] T";     
     
        #endregion

        public List<Locacao> Selecionar()
        {
            return Db.GetAll(sqlSelecionarCarrosAlugados, ConverterEmLocacao);
        }

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
            parametros.Add("locacaoAtiva", registro.locacaoAtiva);
            parametros.Add("dataDevolucaoRealizada", registro.dataDevolucaoRealizada);

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

            if (resultadoValidacao == "ESTA_VALIDO")
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

        public List<Locacao> SelecionarTodasLocacoesAtivas()
        {
            return Db.GetAll(sqlSelecionarTodaslocacoesAtivas, ConverterEmLocacao);
        }

        public List<Locacao> SelecionarTodasDevolucao()
        {
            return Db.GetAll(sqlSelecionarTodasDevolucoes, ConverterEmLocacao);
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
            DateTime dataDevolucaoRealizada = DateTime.MinValue;
            if (reader["dataDevolucaoRealizada"] != DBNull.Value){
                dataDevolucaoRealizada = Convert.ToDateTime(reader["dataDevolucaoRealizada"]);
            }           
            var locacaoAtiva = Convert.ToInt32(reader["locacaoAtiva"]);

            Locacao locacao = new Locacao(id_cliente, id_veiculo, id_taxas, id_seguro, preco, dataLocacao, dataDevolucao, plano, dataDevolucaoRealizada, locacaoAtiva);

            locacao.Id = Convert.ToInt32(reader["Id"]);

            return locacao;
        }

        public double CalcularValorLocacao(Locacao locacao)
        {
            TimeSpan diasAlugados = (TimeSpan)(locacao.dataDevolucaoRealizada - locacao.dataLocacao);
            TimeSpan diasPrevistoAlugado = locacao.dataDevolucao - locacao.dataLocacao;

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
            else 
            {
                valorDiaria = grupoVeiculoDaLocacao.ValorDiariaPlanoControlado;
            }

            double valorTotalSemMulta = (diasAlugados.Days * valorDiaria) + Convert.ToDouble(taxasDaLocacao.Valor) + (Convert.ToDouble(seguroDaLocacao.Valor) * diasAlugados.Days);
            double gerarValorMulta = CalcularMulta(diasAlugados.Days, diasPrevistoAlugado.Days, valorTotalSemMulta);

            return valorTotalSemMulta + gerarValorMulta;
            
        }

        private double CalcularMulta(int diasAlugados, int diasPrevistos, double valorTotalSemMulta)
        {
            int diasParaMultar = diasAlugados - diasPrevistos;
            if (diasParaMultar >0)
            {           
                return diasParaMultar * (valorTotalSemMulta * 0.1);
            }
            return 0;
        }
    }
}
