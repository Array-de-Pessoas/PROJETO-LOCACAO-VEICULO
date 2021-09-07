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

namespace LocadoraVeiculos.WindowsForm.Features.LocacaoModule
{
    public partial class TabelaLocacaoControl : UserControl
    {
        ControladorCliente controladorCliente;
        ControladorVeiculo controladorVeiculo;

        public TabelaLocacaoControl()
        {
            InitializeComponent();
            dataGridLocacao.ConfigurarGridZebrado();
            dataGridLocacao.ConfigurarGridSomenteLeitura();
            dataGridLocacao.Columns.AddRange(ObterColunas());
            controladorVeiculo = new ControladorVeiculo();
            controladorCliente = new ControladorCliente();

        }
        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "id", HeaderText = "id"},
                new DataGridViewTextBoxColumn { DataPropertyName = "NomeCliente", HeaderText = "Nome do Cliente"},        
                new DataGridViewTextBoxColumn { DataPropertyName = "Placa", HeaderText = "Placa do Veículo"},
                new DataGridViewTextBoxColumn { DataPropertyName = "DataLocacao", HeaderText = "Data locação"},
                new DataGridViewTextBoxColumn { DataPropertyName = "DataDevolucao", HeaderText = "Data devolução"},
                //new DataGridViewTextBoxColumn { DataPropertyName = "Preco", HeaderText = "Preço"},         
            };

            return colunas;
        }
        public int ObtemIdSelecionado()
        {
            return dataGridLocacao.SelecionarId<int>();
        }
        public void AtualizarRegistros(List<Locacao> locacoes)
        {
            dataGridLocacao.Rows.Clear();

            List<Locacao> locacaoesAbertas = new List<Locacao>();

            foreach (var locacao in locacoes)
            {
                bool locacaoEstaAberta = locacao.locacaoAtiva == 1;
                if (locacaoEstaAberta)
                {
                    locacaoesAbertas.Add(locacao);
                }
            }

            foreach (var locacao in locacaoesAbertas)
            {
                Cliente cliente = controladorCliente.SelecionarPorId(locacao.id_cliente);
                var veiculo = controladorVeiculo.SelecionarPorId(locacao.id_veiculo);

                dataGridLocacao.Rows.Add(locacao.Id, cliente.NomeCliente, veiculo.Placa, locacao.dataLocacao, locacao.dataDevolucao);
            }
        }
    }
}
