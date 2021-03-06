using LocadoraVeiculos.Dominio.CupomModule;
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
        public DateTime? dataDevolucaoRealizada;
        public int locacaoAtiva;
        public double preco;
        public string plano;
        public Cupom cupom;

        public Locacao(int id_cliente, int id_veiculo, int id_taxa, int id_seguro, double preco, DateTime dataLocacao, DateTime dataDevolucao, string plano, DateTime? dataDevolucaoRealizada, int locacaoAtiva, Cupom cupom)
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
            this.cupom = cupom;
        }

        public override string Validar()
        {
            string resultadoValidacao = "";

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
            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }
    }
}
