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

        public GrupoVeiculos(string grupo, double ValorDiariaPlanoDiario, double ValorDiariaPlanoControlado, double ValorDiariaPlanoLivre, double ValorDoKmPlanoDiario, double LimiteKMPlanoControlado, double ValorKmExcedentePlanoControlado)
        {
            Grupo = grupo;
            this.ValorDiariaPlanoDiario = ValorDiariaPlanoDiario;
            this.ValorDiariaPlanoControlado = ValorDiariaPlanoControlado;
            this.ValorDiariaPlanoLivre = ValorDiariaPlanoLivre;
            this.ValorDoKMPlanoDiario = ValorDoKMPlanoDiario;
            this.LimiteKMPlanoControlado = LimiteKMPlanoControlado;
            this.ValorKmExcedentePlanoControlado = ValorKmExcedentePlanoControlado;
        }

        public string Grupo { get; }
        public double ValorDiariaPlanoDiario { get; }
        public double ValorDiariaPlanoControlado { get; }
        public double ValorDiariaPlanoLivre { get; }
        public double ValorDoKMPlanoDiario { get; }
        public double LimiteKMPlanoControlado { get; }
        public double ValorKmExcedentePlanoControlado { get; }    

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
            if (ValorDiariaPlanoDiario == 0)
                resultadoValidacao = "O campo Valor da Diária do Plano Diário é obrigatório";
            if (ValorDiariaPlanoLivre == 0)
                resultadoValidacao = "O campo Valor da Diária do Plano Livre é obrigatório";
            if (ValorDiariaPlanoControlado == 0)
                resultadoValidacao = "O campo Valor da Diária do Plano Controlado é obrigatório";
            if (ValorDoKMPlanoDiario == 0)
                resultadoValidacao = "O campo Valor do KM rodado do Plano Diário é obrigatório";
            if (LimiteKMPlanoControlado == 0)
                resultadoValidacao = "O campo Limite de KM do Plano Controlado é obrigatório";
            if (ValorKmExcedentePlanoControlado == 0)
                resultadoValidacao = "O campo Valor do KM Excente do Plano Controlado é obrigatório";
                  
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
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Grupo);
            
            return hashCode;
        }
    }
}
