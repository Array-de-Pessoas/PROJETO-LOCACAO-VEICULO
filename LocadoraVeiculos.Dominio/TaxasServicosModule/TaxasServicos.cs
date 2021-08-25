using LocadoraVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Dominio.TaxasServicosModule
{
    public class TaxasServicos : EntidadeBase, IEquatable<TaxasServicos>
    {
        public string TipoTaxa { get; }
        public string Nome { get; }
        public decimal Valor { get; }
        
        public TaxasServicos(string tipoTaxa,string nome, decimal valor)
        {
            TipoTaxa = tipoTaxa;
            Nome = nome;
            Valor = valor;
        }

        public bool Equals(TaxasServicos other)
        {
            return other != null &&
                   Id == other.Id &&
                   TipoTaxa == other.TipoTaxa &&
                   Nome == other.Nome &&
                   Valor == other.Valor;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as TaxasServicos);
        }

        public override int GetHashCode()
        {
            int hashCode = -677046642;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TipoTaxa);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + Valor.GetHashCode();
            return hashCode;
        }

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(TipoTaxa))
                resultadoValidacao = "                                                     O campo tipo de taxa não pode estar vazio";

            if (string.IsNullOrEmpty(Nome))
                resultadoValidacao = "                                                     O campo nome não pode estar vazio";

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }
    }
}
