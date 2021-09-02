using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controladores.ClienteModule
{
    public class ControladorCliente : Controlador<Cliente>
    {
        private const string sqlInserirCliente =
            @"INSERT INTO [TBCLIENTE]
                     (
                         [NOME],
                         [ENDERECO],
                         [TELEFONE],
                         [EMAIL],
                         [CPFouCNPJ],
                         [NOMECONDUTOR],
                         [CNH],
                         [CPFCONDUTOR],
                         [RG],
                         [DATAVALIDADECNH]
                     )
                     VALUES
                     (
                         @NOME,
                         @ENDERECO,
                         @TELEFONE,
                         @EMAIL,
                         @CPFouCNPJ,
                         @NOMECONDUTOR,
                         @CNH,
                         @CPFCONDUTOR,
                         @RG,
                         @DATAVALIDADECNH
                     )";

        private const string sqlEditarCliente =
            @"UPDATE TBCLIENTE
                    SET
                         [NOME] = @NOME,
                         [ENDERECO] = @ENDERECO,
                         [TELEFONE] = @TELEFONE,
                         [EMAIL] = @EMAIL,
                         [CPFouCNPJ] = @CPFouCNPJ,
                         [NOMECONDUTOR] = @NOMECONDUTOR,
                         [CNH] = @CNH,
                         [CPFCONDUTOR] = @CPFCONDUTOR,
                         [RG] = @RG,
                         [DATAVALIDADECNH] = @DATAVALIDADECNH
                    WHERE 
                        ID = @ID";

        private const string sqlExcluirCliente =
            @"DELETE FROM [TBCLIENTE]
                    WHERE 
                        [ID] = @ID";

        private const string sqlExisteCliente =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBCLIENTE]
            WHERE 
                [ID] = @ID";

        private const string sqlSelecionarClientePorId =
            @"SELECT 
                [ID],
                [NOME],
                [ENDERECO],
                [TELEFONE],
                [EMAIL],
                [CPFouCNPJ],
                [NOMECONDUTOR],
                [CNH],
                [CPFCONDUTOR],
                [RG],
                [DATAVALIDADECNH]
             FROM
                [TBCLIENTE]
             WHERE 
                [ID] = @ID";

        private const string sqlSelecionarTodosCliente =
            @"SELECT 
                [ID],
                [NOME],
                [ENDERECO],
                [TELEFONE],
                [EMAIL],
                [CPFouCNPJ],
                [NOMECONDUTOR],
                [CNH],
                [CPFCONDUTOR],
                [RG],
                [DATAVALIDADECNH]
            FROM
                [TBCLIENTE] T";

        public override string Editar(int id, Cliente registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarCliente, ObtemParametrosCliente(registro));
            }

            return resultadoValidacao;
        }

        private Dictionary<string, object> ObtemParametrosCliente(Cliente registro)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", registro.Id);
            parametros.Add("NOME", registro.NomeCliente);
            parametros.Add("ENDERECO", registro.Endereco);
            parametros.Add("TELEFONE", registro.Telefone);
            parametros.Add("EMAIL", registro.Email);
            parametros.Add("CPFouCNPJ", registro.TipoDeIdentidade);
            parametros.Add("NOMECONDUTOR", registro.NomeDoCondutor);
            parametros.Add("CNH", registro.CNH);
            parametros.Add("CPFCONDUTOR", registro.CPFDoCondutor);
            parametros.Add("RG", registro.RGDoCondutor);
            parametros.Add("DATAVALIDADECNH", registro.DataValidadeCNH);

            return parametros;
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirCliente, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteCliente, AdicionarParametro("ID", id));
        }

        public override string InserirNovo(Cliente registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirCliente, ObtemParametrosCliente(registro));
            }

            return resultadoValidacao;
        }

        public override Cliente SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarClientePorId, ConverterEmClientes, AdicionarParametro("ID", id));
        }

        private Cliente ConverterEmClientes(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string nomeCliente = Convert.ToString(reader["NOME"]);
            string endereco = Convert.ToString(reader["ENDERECO"]);
            string telefone = Convert.ToString(reader["TELEFONE"]);
            string email = Convert.ToString(reader["EMAIL"]);
            string tipoDeIdentidade = Convert.ToString(reader["CPFouCNPJ"]);
            string nomeDoCondutor = Convert.ToString(reader["NOMECONDUTOR"]);
            string cNH = Convert.ToString(reader["CNH"]);
            string cpfCondutor = Convert.ToString(reader["CPFCONDUTOR"]);
            string rGDoCondutor = Convert.ToString(reader["RG"]);
            DateTime dataValidadeCNH = Convert.ToDateTime(reader["DATAVALIDADECNH"]);

            Cliente cliente = new Cliente(nomeCliente, endereco, telefone, email, tipoDeIdentidade, nomeDoCondutor, cNH, cpfCondutor, rGDoCondutor, dataValidadeCNH);

            cliente.Id = id;

            return cliente;
        }

        public override List<Cliente> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosCliente, ConverterEmClientes);
        }
    }
}
