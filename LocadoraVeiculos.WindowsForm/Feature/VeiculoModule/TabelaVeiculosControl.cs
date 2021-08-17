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

namespace LocadoraVeiculos.WindowsForm.Feature.VeiculoModule
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Placa", HeaderText = "Placa"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Cor", HeaderText = "Cor"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Marca", HeaderText = "Marca"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Placa", HeaderText = "Placa"},
                new DataGridViewTextBoxColumn { DataPropertyName = "TipoCombustivel", HeaderText = "Tipo Combustível"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Imagem", HeaderText = "Imagem"},
                new DataGridViewTextBoxColumn { DataPropertyName = "QuantidadeLitros", HeaderText = "Quantidade de Litros"},
                new DataGridViewTextBoxColumn { DataPropertyName = "NumeroPortas", HeaderText = "Número de Portas"},
                new DataGridViewTextBoxColumn { DataPropertyName = "CapacidadePessoas", HeaderText = "Capacidade de Pessoas"},
                new DataGridViewTextBoxColumn { DataPropertyName = "TamanhoPortaMalas", HeaderText = "Tamanho do Porta-malas"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Kilometragem", HeaderText = "Kilometragem"},
                new DataGridViewTextBoxColumn { DataPropertyName = "IdGrupoVeiculo", HeaderText = "Grupo de veículo"},

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
                dataGridVeiculo.Rows.Add(veiculo.Id, veiculo.placa, veiculo.cor,veiculo.marca,veiculo.ano,veiculo.tipoCombustivel,veiculo.foto,veiculo.quantidadeLitros,veiculo.numeroPortas,veiculo.capacidadeDePessoas,veiculo.tamanhoPortaMalas,veiculo.kilometragem, veiculo.idGrupoVeiculo);
            }
        }
    }
}
