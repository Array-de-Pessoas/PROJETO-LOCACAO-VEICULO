using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Dominio.LocacoesPendentesModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controladores.LocacoesPendentesModule
{
    public class ControladorLocacoesPendentes : Controlador<LocacoesPendentes>
    {
        private const string sqlInserirLocacoesPendentes =
             @"INSERT INTO [TBLOCACOESPENDENTES]
                     (
                        [NOMECLIENTE],
                        [IDVEICULO],
                        [DATALOCACAO],
                        [DATADEVOLUCAO]
                     )
                     VALUES
                     (
                        @NOMECLIENTE,
                        @IDVEICULO,
                        @DATALOCACAO,
                        @DATADEVOLUCAO
                     )";

        private const string sqlSelecionarTodasLocacoesPendentes =
            @"SELECT 
                [ID],
                [NOMECLIENTE],
                [IDVEICULO],
                [DATALOCACAO],
                [DATADEVOLUCAO]
            FROM
                [TBLOCACOESPENDENTES] T";

        public override string Editar(int id, LocacoesPendentes registro)
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

        public override string InserirNovo(LocacoesPendentes registro)
        {
            string resultadoValidacao = "VALIDO";

            if (resultadoValidacao == "VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirLocacoesPendentes, ObtemParametros(registro));
            }

            return resultadoValidacao;
        }

        private Dictionary<string, object> ObtemParametros(LocacoesPendentes registro)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("Id", registro.Id);
            parametros.Add("NOMECLIENTE", registro.IdCliente);
            parametros.Add("IDVEICULO", registro.IdVeiculos);
            parametros.Add("DATALOCACAO", registro.DataLocacao);
            parametros.Add("DATADEVOLUCAO", registro.DataDevolucao);

            return parametros;
        }

        public override LocacoesPendentes SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public override List<LocacoesPendentes> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodasLocacoesPendentes, ConverterEmLocacoes);
        }

        private LocacoesPendentes ConverterEmLocacoes(IDataReader reader)
        {
            var idCliente = Convert.ToInt32(reader["NOMECLIENTE"]);
            var idVeiculo = Convert.ToInt32(reader["IDVEICULO"]);
            DateTime Datalocacao = Convert.ToDateTime(reader["DATALOCACAO"]);
            DateTime Datadevolucao = Convert.ToDateTime(reader["DATADEVOLUCAO"]);

            LocacoesPendentes locacoes = new LocacoesPendentes(idCliente, idVeiculo, Datalocacao, Datadevolucao);

            locacoes.Id = Convert.ToInt32(reader["Id"]);

            return locacoes;
        }
    }
}
