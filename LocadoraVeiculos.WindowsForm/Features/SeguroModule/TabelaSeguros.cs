using LocadoraVeiculos.Dominio.SegurosModule;
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

namespace LocadoraVeiculos.WindowsForm.Features.SeguroModule
{
    public partial class TabelaSeguros : UserControl
    {
        public TabelaSeguros()
        {
            InitializeComponent();
            dataGridSeguros.ConfigurarGridZebrado();
            dataGridSeguros.ConfigurarGridSomenteLeitura();
            dataGridSeguros.Columns.AddRange(ObterColunas());
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "ID", HeaderText = "ID"},

                new DataGridViewTextBoxColumn { DataPropertyName = "TIPOSEGURO", HeaderText = "TIPOSEGURO"},

                new DataGridViewTextBoxColumn { DataPropertyName = "VALOR", HeaderText = "VALOR"},

            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return dataGridSeguros.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<Seguros> seguros)
        {
            dataGridSeguros.Rows.Clear();

            foreach (Seguros item in seguros)
            {
                dataGridSeguros.Rows.Add(item.Id, item.TipoSeguro, item.Valor);
            }
        }
    }
}
