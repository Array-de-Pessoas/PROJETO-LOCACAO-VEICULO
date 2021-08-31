using LocadoraVeiculos.Dominio.CarrosDisponiveisModule;
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
    public partial class TabelaCarrosDisponiveis : UserControl
    {
        public TabelaCarrosDisponiveis()
        {
            InitializeComponent();
            dataGridCarrosDisponiveis.ConfigurarGridZebrado();
            dataGridCarrosDisponiveis.ConfigurarGridSomenteLeitura();
            dataGridCarrosDisponiveis.Columns.AddRange(ObterColunas());
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Marca", HeaderText = "Marca"},

                new DataGridViewTextBoxColumn { DataPropertyName = "IdGrupoVeiculos", HeaderText = "ID do veículo"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Placa", HeaderText = "Placa"},

            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return dataGridCarrosDisponiveis.SelecionarId<int>();
        }

        internal void AtualizarRegistros(List<CarrosDisponiveis> carros)
        {
            dataGridCarrosDisponiveis.Rows.Clear();

            foreach (CarrosDisponiveis item in carros)
            {
                dataGridCarrosDisponiveis.Rows.Add(item.Id, item.Marca, item.IdGrupo, item.Placa);
            }
        }
    }
}
