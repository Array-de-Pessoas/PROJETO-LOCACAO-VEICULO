using LocadoraVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Dominio.GrupoVeiculosModule
{
    public class GrupoVeiculos : EntidadeBase, IEquatable<GrupoVeiculos>
    {
        public string Grupo { get; }

        public GrupoVeiculos(string grupo)
        {
            Grupo = grupo;
        }

        public bool Equals(GrupoVeiculos other)
        {
            return other != null &&
                   Id == other.Id &&
                   Grupo == other.Grupo;
        }

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(Grupo))
                resultadoValidacao = "O campo Nome do grupo é obrigatório";

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as GrupoVeiculos);
        }

        public override int GetHashCode()
        {
            int hashCode = -677046642;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(grupo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Grupo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Grupo);
            return hashCode;
        }
    }
}
