using LocadoraVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Dominio.CombustivelModule
{
    public class Combustivel : EntidadeBase, IEquatable<Combustivel>
    {
        public string TipoCombustivel { get; }
        public decimal Valor { get; }

        public Combustivel(string tipoCombustivel, decimal valor)
        {
            TipoCombustivel = tipoCombustivel;
            Valor = valor;
        }

        public bool Equals(Combustivel other)
        {
            return other != null &&
                   Id == other.Id &&
                   TipoCombustivel == other.TipoCombustivel &&
                   Valor == other.Valor;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Combustivel);
        }

        public override int GetHashCode()
        {
            int hashCode = -677046642;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TipoCombustivel);
            hashCode = hashCode * -1521134295 + Valor.GetHashCode();
            return hashCode;
        }

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(TipoCombustivel))
                resultadoValidacao = "                                                     O campo tipo de combustível não pode estar vazio";

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }
    }
}
