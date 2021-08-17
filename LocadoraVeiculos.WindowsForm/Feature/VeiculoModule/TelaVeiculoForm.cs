using LocadoraVeiculos.Controladores.VeiculoModule;
using LocadoraVeiculos.Dominio.VeiculoModule;
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
    public partial class TelaVeiculoForm : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        ControladorVeiculo controladorVeiculo = new ControladorVeiculo();
        Veiculo veiculo;
        public TelaVeiculoForm()
        {
            InitializeComponent();
        }

        private void VeiculoForm_Load(object sender, EventArgs e)
        {
            //List<Veiculo> veiculos = controladorVeiculo.SelecionarTodos();
            //foreach (var item in veiculos)
            //{
            //    cbTipoVeiculo.Items.Insert(item.Id,item.ano);           
            //}            
        }
        public Veiculo Veiculo
        {
            get { return veiculo; }

            set
            {
                veiculo = value;

                txtId.Text = veiculo.Id.ToString();
                txtPlaca.Text = veiculo.placa;
                txtCor.Text = veiculo.cor;
                txtMarca.Text = veiculo.marca;
                txtTipoCombustivel.Text = veiculo.tipoCombustivel;
                pictureBox.Image = veiculo.foto;
                txtQuantidadeLitros.Text = veiculo.quantidadeLitros.ToString();
                txtCapacidadePessoas.Text = veiculo.capacidadeDePessoas.ToString();
                txtAno.Text = veiculo.ano.ToString();
                txtPortas.Text = veiculo.numeroPortas.ToString();
                txtTamanhoPortaMalas.Text = veiculo.tamanhoPortaMalas;
                txtKm.Text = veiculo.kilometragem.ToString();
                cbTipoVeiculo.SelectedIndex = veiculo.idGrupoVeiculo;
                
            }
        }
        private void btnAdicionarImagem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            string cor = txtCor.Text;
            string marca = txtMarca.Text;
            int ano = Convert.ToInt32(txtAno.Text);
            string tipoCombustivel = txtTipoCombustivel.Text;
            Image image = pictureBox.Image;
            double quantidadeLitros = Convert.ToDouble(txtQuantidadeLitros.Text);
            int numeroPortas = Convert.ToInt32(txtPortas.Text);
            int capacidadePessoas = Convert.ToInt32(txtCapacidadePessoas.Text);
            string tamanhoPortaMalas = txtTamanhoPortaMalas.Text;
            int kilometragem = Convert.ToInt32(txtKm.Text);
            int id_grupoVeiculo = Convert.ToInt32(cbTipoVeiculo.SelectedIndex);
            Veiculo veiculo = new Veiculo(placa,cor,marca,ano,tipoCombustivel,image,quantidadeLitros,numeroPortas,capacidadePessoas,tamanhoPortaMalas,kilometragem,id_grupoVeiculo);
            controladorVeiculo.InserirNovo(veiculo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
