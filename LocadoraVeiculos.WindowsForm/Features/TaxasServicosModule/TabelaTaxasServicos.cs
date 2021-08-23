using LocadoraVeiculos.Dominio.TaxasServicosModule;
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

namespace LocadoraVeiculos.WindowsForm.Features.TaxasServicosModule
{
    public partial class TabelaTaxasServicos : UserControl
    {
        public TabelaTaxasServicos()
        {
            InitializeComponent();
            dataGridTaxasServicos.ConfigurarGridZebrado();
            dataGridTaxasServicos.ConfigurarGridSomenteLeitura();
            dataGridTaxasServicos.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "ID", HeaderText = "ID"},

                new DataGridViewTextBoxColumn { DataPropertyName = "TIPOTAXA", HeaderText = "TIPOTAXA"},

                new DataGridViewTextBoxColumn { DataPropertyName = "NOME", HeaderText = "NOME"},

                new DataGridViewTextBoxColumn { DataPropertyName = "VALOR", HeaderText = "VALOR"},

            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return dataGridTaxasServicos.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<TaxasServicos> taxas)
        {
            dataGridTaxasServicos.Rows.Clear();

            foreach (TaxasServicos item in taxas)
            {
                dataGridTaxasServicos.Rows.Add(item.Id, item.TipoTaxa, item.Nome, item.Valor);
            }
        }
    }
}
