using LocadoraVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Dominio.LocacaoModule
{
    public class Locacao : EntidadeBase
    {
        public int id_cliente;
        public int id_veiculo;
        public int id_taxa;
        public int id_seguro;
        public DateTime dataLocacao;
        public DateTime dataDevolucao;
        public DateTime dataDevolucaoRealizada;
        public bool locacaoAtiva;
        public double preco;
        public string plano;

        public Locacao(int id_cliente, int id_veiculo, int id_taxa, int id_seguro, double preco, DateTime dataLocacao, DateTime dataDevolucao, string plano, DateTime dataDevolucaoRealizada, bool locacaoAtiva)
        {
            this.plano = plano;
            this.id_cliente = id_cliente;
            this.id_veiculo = id_veiculo;
            this.id_seguro = id_seguro;
            this.id_taxa = id_taxa;
            this.preco = preco;
            this.dataLocacao = dataLocacao;
            this.dataDevolucaoRealizada = dataDevolucaoRealizada;
            this.locacaoAtiva = locacaoAtiva;
            this.dataDevolucao = dataDevolucao;
        }

        public override string Validar()
        {
            if (id_cliente == 0)
            {
                return "O campo Cliente é obrigatório";
            }
            if (id_veiculo == 0)
            {
                return "O campo Veículo é obrigatório";
            }
            if (id_taxa == 0)
            {
                return "O campo Taxa é obrigatório";
            }
            if (id_seguro == 0)
            {
                return "O campo Seguro é obrigatório";
            }
            if (string.IsNullOrEmpty(plano))
            {
                return "O campo Plano é obrigatório";
            }
            if (dataLocacao == DateTime.MinValue)
            {
                return "O campo Data da Locação é obrigatório";
            }
            if (dataDevolucao == DateTime.MinValue)
            {
                return "O campo Data de devolução é obrigatório";
            }          
            return "VALIDO";
        }
    }
}
