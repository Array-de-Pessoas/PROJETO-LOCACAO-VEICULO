using LocadoraVeiculos.Controladores.FuncionarioModule;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.WindowsForm.Feature.LoginModule
{
    public class OperacoesLogin 
    {
        static List<String> PegarValor = new List<string>();
        LoginForm login = new LoginForm();

        public void ValidarSeExiste()
        {
            string AdressDBFuncionario = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";

            SqlConnection connectionWithFuncionario = new SqlConnection();
            connectionWithFuncionario.ConnectionString = AdressDBFuncionario;

            connectionWithFuncionario.Open();

            SqlCommand commandGet = new SqlCommand();
            commandGet.Connection = connectionWithFuncionario;

            string sqlGet =
                @"SELECT * FROM TBFUNCIONARIO
                  ";

            commandGet.CommandText = sqlGet;

            using (SqlDataReader oReader = commandGet.ExecuteReader())
            {
                while (oReader.Read())
                {
                    string usuario = oReader["USUARIO"].ToString();
                    if (usuario == UsuarioParaValidacao.Usuario)
                    {
                        PegarValor.Add(usuario);
                    }
                    string senha = oReader["SENHA"].ToString();
                    if (senha == UsuarioParaValidacao.Senha)
                    {
                        PegarValor.Add(senha);
                    }
                }
            }
            connectionWithFuncionario.Close();
            if (PegarValor.Count == 2)
            {
                login.LoginEncontrado();
            }
            if (PegarValor.Count == 0)
            {
                login.LoginNaoEncontrado();
            }
            if (PegarValor.Count == 1)
            {
                login.DadosIncorretos();
            }
            PegarValor.Clear();
        }
    }
}
