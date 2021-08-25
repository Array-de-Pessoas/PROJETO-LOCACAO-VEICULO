﻿using LocadoraVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.Dominio.LocacaoModule
{
    public class Locacao : EntidadeBase
    {
        public int id_cliente;
        public int id_veiculo;
        public int id_taxas;
        public DateTime dataLocacao;
        public DateTime dataDevolucao;
        public double preco;
        public override string Validar()
        {
            if (id_cliente == 0)
            {
                return "O campo Cliente é obrigatório";
            }
            if (id_veiculo == 0)
            {
                return "O campo Veículo é obrigatório";
            }
            if (dataLocacao == DateTime.MinValue)
            {
                return "O campo Data da Locação é obrigatório";
            }
            if (dataDevolucao == DateTime.MinValue)
            {
                return "O campo Data de devolução é obrigatório";
            }
            if (preco == 0)
            {
                return "O campo Cliente é obrigatório";
            }
            return "VALIDO";
        }
    }
}

