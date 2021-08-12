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

        string placa;
        string cor;
        string marca;
        int ano;
        string tipoCombustivel;
        double quantidadeLitros;
        int numeroPortas;
        int capacidadeDePessoas;
        string tamanhoPortaMalas;
        //foto
        int kilometragem;
        int id_grupoVeiculo;
        

        public override string Validar()
        {


            return "VALIDO";
        }

    }
}
