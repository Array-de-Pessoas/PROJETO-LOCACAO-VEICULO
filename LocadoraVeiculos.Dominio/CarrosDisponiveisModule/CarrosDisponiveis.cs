using LocadoraVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Dominio.CarrosDisponiveisModule
{
    public class CarrosDisponiveis : EntidadeBase, IEquatable<CarrosDisponiveis>
    {
        public string Marca { get; }
        public int IdGrupo { get; }
        public string Placa { get; }

        public CarrosDisponiveis(string marca, int idGrupo, string placa)
        {
            Marca = marca;
            IdGrupo = idGrupo;
            Placa = placa;
        }

        public bool Equals(CarrosDisponiveis other)
        {
            return other != null &&
                   Id == other.Id &&
                   Marca == other.Marca &&
                   IdGrupo == other.IdGrupo &&
                   Placa == other.Placa;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as CarrosDisponiveis);
        }

        public override int GetHashCode()
        {
            int hashCode = -677046642;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Marca);
            hashCode = hashCode * -1521134295 + EqualityComparer<int>.Default.GetHashCode(IdGrupo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Placa);
            return hashCode;
        }

        public override string Validar()
        {
            string resultadoValidacao = "VALIDO";

            return resultadoValidacao;
        }
    }
}
