using LocadoraVeiculos.Controladores.LocacaoModule;
using LocadoraVeiculos.Controladores.VeiculoModule;
using LocadoraVeiculos.Dominio.LocacaoModule;
using LocadoraVeiculos.Dominio.VeiculoModule;
using LocadoraVeiculos.WindowsForm.Features.GrupoVeiculosModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForm.Features.LocacaoModule
{
    public partial class TelaDevolucaoForm : Form
    {
        ControladorVeiculo controladorVeiculo = null;
        Veiculo veiculos;

        public TelaDevolucaoForm()
        {
            InitializeComponent();
            controladorVeiculo = new ControladorVeiculo();
        }

        public Veiculo Veiculo
        {
            get { return veiculos; }

            set
            {
                veiculos = value;

                txtQuilometragem.Text = veiculos.kilometragem.ToString();
            }
        }

        private void TelaDevolucaoForm_Load(object sender, EventArgs e)
        {
            txtId.Text = TelaLocacaoForm.PegarId;
            txtDataLocacao.Text = TelaLocacaoForm.PegarDataLocacao;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            List<Veiculo> veiculo = controladorVeiculo.SelecionarTodos();

            foreach (var item in veiculo)
            {
                if (item.Id == TelaLocacaoForm.PegarIdVeiculo)
                {
                    string Placa = item.Placa;
                    string Cor = item.cor;
                    string Marca = item.marca;
                    int Ano = item.ano;
                    string TipoCombustivel = item.tipoCombustivel;
                    byte[] QLitros = item.foto;
                    int Portas = item.numeroPortas;
                    int Pessoas = item.capacidadeDePessoas;
                    int PortaMalas = 5;
                    string imagem = Convert.ToString(item.foto);
                    int Quilometragem = Convert.ToInt32(txtQuilometragem.Text);
                    int IdGrupo = item.idGrupoVeiculo;

                    veiculos = new Veiculo(Placa, Cor, Marca, Ano, TipoCombustivel, QLitros, Portas, Pessoas, PortaMalas, imagem, Quilometragem, IdGrupo);

                    if (veiculos.Validar() != "ESTA_VALIDO")
                    {
                        string primeiroErro = new StringReader(veiculos.Validar()).ReadLine();
                        TelaPrincipal.Instancia.AtualizarRodape(primeiroErro);
                        DialogResult = DialogResult.None;
                    }
                }

            }

            
            
        }

    }
}
