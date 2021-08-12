using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eAgenda.Controladores.Shared;
using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Dominio.VeiculoModule;


namespace LocadoraVeiculos.Controladores.VeiculoModule
{
    public class ControladorVeiculo : Controlador<Veiculo>
    {
        private const string sqlInserirVeiculo =
            @"INSERT INTO TBVEICULO(
                [Placa],
                [Cor],
                [Marca],
                [Ano],
                [TipoCombustivel],
                [QuantidadeLitros], 
                [NumerosPortas], 
                [CapacidadePessoas], 
                [TamanhoPortaMalas],
                [Foto],
                [Kilometragem],
                [IdGrupoVeiculos]
                )
            VALUES(
                @Placa
                @Cor
                @Marca
                @Ano
                @TipoCombustivel
                @NumeroPortas
                @CapacidadePessoas
                @TamanhoPortaMalas
                @Foto
                @Kilometragem
                @IdGrupoVeiculos)
            ";

        private const string sqlSelecionarVeiculoPorId =
            @"
                SELECT * FROM TBVEICULO WHERE [Id] = @ID
              ";

        public override string Editar(int id, Veiculo registro)
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

        public override string InserirNovo(Veiculo registro)
        {
            string resultadoValidacao = registro.Validar();
            if (resultadoValidacao == "VALIDO")
            {
                registro.id = Db.Insert(sqlInserirVeiculo, ObtemParametrosVeiculo(registro));
            }
            return resultadoValidacao;
        }

        public override Veiculo SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarVeiculoPorId, ConverterEmVeiculo, AdicionarParametro("Id", id));
        }

        public override List<Veiculo> SelecionarTodos()
        {
            throw new NotImplementedException();
        }

        private Dictionary<string, object> ObtemParametrosVeiculo(Veiculo veiculo)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("Id", veiculo.Id);
            parametros.Add("Placa", veiculo.placa);
            parametros.Add("Cor", veiculo.cor);
            parametros.Add("Marca", veiculo.marca);
            parametros.Add("Ano", veiculo.ano);
            parametros.Add("TipoCombustivel", veiculo.tipoCombustivel);
            parametros.Add("QuantidadeLitros", veiculo.quantidadeLitros);
            parametros.Add("NumeroPortas", veiculo.numeroPortas);
            parametros.Add("CapacidadePessoas", veiculo.capacidadeDePessoas);
            parametros.Add("TamanhoPortaMalas", veiculo.tamanhoPortaMalas);
            parametros.Add("Foto", null);
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
            double quantidadeLitros = Convert.ToDouble(reader["QuantidadeLitros"]);
            int numeroPortas = Convert.ToInt32(reader["NumeroPortas"]);
            int capacidadeDePessoas = Convert.ToInt32(reader["CapacidadeDePessoas"]);
            string tamanhoPortaMalas = Convert.ToString(reader["TamanhoPortaMalas"]);
            int kilometragem = Convert.ToInt32(reader["Kilometragem"]);
            int idGrupoVeiculo = Convert.ToInt32(reader["IdGrupoVeiculo"]);

            Veiculo veiculo = new Veiculo(placa,cor,marca,ano,tipoCombustivel,quantidadeLitros,numeroPortas,capacidadeDePessoas,tamanhoPortaMalas,kilometragem,idGrupoVeiculo);

            veiculo.id = id;

            return veiculo;
        }
    }
}
