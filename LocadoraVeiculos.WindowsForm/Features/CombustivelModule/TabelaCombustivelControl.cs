using LocadoraVeiculos.Dominio.CombustivelModule;
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

namespace LocadoraVeiculos.WindowsForm.Features.CombustivelModule
{
    public partial class TabelaCombustivelControl : UserControl
    {
        public TabelaCombustivelControl()
        {
            InitializeComponent();
            dataGridCombustivel.ConfigurarGridZebrado();
            dataGridCombustivel.ConfigurarGridSomenteLeitura();
            dataGridCombustivel.Columns.AddRange(ObterColunas());
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "ID", HeaderText = "ID"},

                new DataGridViewTextBoxColumn { DataPropertyName = "TIPOCOMBUSTIVEL", HeaderText = "TIPOCOMBUSTIVEL"},

                new DataGridViewTextBoxColumn { DataPropertyName = "VALOR", HeaderText = "VALOR"},
            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return dataGridCombustivel.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<Combustivel> taxas)
        {
            dataGridCombustivel.Rows.Clear();

            foreach (Combustivel item in taxas)
            {
                dataGridCombustivel.Rows.Add(item.Id, item.TipoCombustivel, item.Valor);
            }
        }
    }
}
