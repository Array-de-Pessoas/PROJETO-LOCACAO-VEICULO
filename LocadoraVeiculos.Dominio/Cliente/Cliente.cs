using LocadoraVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Dominio
{
    public class Cliente : EntidadeBase
    {
        string NomeCliente { get; set; }
        string Endereco { get; set; }
        string Telefone { get; set; }
        string CPFDoCliente { get; set; }
        string CNPJ { get; set; }
        string CPFDoCondutor { get; set; }
        string RGDoCondutor { get; set; }
        string CNH { get; set; }
        string NomeDoCondutor { get; set; }
        DateTime DataValidadeCNH { get; set; }
        //cliente não e o condutor
        public Cliente(string NomeCliente, string Endereco, string Telefone, string CPFDoCliente, string CNPJ, string CPFDoCondutor, string RGDoCondutor, string CNH, string NomeDoCondutor, DateTime DataValidadeCNH)
        {
            this.NomeCliente = NomeCliente;
            this.Endereco = Endereco;
            this.Telefone = Telefone;
            this.CPFDoCliente = CPFDoCliente;
            this.CNPJ = CNPJ;
            this.CPFDoCondutor = CPFDoCondutor;
            this.RGDoCondutor = RGDoCondutor;
            this.CNH = CNH;
            this.NomeDoCondutor = NomeDoCondutor;
            this.DataValidadeCNH = DataValidadeCNH;
        }

        //cliente é o condutor
        public Cliente(string nomeCliente, string endereco, string telefone, string cPFDoCliente, string cNPJ, string rGDoCondutor, string cNH, DateTime dataValidadeCNH)
        {
            NomeCliente = nomeCliente;
            Endereco = endereco;
            Telefone = telefone;
            CPFDoCliente = cPFDoCliente;
            CNPJ = cNPJ;
            RGDoCondutor = rGDoCondutor;
            CNH = cNH;
            DataValidadeCNH = dataValidadeCNH;
        }

        public override string Validar()
        {
            if (string.IsNullOrEmpty(NomeCliente))
            {
                return "Nome do cliente não pode ser nulo";
            }
            else if (string.IsNullOrEmpty(Endereco))
            {
                return "Endereço do cliente não pode ser nulo";
            }
            else if (string.IsNullOrEmpty(Telefone))
            {
                return "Endereço do cliente não pode ser nulo";
            }
            return Validar();
        }
    }
}
