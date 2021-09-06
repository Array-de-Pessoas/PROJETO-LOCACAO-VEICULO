using LocadoraVeiculos.Dominio.CupomModule;
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

namespace LocadoraVeiculos.WindowsForm.Features.CupomModule
{
    public partial class TabelaCupom : UserControl
    {
        public TabelaCupom()
        {
            InitializeComponent();
            dataGridCupom.ConfigurarGridZebrado();
            dataGridCupom.ConfigurarGridSomenteLeitura();
            dataGridCupom.Columns.AddRange(ObterColunas());
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
           {
                new DataGridViewTextBoxColumn { DataPropertyName = "ID", HeaderText = "ID"},

                new DataGridViewTextBoxColumn { DataPropertyName = "CODIGO", HeaderText = "Código"},

                new DataGridViewTextBoxColumn { DataPropertyName = "TIPO", HeaderText = "Tipo"},

                new DataGridViewTextBoxColumn { DataPropertyName = "VALOR", HeaderText = "Valor"},

                new DataGridViewTextBoxColumn { DataPropertyName = "QUANTIDADEUSO", HeaderText = "Quantidade de uso"},
           };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return dataGridCupom.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<Cupom> cupom)
        {
            dataGridCupom.Rows.Clear();

            foreach (Cupom item in cupom)
            {
                dataGridCupom.Rows.Add(item.Id, item.Codigo, item.Tipo, item.Valor, item.QuantidadeUso);
            }
        }
    }
}
