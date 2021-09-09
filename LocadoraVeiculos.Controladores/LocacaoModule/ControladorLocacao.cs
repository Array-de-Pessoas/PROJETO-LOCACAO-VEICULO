using LocadoraVeiculos.Controladores.CupomModule;
using LocadoraVeiculos.Controladores.GrupoVeiculosModule;
using LocadoraVeiculos.Controladores.SegurosModule;
using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Controladores.TaxasServicosModule;
using LocadoraVeiculos.Controladores.VeiculoModule;
using LocadoraVeiculos.Dominio.CupomModule;
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
        ControladorCupom controladorCupom = new ControladorCupom();

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
                        [locacaoAtiva],
                        [id_cupom]
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
                        @locacaoAtiva,
                        @id_cupom
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
                        [locacaoAtiva] = @locacaoAtiva,
                        [id_cupom] = @id_cupom
                       
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
     
        #endregion

        public override string Editar(int id, Locacao registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
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
            parametros.Add("id_cupom", registro.cupom.Id);

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

        public List<Locacao> SelecionarTodasDevolucoes()
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

            Cupom cupom = null;
            var id_cupom = Convert.ToInt32(reader["id_cupom"]);
            if (id_cupom != 0)
            {
                cupom = controladorCupom.SelecionarPorId(id_cupom);
            }           

            Locacao locacao = new Locacao(id_cliente, id_veiculo, id_taxas, id_seguro, preco, dataLocacao, dataDevolucao, plano, dataDevolucaoRealizada, locacaoAtiva, cupom);

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
            double ValorMulta = CalcularMulta(diasAlugados.Days, diasPrevistoAlugado.Days, valorTotalSemMulta);
            double valorComDesconto = CalcularDescontoCupom(valorTotalSemMulta, locacao.cupom);

            return ValorMulta + valorComDesconto;
            
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

        private double CalcularDescontoCupom(double valorLocacao, Cupom cupom)
        {
            bool semDescontouValido = cupom == null || valorLocacao < (double)cupom.ValorMinimo;
            if (semDescontouValido)
            {
                return valorLocacao;
            }
            double valorDoDesconto = valorLocacao * ((double)cupom.Valor / 100);
            return valorLocacao - valorDoDesconto;
            
        }
    }
}
