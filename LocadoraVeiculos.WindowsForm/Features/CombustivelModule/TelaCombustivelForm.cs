using LocadoraVeiculos.Controladores.CombustivelModule;
using LocadoraVeiculos.Dominio.CombustivelModule;
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

namespace LocadoraVeiculos.WindowsForm.Features.CombustivelModule
{
    public partial class TelaCombustivelForm : Form
    {
        private Combustivel combustivel;
        public string TipoDeCombustivel;

        private readonly ControladorCombustivel controladorCombustivel = null;

        public TelaCombustivelForm()
        {
            InitializeComponent();
            controladorCombustivel = new ControladorCombustivel();
        }

        public Combustivel Combustivel
        {
            get { return combustivel; }

            set
            {
                combustivel = value;

                txtId.Text = combustivel.Id.ToString();
                txtTipoCombustivel.Text = combustivel.TipoCombustivel;
                txtValor.Text = combustivel.Valor.ToString();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string TipoCombustivel = txtTipoCombustivel.Text;
            decimal Valor = Convert.ToDecimal(txtValor.Text);

            combustivel = new Combustivel(TipoCombustivel, Valor);

            string resultadoValidacao = combustivel.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                DialogResult = DialogResult.None;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
