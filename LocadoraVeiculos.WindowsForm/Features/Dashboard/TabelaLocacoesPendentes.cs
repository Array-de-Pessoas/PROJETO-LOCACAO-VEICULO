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
                new DataGridViewTextBoxColumn { DataPropertyName = "CLIENTE", HeaderText = "CLIENTE"},

                new DataGridViewTextBoxColumn { DataPropertyName = "DATADEVOLUCAO", HeaderText = "DATA DE DEVOLUÇÃO"},

                new DataGridViewTextBoxColumn { DataPropertyName = "VEICULO", HeaderText = "VEÍCULO"},

                new DataGridViewTextBoxColumn { DataPropertyName = "PRECO", HeaderText = "PREÇO"},

            };

            return colunas;
        }
    }
}
