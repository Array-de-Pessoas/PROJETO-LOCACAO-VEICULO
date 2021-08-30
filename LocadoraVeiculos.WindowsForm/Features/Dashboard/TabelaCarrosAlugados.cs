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
                new DataGridViewTextBoxColumn { DataPropertyName = "NOMECLIENTE", HeaderText = "CLIENTE"},

                new DataGridViewTextBoxColumn { DataPropertyName = "IDVEICULO", HeaderText = "VEÍCULO"},

            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return dataGridCarrosAlugados.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<Locacao> locacaos)
        {
            dataGridCarrosAlugados.Rows.Clear();

            foreach (Locacao item in locacaos)
            {
                dataGridCarrosAlugados.Rows.Add(item.Id, item.id_cliente, item.id_veiculo);
            }
        }
    }
}
