using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Dominio.VeiculoModule;


namespace LocadoraVeiculos.Controladores.VeiculoModule
{
    public class ControladorVeiculo : Controlador<Veiculo>
    {
        #region scriptsSQL
        private const string sqlInserirVeiculo =
            @"INSERT INTO TBVEICULO(
                [Placa],
                [Cor],
                [Marca],
                [Ano],
                [TipoCombustivel],
                [QuantidadeLitros], 
                [NumeroPortas], 
                [CapacidadePessoas], 
                [TamanhoPortaMalas],
                [Foto],
                [Kilometragem],
                [IdGrupoVeiculos]
                )
            VALUES(
                @Placa,
                @Cor,
                @Marca,
                @Ano,
                @TipoCombustivel,
                @QuantidadeLitros,
                @NumeroPortas,
                @CapacidadePessoas,
                @TamanhoPortaMalas,
                @Foto,
                @Kilometragem,
                @IdGrupoVeiculos)
            ";

        private const string sqlSelecionarVeiculoPorId =
            @"
                SELECT * FROM TBVEICULO WHERE [Id] = @Id
              ";

        private const string sqlEditarVeiculo =
            @"UPDATE TBVEICULO
                    SET
                        [Placa] = @Placa,
                        [Cor] = @Cor,
                        [Marca] = @Marca,
                        [Ano] = @Ano,
                        [TipoCombustivel] = @TipoCombustivel,
                        [QuantidadeLitros] = @QuantidadeLitros, 
                        [NumeroPortas] = @NumeroPortas, 
                        [CapacidadePessoas] = @CapacidadePessoas, 
                        [TamanhoPortaMalas] = @TamanhoPortaMalas,
                        [Foto] = @Foto,
                        [Kilometragem] = @Kilometragem,
                        [IdGrupoVeiculos] = @IdGrupoVeiculos                     
                    WHERE 
                        [Id] = @Id";

        private const string sqlExcluirFuncionario =
           @"DELETE 
	                FROM
                        TBVEICULO
                    WHERE 
                        [Id] = @Id";

        private const string sqlSelecionarTodosFuncionarios =
           @"SELECT *
	                FROM
                        TBVEICULO ORDER BY [Ano];";

        private const string sqlExisteVeiculo =
           @"SELECT 
                COUNT(*) 
            FROM 
                [TBVEICULO]
            WHERE 
                [Id] = @Id";

        private const string sqlAdicionarCarrosDisponiveis =
            @"INSERT INTO TBCARROSDISPONIVEIS(
                [Marca],
                [IdGrupoVeiculos],
                [Placa]
                )
            VALUES(
                @Marca,
                @IdGrupoVeiculos,
                @Placa)
            ";

        #endregion
        public override string Editar(int id, Veiculo registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarVeiculo, ObtemParametrosVeiculo(registro));
            }

            return resultadoValidacao;
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirFuncionario, AdicionarParametro("Id", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteVeiculo, AdicionarParametro("Id", id));
        }

        public override string InserirNovo(Veiculo registro)
        {
            string resultadoValidacao = registro.Validar();
            if (resultadoValidacao == "VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirVeiculo, ObtemParametrosVeiculo(registro));
                registro.Id = Db.Insert(sqlAdicionarCarrosDisponiveis, ObtemParametrosCarrosDisponiveis(registro));
            }
            return resultadoValidacao;
        }

        private Dictionary<string, object> ObtemParametrosCarrosDisponiveis(Veiculo veiculo)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("Id", veiculo.Id);
            parametros.Add("Marca", veiculo.marca);
            parametros.Add("IdGrupoVeiculos", veiculo.idGrupoVeiculo);
            parametros.Add("Placa", veiculo.Placa);

            return parametros;
        }

        public override Veiculo SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarVeiculoPorId, ConverterEmVeiculo, AdicionarParametro("Id", id));
        }

        public override List<Veiculo> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosFuncionarios, ConverterEmVeiculo);
        }

        private Dictionary<string, object> ObtemParametrosVeiculo(Veiculo veiculo)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("Id", veiculo.Id);
            parametros.Add("Placa", veiculo.Placa);
            parametros.Add("Cor", veiculo.cor);
            parametros.Add("Marca", veiculo.marca);
            parametros.Add("Ano", veiculo.ano);
            parametros.Add("TipoCombustivel", veiculo.tipoCombustivel);
            parametros.Add("QuantidadeLitros", veiculo.quantidadeLitros);
            parametros.Add("NumeroPortas", veiculo.numeroPortas);
            parametros.Add("CapacidadePessoas", veiculo.capacidadeDePessoas);
            parametros.Add("TamanhoPortaMalas", veiculo.tamanhoPortaMalas);
            parametros.Add("Foto", veiculo.foto);
            parametros.Add("Kilometragem", veiculo.kilometragem);
            parametros.Add("IdGrupoVeiculos", veiculo.idGrupoVeiculo);

            return parametros;
        }

        private Veiculo ConverterEmVeiculo(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["Id"]);
            string placa = Convert.ToString(reader["Placa"]);
            string cor= Convert.ToString(reader["Cor"]);
            string marca= Convert.ToString(reader["Marca"]);
            int ano = Convert.ToInt32(reader["Ano"]);
            string tipoCombustivel = Convert.ToString(reader["TipoCombustivel"]) ;
            byte[] foto;
            if (reader["Foto"] != DBNull.Value)
                foto = (byte[])reader["Foto"];
            else
                foto = null;
            //Image foto = reader["Foto"] == DBNull.Value ? null : (Image)reader["Foto"];
            double quantidadeLitros = Convert.ToDouble(reader["QuantidadeLitros"]);
            int numeroPortas = Convert.ToInt32(reader["NumeroPortas"]);
            int capacidadeDePessoas = Convert.ToInt32(reader["CapacidadePessoas"]);
            string tamanhoPortaMalas = Convert.ToString(reader["TamanhoPortaMalas"]);
            int kilometragem = Convert.ToInt32(reader["Kilometragem"]);
            int idGrupoVeiculo = Convert.ToInt32(reader["IdGrupoVeiculos"]);

            Veiculo veiculo = new Veiculo(placa,cor,marca,ano,tipoCombustivel,foto,quantidadeLitros,numeroPortas,capacidadeDePessoas,tamanhoPortaMalas,kilometragem,idGrupoVeiculo);

            veiculo.Id = id;

            return veiculo;
        }
    }
}
