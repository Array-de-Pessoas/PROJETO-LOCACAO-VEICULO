using LocadoraVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Dominio.ParceiroModule
{
    public class Parceiro : EntidadeBase, IEquatable<Parceiro>
    {
        public string NomeParceiro { get; }

        public Parceiro (string nomeParceiro)
        {
            NomeParceiro = nomeParceiro;
        }

        public bool Equals(Parceiro other)
        {
            return other != null &&
                  Id == other.Id &&
                  NomeParceiro == other.NomeParceiro;   
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Parceiro);
        }

        public override int GetHashCode()
        {
            int hashCode = -677046642;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NomeParceiro);
            return hashCode;
        }

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(NomeParceiro))
                resultadoValidacao = "                                                     O campo nome do parceiro não pode estar vazio";

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }
    }
}
