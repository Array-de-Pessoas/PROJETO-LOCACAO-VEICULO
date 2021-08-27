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

namespace LocadoraVeiculos.WindowsForm.Features.GrupoVeiculosModule
{
    public partial class TabelaVeiculosControl : UserControl
    {
        public TabelaVeiculosControl()
        {
            InitializeComponent();
            dataGridVeiculo.ConfigurarGridZebrado();
            dataGridVeiculo.ConfigurarGridSomenteLeitura();
            dataGridVeiculo.Columns.AddRange(ObterColunas());
        }
        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Kilometragem", HeaderText = "Kilometragem"},                          
                new DataGridViewTextBoxColumn { DataPropertyName = "Marca", HeaderText = "Marca"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Placa", HeaderText = "Placa"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Cor", HeaderText = "Cor"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Ano", HeaderText = "Ano"},                                  
                
            };

            return colunas;
        }
        public int ObtemIdSelecionado()
        {
            return dataGridVeiculo.SelecionarId<int>();
        }
        public void AtualizarRegistros(List<Veiculo> veiculos)
        {
            dataGridVeiculo.Rows.Clear();

            foreach (Veiculo veiculo in veiculos)
            {
                dataGridVeiculo.Rows.Add(veiculo.Id,veiculo.kilometragem,veiculo.marca,veiculo.placa,veiculo.cor,
                    veiculo.ano
                    );
            }
        }
    }
}
