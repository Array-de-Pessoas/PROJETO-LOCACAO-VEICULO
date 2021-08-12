using LocadoraVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Dominio.VeiculoModule
{
    public class Veiculo : EntidadeBase
    {

      public string placa;
      public string cor;
      public string marca;
      public int ano;
      public string tipoCombustivel;
      public double quantidadeLitros;
      public int numeroPortas;
      public int capacidadeDePessoas;
      public string tamanhoPortaMalas;
      //foto
      public int kilometragem;
      public int idGrupoVeiculo;

        public Veiculo(string placa, string cor, string marca, int ano, string tipoCombustivel, double quantidadeLitros, int numeroPortas, int capacidadeDePessoas, string tamanhoPortaMalas, int kilometragem, int id_grupoVeiculo)
        {
            this.placa = placa;
            this.cor = cor;
            this.marca = marca;
            this.ano = ano;
            this.tipoCombustivel = tipoCombustivel;
            this.quantidadeLitros = quantidadeLitros;
            this.numeroPortas = numeroPortas;
            this.capacidadeDePessoas = capacidadeDePessoas;
            this.tamanhoPortaMalas = tamanhoPortaMalas;
            this.kilometragem = kilometragem;
            this.idGrupoVeiculo = id_grupoVeiculo;
        }

        public override string Validar()
        {
            if (string.IsNullOrEmpty(placa))
            {
                return "Campo placa é obrigatório";
            }
            else if (string.IsNullOrEmpty(cor))
            {
                return "Campo cor é obrigatório";
            }
            else if (string.IsNullOrEmpty(marca))
            {
                return "Campo marca é obrigatório";
            }
            else if (ano == 0)
            {
                return "Campo ano é obrigatório";
            }
            else if (string.IsNullOrEmpty(tipoCombustivel))
            {
                return "Campo tipo combustível é obrigatório";
            }
            else if (quantidadeLitros == 0)
            {
                return "Campo quantiade de litros do tanque é obrigatório";
            }
            else if (numeroPortas == 0)
            {
                return "Campo Número de Portas é obrigatório";
            }
            else if (capacidadeDePessoas == 0)
            {
                return "Campo capacidade de pessoas é obrigatório";
            }
            else if (string.IsNullOrEmpty(tamanhoPortaMalas))
            {
                return "Campo tamanho do porta-malas é obrigatório";
            }
            else if (idGrupoVeiculo == 0)
            {
                return "Campo grupo de veículo é obrigatório";
            }

            return "VALIDO";
        }

    }
}
