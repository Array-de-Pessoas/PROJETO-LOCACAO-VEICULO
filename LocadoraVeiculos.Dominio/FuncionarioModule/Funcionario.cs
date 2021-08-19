using LocadoraVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Dominio.FuncionarioModule
{
    public class Funcionario : EntidadeBase
    {
        public string Nome { get; }
        public string Usuario { get; }
        public string Senha { get; }
        public DateTime DataEntrada { get; }
        public decimal Salario { get; }

        public Funcionario()
        {
        }

        public Funcionario(string nome, string usuario, string senha, DateTime dataEntrada, decimal salario)
        {
            Nome = nome;
            Usuario = usuario;
            Senha = senha;
            DataEntrada = dataEntrada;
            Salario = salario;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Funcionario);
        }

        public bool Equals(Funcionario other)
        {
            return other != null
                && Id == other.Id
                && Nome == other.Nome
                && Usuario == other.Usuario
                && Senha == other.Senha
                && DataEntrada == other.DataEntrada
                && Salario == other.Salario;
        }

        public override int GetHashCode()
        {
            int hashCode = -477605619;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Usuario);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Senha);
            hashCode = hashCode * -1521134295 + DataEntrada.GetHashCode();
            hashCode = hashCode * -1521134295 + Salario.GetHashCode();
            return hashCode;
        }

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(Nome))
                resultadoValidacao = "O campo nome não pode estar vazio";

            if (string.IsNullOrEmpty(Usuario))
                resultadoValidacao = "O campo usuário não pode estar vazio";

            if (string.IsNullOrEmpty(Senha))
                resultadoValidacao = "O campo senha não pode estar vazio";

            if (DataEntrada > DateTime.Now)
                resultadoValidacao = "O campo data precisa ser menor que a data atual";

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }
    }
}
