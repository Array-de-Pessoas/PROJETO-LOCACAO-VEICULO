using LocadoraVeiculos.Controladores.ParceiroModule;
using LocadoraVeiculos.Dominio.ParceiroModule;
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

namespace LocadoraVeiculos.WindowsForm.Features.ParceiroModule
{
    public partial class TelaParceiroForm : Form
    {
        private Parceiro parceiro;
        private readonly ControladorParceiro controladorParceiro = null;

        public TelaParceiroForm()
        {
            InitializeComponent();
            controladorParceiro = new ControladorParceiro();
        }

        public Parceiro Parceiro
        {
            get { return parceiro; }

            set
            {
                parceiro = value;

                txtId.Text = parceiro.Id.ToString();
                txtNomeParceiro.Text = parceiro.NomeParceiro.ToString();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string NomeParceiro = txtNomeParceiro.Text;

            parceiro = new Parceiro(NomeParceiro);

            string resultadoValidacao = parceiro.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                DialogResult = DialogResult.None;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
