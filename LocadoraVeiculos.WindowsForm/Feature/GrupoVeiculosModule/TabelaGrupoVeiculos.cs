using LocadoraVeiculos.Dominio.GrupoVeiculosModule;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForm
{
    public partial class TabelaGrupoVeiculos : UserControl
    {
        public TabelaGrupoVeiculos()
        {
            InitializeComponent();
            dataGridGrupoVeiculos.ConfigurarGridZebrado();
            dataGridGrupoVeiculos.ConfigurarGridSomenteLeitura();
            dataGridGrupoVeiculos.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Grupo", HeaderText = "Grupo"},

            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return dataGridGrupoVeiculos.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<GrupoVeiculos> grupos)
        {
            dataGridGrupoVeiculos.Rows.Clear();

            foreach (GrupoVeiculos grupo in grupos)
            {
                dataGridGrupoVeiculos.Rows.Add(grupo.Id, grupo.Grupo);
                    
            }
        }
    }
}
