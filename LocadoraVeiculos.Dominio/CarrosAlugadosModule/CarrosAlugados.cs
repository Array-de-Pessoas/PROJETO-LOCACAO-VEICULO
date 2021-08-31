using LocadoraVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Dominio.CarrosAlugadosModule
{
    public class CarrosAlugados : EntidadeBase, IEquatable<CarrosAlugados>
    {
        public int IdCliente { get; }
        public int IdVeiculo { get; }

        public CarrosAlugados(int idCliente, int idVeiculo)
        {
            IdCliente = idCliente;
            IdVeiculo = idVeiculo;
        }

        public bool Equals(CarrosAlugados other)
        {
            return other != null &&
                   Id == other.Id &&
                   IdCliente == other.IdCliente &&
                   IdVeiculo == other.IdVeiculo;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as CarrosAlugados);
        }

        public override int GetHashCode()
        {
            int hashCode = -677046642;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<int>.Default.GetHashCode(IdCliente);
            hashCode = hashCode * -1521134295 + EqualityComparer<int>.Default.GetHashCode(IdVeiculo);
            return hashCode;
        }

        public override string Validar()
        {
            string resultadoValidacao = "VALIDO";

            return resultadoValidacao;
        }
    }
}
