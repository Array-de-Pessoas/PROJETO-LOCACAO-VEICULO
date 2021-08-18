using LocadoraVeiculos.Controladores.GrupoVeiculosModule;
using LocadoraVeiculos.Controladores.VeiculoModule;
using LocadoraVeiculos.Dominio.GrupoVeiculosModule;
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

namespace LocadoraVeiculos.WindowsForm.Features.GrupoVeiculosModule
{
    public partial class TelaVeiculoForm : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        ControladorVeiculo controladorVeiculo = new ControladorVeiculo();
        ControladorGrupoVeiculos controladorGrupoVeiculos = new ControladorGrupoVeiculos();
        Veiculo veiculo;
        public TelaVeiculoForm()
        {
            InitializeComponent();
        }
        private void VeiculoForm_Load(object sender, EventArgs e)
        {
            CarregarComboBox();

        }
        private void CarregarComboBox()
        {
            List<GrupoVeiculos> grupoVeiculos = controladorGrupoVeiculos.SelecionarTodos();

            cbTipoVeiculo.DisplayMember = "Grupo";
            cbTipoVeiculo.ValueMember = "Id";
            cbTipoVeiculo.DataSource = grupoVeiculos;
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
                cbTipoVeiculo.SelectedValue = veiculo.idGrupoVeiculo;

            }
        }
        private void btnAdicionarImagem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                btnAdicionarImagem.Visible = false;
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
            int id_grupoVeiculo = Convert.ToInt32(cbTipoVeiculo.SelectedValue);
            Veiculo veiculo = new Veiculo(placa, cor, marca, ano, tipoCombustivel, image, quantidadeLitros, numeroPortas, capacidadePessoas, tamanhoPortaMalas, kilometragem, id_grupoVeiculo);
            controladorVeiculo.InserirNovo(veiculo);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
