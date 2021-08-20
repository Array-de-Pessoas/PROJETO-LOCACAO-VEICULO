using LocadoraVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace LocadoraVeiculos.Dominio.VeiculoModule
{
    public class Veiculo : EntidadeBase
    {

        public string placa;
        public string cor;
        public string marca;
        public int ano;
        public string tipoCombustivel;
        public byte[] foto;
        public double quantidadeLitros;
        public int numeroPortas;
        public int capacidadeDePessoas;
        public string tamanhoPortaMalas;

        public int kilometragem;
        public int idGrupoVeiculo;

        public Veiculo(string placa, string cor, string marca, int ano, string tipoCombustivel, byte[] foto, double quantidadeLitros, int numeroPortas, int capacidadeDePessoas, string tamanhoPortaMalas, int kilometragem, int id_grupoVeiculo)
        {
            this.placa = placa;
            this.cor = cor;
            this.marca = marca;
            this.ano = ano;
            this.tipoCombustivel = tipoCombustivel;
            this.foto = foto;
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
            if (string.IsNullOrEmpty(cor))
            {
                return "Campo cor é obrigatório";
            }
            if (string.IsNullOrEmpty(marca))
            {
                return "Campo marca é obrigatório";
            }
            if (ano == 0)
            {
                return "Campo ano é obrigatório";
            }
            if (ano < 0)
            {
                return "Campo ano tem que ser valido";
            }
            if (ano > DateTime.Now.Year)
            {
                return "Campo ano tem que ser valido";
            }
            if (string.IsNullOrEmpty(tipoCombustivel))
            {
                return "Campo tipo combustível é obrigatório";
            }
            if (quantidadeLitros == 0)
            {
                return "Campo quantidade de litros do tanque é obrigatório";
            }
            if (numeroPortas == 0)
            {
                return "Campo Número de Portas é obrigatório";
            }
            if (capacidadeDePessoas == 0)
            {
                return "Campo capacidade de pessoas é obrigatório";
            }
            if (string.IsNullOrEmpty(tamanhoPortaMalas))
            {
                return "Campo tamanho do porta-malas é obrigatório";
            }
            if (idGrupoVeiculo == 0)
            {
                return "Campo grupo de veículo é obrigatório";
            }
            if (foto == null)
            {
                return "Imagem do veículo é obrigatória";
            }

            return "VALIDO";
        }

    }
}
