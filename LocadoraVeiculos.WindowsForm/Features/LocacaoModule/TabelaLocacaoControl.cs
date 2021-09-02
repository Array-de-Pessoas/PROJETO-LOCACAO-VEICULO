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

namespace LocadoraVeiculos.WindowsForm.Features.LocacaoModule
{
    public partial class TabelaLocacaoControl : UserControl
    {
        public TabelaLocacaoControl()
        {
            InitializeComponent();
            dataGridLocacao.ConfigurarGridZebrado();
            dataGridLocacao.ConfigurarGridSomenteLeitura();
            dataGridLocacao.Columns.AddRange(ObterColunas());
        }
        public DataGridViewColumn[] ObterColunas()
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
                dataGridLocacao.Rows.Add(locacao.Id,locacao.id_cliente, locacao.id_veiculo, locacao.dataLocacao, locacao.dataDevolucao, locacao.preco
                    );
            }
        }
    }
}
