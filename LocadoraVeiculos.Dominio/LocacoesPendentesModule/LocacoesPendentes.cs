using LocadoraVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Dominio.LocacoesPendentesModule
{
    public class LocacoesPendentes : EntidadeBase, IEquatable<LocacoesPendentes>
    {
        public int IdCliente;
        public int IdVeiculos;
        public DateTime DataLocacao;
        public DateTime DataDevolucao;

        public LocacoesPendentes (int idCliente, int idVeiculos, DateTime dataLocacao, DateTime dataDevolucao)
        {
            IdCliente = idCliente;
            IdVeiculos = idVeiculos;
            DataLocacao = dataLocacao;
            DataDevolucao = dataDevolucao;
        }

        public bool Equals(LocacoesPendentes other)
        {
            return other != null &&
                   Id == other.Id &&
                   IdCliente == other.IdCliente &&
                   IdVeiculos == other.IdVeiculos &&
                   DataLocacao == other.DataLocacao &&
                   DataDevolucao == other.DataDevolucao;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as LocacoesPendentes);
        }

        public override int GetHashCode()
        {
            int hashCode = -677046642;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<int>.Default.GetHashCode(IdCliente);
            hashCode = hashCode * -1521134295 + EqualityComparer<int>.Default.GetHashCode(IdVeiculos);
            hashCode = hashCode * -1521134295 + EqualityComparer<DateTime>.Default.GetHashCode(DataLocacao);
            hashCode = hashCode * -1521134295 + EqualityComparer<DateTime>.Default.GetHashCode(DataDevolucao);
            return hashCode;
        }

        public override string Validar()
        {
            string resultadoValidacao = "VALIDO";

            return resultadoValidacao;
        }
    }
}
