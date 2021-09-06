using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Dominio.CupomModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controladores.CupomModule
{
    public class ControladorCupom : Controlador<Cupom>
    {
        private const string sqlInserirCupom =
           @"INSERT INTO [TBCUPOM]
                     (
                         [CODIGO],
                         [TIPO],
                         [VALOR],
                         [VALORMINIMO],
                         [PARCEIRO],
                         [DIAVENCIMENTO],
                         [QUANTIDADEUSO]
                     )
                     VALUES
                     (
                         @CODIGO,
                         @TIPO,
                         @VALOR,
                         @VALORMINIMO,
                         @PARCEIRO,
                         @DIAVENCIMENTO,
                         @QUANTIDADEUSO
                     )";

        private const string sqlEditarCupom =
            @"UPDATE TBCUPOM
                    SET
                         [CODIGO] = @CODIGO,
                         [TIPO] = @TIPO,
                         [VALOR] = @VALOR,
                         [VALORMINIMO] = @VALORMINIMO,
                         [PARCEIRO] = @PARCEIRO,
                         [DIAVENCIMENTO] = @DIAVENCIMENTO,
                         [QUANTIDADEUSO] = @QUANTIDADEUSO
                    WHERE 
                        ID = @ID";

        private const string sqlExcluirCupom =
            @"DELETE FROM [TBCUPOM]
                    WHERE 
                        [ID] = @ID";

        private const string sqlExisteCupom =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBCUPOM]
            WHERE 
                [ID] = @ID";

        private const string sqlSelecionarCupomPorId =
            @"SELECT 
                [ID],
                [CODIGO],
                [TIPO],
                [VALOR],
                [VALORMINIMO],
                [PARCEIRO],
                [DIAVENCIMENTO],
                [QUANTIDADEUSO]
             FROM
                [TBCUPOM]
             WHERE 
                [ID] = @ID";

        private const string sqlSelecionarTodosCupom =
            @"SELECT 
                [ID],
                [CODIGO],
                [TIPO],
                [VALOR],
                [VALORMINIMO],
                [PARCEIRO],
                [DIAVENCIMENTO],
                [QUANTIDADEUSO]
            FROM
                [TBCUPOM] T";

        public override string Editar(int id, Cupom registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarCupom, ObtemParametrosCupom(registro));
            }

            return resultadoValidacao;
        }

        private Dictionary<string, object> ObtemParametrosCupom(Cupom registro)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", registro.Id);
            parametros.Add("CODIGO", registro.Codigo);
            parametros.Add("TIPO", registro.Tipo);
            parametros.Add("VALOR", registro.Valor);
            parametros.Add("VALORMINIMO", registro.ValorMinimo);
            parametros.Add("PARCEIRO", registro.Parceiro);
            parametros.Add("DIAVENCIMENTO", registro.DiaVencimento);
            parametros.Add("QUANTIDADEUSO", registro.QuantidadeUso);

            return parametros;
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirCupom, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteCupom, AdicionarParametro("ID", id));
        }

        public override string InserirNovo(Cupom registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirCupom, ObtemParametrosCupom(registro));
            }

            return resultadoValidacao;
        }

        public override Cupom SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarCupomPorId, ConverterEmCupom, AdicionarParametro("ID", id));
        }

        private Cupom ConverterEmCupom(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string codigo = Convert.ToString(reader["CODIGO"]);
            string tipo = Convert.ToString(reader["TIPO"]);
            decimal valor = Convert.ToDecimal(reader["VALOR"]);
            decimal valorMinimo = Convert.ToDecimal(reader["VALORMINIMO"]);
            string parceiro = Convert.ToString(reader["PARCEIRO"]);
            DateTime diaVencimento = Convert.ToDateTime(reader["DIAVENCIMENTO"]);
            int quantidade = Convert.ToInt32(reader["QUANTIDADEUSO"]);

            Cupom cupom = new Cupom(codigo, tipo, valor, valorMinimo, parceiro, diaVencimento, quantidade);

            cupom.Id = id;

            return cupom;
        }

        public override List<Cupom> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosCupom, ConverterEmCupom);
        }
    }
}
