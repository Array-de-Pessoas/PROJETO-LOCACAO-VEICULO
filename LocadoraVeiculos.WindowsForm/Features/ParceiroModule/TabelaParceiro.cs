using LocadoraVeiculos.Dominio.ParceiroModule;
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

namespace LocadoraVeiculos.WindowsForm.Features.ParceiroModule
{
    public partial class TabelaParceiro : UserControl
    {
        public TabelaParceiro()
        {
            InitializeComponent();
            dataGridParceiro.ConfigurarGridZebrado();
            dataGridParceiro.ConfigurarGridSomenteLeitura();
            dataGridParceiro.Columns.AddRange(ObterColunas());
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "ID", HeaderText = "ID"},

                new DataGridViewTextBoxColumn { DataPropertyName = "NOMEPARCEIRO", HeaderText = "Nome do parceiro"},

            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return dataGridParceiro.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<Parceiro> parceiro)
        {
            dataGridParceiro.Rows.Clear();

            foreach (Parceiro item in parceiro)
            {
                dataGridParceiro.Rows.Add(item.Id, item.NomeParceiro);
            }
        }
    }
}
