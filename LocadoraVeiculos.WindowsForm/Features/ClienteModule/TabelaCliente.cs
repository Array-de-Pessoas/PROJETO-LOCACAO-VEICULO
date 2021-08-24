using LocadoraVeiculos.Dominio;
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

namespace LocadoraVeiculos.WindowsForm.Features.ClienteModule
{
    public partial class TabelaCliente : UserControl
    {
        public TabelaCliente()
        {
            InitializeComponent();
            dataGridCliente.ConfigurarGridZebrado();
            dataGridCliente.ConfigurarGridSomenteLeitura();
            dataGridCliente.Columns.AddRange(ObterColunas());
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "ID", HeaderText = "ID"},

                new DataGridViewTextBoxColumn { DataPropertyName = "NOME", HeaderText = "NOME"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ENDERECO", HeaderText = "ENDERECO"},

                new DataGridViewTextBoxColumn { DataPropertyName = "TELEFONE", HeaderText = "TELEFONE"},

                new DataGridViewTextBoxColumn { DataPropertyName = "CPFOUCNPJ", HeaderText = "CPFOUCNPJ"},

                new DataGridViewTextBoxColumn { DataPropertyName = "NOMECONDUTOR", HeaderText = "NOMECONDUTOR"},

                new DataGridViewTextBoxColumn { DataPropertyName = "CNH", HeaderText = "CNH"},

                new DataGridViewTextBoxColumn { DataPropertyName = "CPFCONDUTOR", HeaderText = "CPFCONDUTOR"},

                new DataGridViewTextBoxColumn { DataPropertyName = "RG", HeaderText = "RG"},

                new DataGridViewTextBoxColumn { DataPropertyName = "DATAVALIDADECNH", HeaderText = "DATAVALIDADECNH"},

            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return dataGridCliente.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<Cliente> clientes)
        {
            dataGridCliente.Rows.Clear();

            foreach (Cliente item in clientes)
            {
                dataGridCliente.Rows.Add(item.Id, item.NomeDoCondutor, item.Endereco, item.Telefone, item.TipoDeIdentidade, item.NomeDoCondutor, item.CNH, item.CPFDoCondutor, item.RGDoCondutor, item.DataValidadeCNH);
            }
        }
    }
}
