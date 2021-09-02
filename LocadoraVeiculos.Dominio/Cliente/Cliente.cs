using LocadoraVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Dominio
{
    public class Cliente : EntidadeBase, IEquatable<Cliente>
    {
        public string NomeCliente { get; }
        public string Endereco { get;}
        public string Telefone { get;}
        public string Email { get; }
        public string TipoDeIdentidade { get;}
        public string CPFDoCondutor { get;}
        public string RGDoCondutor { get;}
        public string CNH { get;}
        public string NomeDoCondutor { get;}
        public DateTime DataValidadeCNH { get;}

        
        public Cliente(string nomeCliente, string endereco, string telefone, string email, string tipoDeIdentidade, string nomeDoCondutor, string cpfCondutor, string rGDoCondutor, string cNH, DateTime dataValidadeCNH)
        {
            NomeCliente = nomeCliente;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            TipoDeIdentidade = tipoDeIdentidade;
            NomeDoCondutor = nomeDoCondutor;
            CNH = cNH;
            CPFDoCondutor = cpfCondutor;
            RGDoCondutor = rGDoCondutor;
            DataValidadeCNH = dataValidadeCNH;
        }

        public bool Equals(Cliente other)
        {
            return other != null &&
                   Id == other.Id &&
                   NomeCliente == other.NomeCliente &&
                   Endereco == other.Endereco &&
                   Telefone == other.Telefone &&
                   Email == other.Email &&
                   TipoDeIdentidade == other.TipoDeIdentidade &&
                   NomeDoCondutor == other.NomeDoCondutor &&
                   CNH == other.CNH &&
                   CPFDoCondutor == other.CPFDoCondutor &&
                   RGDoCondutor == other.RGDoCondutor &&
                   DataValidadeCNH == other.DataValidadeCNH;
        }

        public override int GetHashCode()
        {
            int hashCode = -677046642;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NomeCliente);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Endereco);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Telefone);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TipoDeIdentidade);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NomeDoCondutor);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CNH);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CPFDoCondutor);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(RGDoCondutor);
            hashCode = hashCode * -1521134295 + DataValidadeCNH.GetHashCode();
            return hashCode;
        }

        public override string Validar()
        {
            Regex templateEmail = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(NomeCliente))
            {
                return "                                                     O campo nome do cliente não pode estar vazio";
            }
            else if (string.IsNullOrEmpty(Endereco))
            {
                return "                                                     O campo endereço não pode estar vazio";
            }
            else if (string.IsNullOrEmpty(Telefone))
            {
                return "                                                     O campo telefone não pode estar vazio";
            }
            else if (string.IsNullOrEmpty(Email))
            {
                return "                                                     O campo email não pode estar vazio";
            }
            else if (string.IsNullOrEmpty(TipoDeIdentidade))
            {
                return "                                                     O campo tipo de identidade não pode estar vazio";
            }
            else if (string.IsNullOrEmpty(NomeDoCondutor))
            {
                return "                                                     O campo nome do condutor não pode estar vazio";
            }
            else if (string.IsNullOrEmpty(CNH))
            {
                return "                                                     O campo CNH não pode estar vazio";
            }
            else if (string.IsNullOrEmpty(CPFDoCondutor))
            {
                return "                                                     O campo CPF do condutor não pode estar vazio";
            }
            else if (string.IsNullOrEmpty(RGDoCondutor))
            {
                return "                                                     O campo RG não pode estar vazio";
            }
            else if(templateEmail.IsMatch(Email) == false)
                return "                                                     O campo Email está inválido";
            

            return resultadoValidacao;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Cliente);
        }
    }
}
