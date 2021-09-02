using LocadoraVeiculos.Dominio.LocacaoModule;
using LocadoraVeiculos.Dominio.LocacoesPendentesModule;
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

namespace LocadoraVeiculos.WindowsForm.Features.Dashboard
{
    public partial class TabelaLocacoesPendentes : UserControl
    {
        public TabelaLocacoesPendentes()
        {
            InitializeComponent();
            dataGridLocacoesPendentes.ConfigurarGridZebrado();
            dataGridLocacoesPendentes.ConfigurarGridSomenteLeitura();
            dataGridLocacoesPendentes.Columns.AddRange(ObterColunas());
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "NOMECLIENTE", HeaderText = "ID do cliente"},

                new DataGridViewTextBoxColumn { DataPropertyName = "NOMEVEICULO", HeaderText = "ID do veículo"},

                new DataGridViewTextBoxColumn { DataPropertyName = "DATALOCACAO", HeaderText = "Data de locação"},

                new DataGridViewTextBoxColumn { DataPropertyName = "DATADEVOLUCAO", HeaderText = "Data de devolução"},

            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return dataGridLocacoesPendentes.SelecionarId<int>();
        }

        internal void AtualizarRegistros(List<Locacao> locacoes)
        {
            dataGridLocacoesPendentes.Rows.Clear();

            foreach (var item in locacoes)
            {
                dataGridLocacoesPendentes.Rows.Add(item.id_cliente, item.id_veiculo, item.dataLocacao, item.dataDevolucao);
            }
        }
    }
}
