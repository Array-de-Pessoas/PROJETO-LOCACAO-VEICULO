using LocadoraVeiculos.Controladores.ClienteModule;
using LocadoraVeiculos.Controladores.VeiculoModule;
using LocadoraVeiculos.Dominio;
using LocadoraVeiculos.Dominio.LocacaoModule;
using LocadoraVeiculos.Dominio.VeiculoModule;
using LocadoraVeiculos.WindowsForm.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForm.Features.Devolucao
{
    public partial class TabelaDevolucao : UserControl
    {
        ControladorCliente controladorCliente;
        ControladorVeiculo controladorVeiculo;
        public TabelaDevolucao()
        {
            InitializeComponent();
            dataGridDevolucao.ConfigurarGridZebrado();
            dataGridDevolucao.ConfigurarGridSomenteLeitura();
            dataGridDevolucao.Columns.AddRange(ObterColunas());
            controladorVeiculo = new ControladorVeiculo();
            controladorCliente = new ControladorCliente();
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
           {
                new DataGridViewTextBoxColumn { DataPropertyName = "id", HeaderText = "id"},
                new DataGridViewTextBoxColumn { DataPropertyName = "NomeCliente", HeaderText = "Nome do Cliente"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Placa", HeaderText = "Placa do Veículo"},
                new DataGridViewTextBoxColumn { DataPropertyName = "DataLocacao", HeaderText = "Data locação"},
                new DataGridViewTextBoxColumn { DataPropertyName = "DataDevolucao", HeaderText = "Data devolução"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Preco", HeaderText = "Preço"},
           };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return dataGridDevolucao.SelecionarId<int>();
        }
        public void AtualizarRegistros(List<Locacao> locacoes)
        {
            dataGridDevolucao.Rows.Clear();

            List<Locacao> devolucoes = new List<Locacao>();

            foreach (var locacao in locacoes)
            {
                if (locacao.locacaoAtiva == 0)
                {
                    devolucoes.Add(locacao);
                }
            }

            foreach (var devolucao in devolucoes)
            {
                Cliente cliente = controladorCliente.SelecionarPorId(devolucao.id_cliente);
                Veiculo veiculo = controladorVeiculo.SelecionarPorId(devolucao.id_veiculo);

                dataGridDevolucao.Rows.Add(devolucao.Id, cliente.NomeCliente, veiculo.Placa, devolucao.dataLocacao, devolucao.dataDevolucao, devolucao.preco); 
            }
        }
    }
}
