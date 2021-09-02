using LocadoraVeiculos.Dominio.LocacaoModule;
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
        public TabelaDevolucao()
        {
            InitializeComponent();
            dataGridDevolucao.ConfigurarGridZebrado();
            dataGridDevolucao.ConfigurarGridSomenteLeitura();
            dataGridDevolucao.Columns.AddRange(ObterColunas());
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
           {
                new DataGridViewTextBoxColumn { DataPropertyName = "id", HeaderText = "id"},
                new DataGridViewTextBoxColumn { DataPropertyName = "id_cliente", HeaderText = "Cliente"},
                new DataGridViewTextBoxColumn { DataPropertyName = "id_veiculo", HeaderText = "Veículo"},
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
                dataGridDevolucao.Rows.Add(devolucao.Id, devolucao.id_cliente, devolucao.id_veiculo, devolucao.dataLocacao, devolucao.dataDevolucao = DateTime.Now, devolucao.preco
                    );
            }
        }
    }
}
