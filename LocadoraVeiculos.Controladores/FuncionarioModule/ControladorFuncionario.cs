using eAgenda.Controladores.Shared;
using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Dominio.FuncionarioModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Controladores.FuncionarioModule
{
    public class ControladorFuncionario : Controlador<Funcionario>
    {
        private const string sqlInserirFuncionario =
            @"INSERT INTO TBFUNCIONARIO 
	                (
		                [Nome], 
		                [Usuario], 
		                [Senha],
                        [DataEntrada], 
		                [Salario]
	                ) 
	                VALUES
	                (
                        @Nome, 
                        @Usuario,
                        @Senha,
		                @DataEntrada, 
		                @Salario
	                )";

        private const string sqlEditarFuncionario =
            @"UPDATE TBFUNCIONARIO
                    SET
                        [Nome] = @Nome,
		                [Usuario] = @Usuario, 
		                [Senha] = @Senha,
                        [DataEntrada] = @DataEntrada,
                        [Salario] = @Salario
                    WHERE 
                        ID = @ID";

        private const string sqlExcluirFuncionario =
            @"DELETE 
	                FROM
                        TBFUNCIONARIO
                    WHERE 
                        ID = @ID";

        private const string sqlSelecionarFuncionarioPorId =
            @"SELECT
                        [Id],
		                [Nome], 
		                [Usuario], 
		                [Senha],
                        [DataEntrada], 
		                [Salario]
	                FROM
                        TBFUNCIONARIO
                    WHERE 
                        ID = @ID";

        private const string sqlSelecionarTodosFuncionarios =
            @"SELECT
                        [ID],
		                [NOME], 
		                [EMAIL], 
		                [TELEFONE],
                        [CARGO], 
		                [EMPRESA]
	                FROM
                        TBFUNCIONARIO ORDER BY Nome;";

        private const string sqlExisteFuncionario =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBFUNCIONARIO]
            WHERE 
                [ID] = @ID";

        public override string InserirNovo(Funcionario registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirFuncionario, ObtemParametrosFuncionario(registro));
            }

            return resultadoValidacao;
        }

        public override string Editar(int id, Funcionario registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarFuncionario, ObtemParametrosFuncionario(registro));
            }

            return resultadoValidacao;
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirFuncionario, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteFuncionario, AdicionarParametro("ID", id));
        }

        public override Funcionario SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarFuncionarioPorId, ConverterEmFuncionario, AdicionarParametro("ID", id));
        }

        public override List<Funcionario> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosFuncionarios, ConverterEmFuncionario);
        }

        private Dictionary<string, object> ObtemParametrosFuncionario(Funcionario funcionario)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("Id", funcionario.Id);
            parametros.Add("Nome", funcionario.Nome);
            parametros.Add("Usuario", funcionario.Usuario);
            parametros.Add("Senha", funcionario.Senha);
            parametros.Add("DataEntrada", funcionario.DataEntrada);
            parametros.Add("Salario", funcionario.Salario);

            return parametros;
        }

        private Funcionario ConverterEmFuncionario(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["Id"]);
            string nome = Convert.ToString(reader["Nome"]);
            string usuario = Convert.ToString(reader["Usuario"]);
            string senha = Convert.ToString(reader["Senha"]);
            DateTime dataEntrada = Convert.ToDateTime(reader["DataEntrada"]);
            decimal salario = Convert.ToDecimal(reader["Salario"]);

            Funcionario funcionario = new Funcionario(nome, usuario, senha, dataEntrada, salario);

            funcionario.Id = id;

            return funcionario;
        }
    }
}
