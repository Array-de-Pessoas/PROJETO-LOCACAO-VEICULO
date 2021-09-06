using LocadoraVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Dominio.CupomModule
{
    public class Cupom : EntidadeBase, IEquatable<Cupom>
    {
        public string Codigo { get; }
        public string Tipo { get; }
        public decimal Valor { get; }
        public decimal ValorMinimo { get; }
        public string Parceiro { get; }
        public DateTime DiaVencimento { get; }
        public int QuantidadeUso { get; }

        public Cupom(string codigo, string tipo, decimal valor, decimal valorMinimo, string parceiro, DateTime diaVencimento, int quantidade)
        {
            Codigo = codigo;
            Tipo = tipo;
            Valor = valor;
            ValorMinimo = valorMinimo;
            Parceiro = parceiro;
            DiaVencimento = diaVencimento;
            QuantidadeUso = quantidade;
        }

        public bool Equals(Cupom other)
        {
            return other != null &&
                   Id == other.Id &&
                   Codigo == other.Codigo &&
                   Tipo == other.Tipo &&
                   Valor == other.Valor &&
                   ValorMinimo == other.ValorMinimo &&
                   Parceiro == other.Parceiro &&
                   DiaVencimento == other.DiaVencimento &&
                   QuantidadeUso == other.QuantidadeUso;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Cupom);
        }

        public override int GetHashCode()
        {
            int hashCode = -677046642;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Codigo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Tipo);
            hashCode = hashCode * -1521134295 + EqualityComparer<decimal>.Default.GetHashCode(Valor);
            hashCode = hashCode * -1521134295 + EqualityComparer<decimal>.Default.GetHashCode(ValorMinimo);
            hashCode = hashCode * -1521134295 + EqualityComparer<DateTime>.Default.GetHashCode(DiaVencimento);
            hashCode = hashCode * -1521134295 + EqualityComparer<int>.Default.GetHashCode(QuantidadeUso);
            return hashCode;
        }

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(Codigo))
                resultadoValidacao = "                                                     O campo código não pode estar vazio";

            if (string.IsNullOrEmpty(Tipo))
                resultadoValidacao = "                                                     O campo tipo não pode estar vazio";

            if (Valor == 0)
                resultadoValidacao = "                                                     O campo valor não pode ser 0";

            if (ValorMinimo == 0)
                resultadoValidacao = "                                                     O campo valor mínimo não pode ser 0";

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }
    }
}
