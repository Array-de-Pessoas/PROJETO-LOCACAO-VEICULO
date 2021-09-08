
using LocadoraVeiculos.Dominio.LocacaoModule;
using LocadoraVeiculos.Dominio.VeiculoModule;
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
    public partial class TabelaCarrosAlugados : UserControl
    {
        public TabelaCarrosAlugados()
        {
            InitializeComponent();
            dataGridCarrosAlugados.ConfigurarGridZebrado();
            dataGridCarrosAlugados.ConfigurarGridSomenteLeitura();
            dataGridCarrosAlugados.Columns.AddRange(ObterColunas());
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
            return dataGridCarrosAlugados.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<Veiculo> carros)
        {
            dataGridCarrosAlugados.Rows.Clear();

            foreach (var item in carros)
            {
                dataGridCarrosAlugados.Rows.Add( item.marca, item.idGrupoVeiculo, item.Placa);
            }
        }
    }
}
