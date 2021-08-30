﻿using LocadoraVeiculos.WindowsForm.Shared;
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
                new DataGridViewTextBoxColumn { DataPropertyName = "CLIENTE", HeaderText = "CLIENTE"},

                new DataGridViewTextBoxColumn { DataPropertyName = "NOME", HeaderText = "NOME"},

                new DataGridViewTextBoxColumn { DataPropertyName = "MARCA", HeaderText = "MARCA"},

                new DataGridViewTextBoxColumn { DataPropertyName = "GRUPOVEICULO", HeaderText = "GRUPO DO VEÍCULO"},

                new DataGridViewTextBoxColumn { DataPropertyName = "PLACA", HeaderText = "PLACA"},

            };

            return colunas;
        }
    }
}
