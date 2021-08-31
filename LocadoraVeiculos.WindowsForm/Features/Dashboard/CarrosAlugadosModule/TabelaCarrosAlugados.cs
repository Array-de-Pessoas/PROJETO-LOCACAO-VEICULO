using LocadoraVeiculos.Dominio.CarrosAlugadosModule;
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
                new DataGridViewTextBoxColumn { DataPropertyName = "NOMECLIENTE", HeaderText = "ID do cliente"},

                new DataGridViewTextBoxColumn { DataPropertyName = "IDVEICULO", HeaderText = "ID do veículo"},

            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return dataGridCarrosAlugados.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<CarrosAlugados> carros)
        {
            dataGridCarrosAlugados.Rows.Clear();

            foreach (CarrosAlugados item in carros)
            {
                dataGridCarrosAlugados.Rows.Add(item.Id, item.IdCliente, item.IdVeiculo);
            }
        }
    }
}
