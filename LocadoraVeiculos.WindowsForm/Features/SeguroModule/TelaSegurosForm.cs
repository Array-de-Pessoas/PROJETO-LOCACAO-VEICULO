using LocadoraVeiculos.Controladores.SegurosModule;
using LocadoraVeiculos.Dominio.SegurosModule;
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

namespace LocadoraVeiculos.WindowsForm.Features.SeguroModule
{
    public partial class TelaSegurosForm : Form
    {
        private Seguros seguros;
   
        private readonly ControladorSeguros controladorSeguros = null;

        public TelaSegurosForm()
        {
            InitializeComponent();
            controladorSeguros = new ControladorSeguros();
        }

        public Seguros Seguros
        {
            get { return seguros; }

            set
            {
                seguros = value;

                txtId.Text = seguros.Id.ToString();
                txtTipoSeguro.Text = seguros.TipoSeguro;
                txtValor.Text = seguros.Valor.ToString();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            string TipoSeguro = txtTipoSeguro.Text; ;
            decimal Valor = Convert.ToDecimal(txtValor.Text);

            seguros = new Seguros(TipoSeguro, Valor);

            string resultadoValidacao = seguros.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                DialogResult = DialogResult.None;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
