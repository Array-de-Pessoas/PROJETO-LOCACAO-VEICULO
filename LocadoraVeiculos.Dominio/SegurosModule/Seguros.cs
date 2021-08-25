using LocadoraVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Dominio.SegurosModule
{
    public class Seguros : EntidadeBase,IEquatable<Seguros>
    {
        public string TipoSeguro { get; }
        public decimal Valor { get; }


        public Seguros(string tipoSeguro, decimal valor)
        {
            TipoSeguro = tipoSeguro;
            Valor = valor;
        }

        public bool Equals(Seguros other)
        {
            return other != null &&
                   Id == other.Id &&
                   TipoSeguro == other.TipoSeguro &&
                   Valor == other.Valor;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Seguros);
        }

        public override int GetHashCode()
        {
            int hashCode = -677046642;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TipoSeguro);
            hashCode = hashCode * -1521134295 + Valor.GetHashCode();
            return hashCode;
        }

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(TipoSeguro))
                resultadoValidacao = "                                                     O campo tipo de seguro não pode estar vazio";

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }
    }
}
