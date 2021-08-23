using LocadoraVeiculos.Controladores.TaxasServicosModule;
using LocadoraVeiculos.Dominio.TaxasServicosModule;
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

namespace LocadoraVeiculos.WindowsForm.Features.TaxasServicosModule
{
    public partial class TaxasServicosForm : Form
    {
        private TaxasServicos taxasServicos;
        public string TipoDeTaxa;

        private readonly ControladorTaxasServicos controladorTaxas = null;

        public TaxasServicosForm()
        {
            InitializeComponent();
            controladorTaxas = new ControladorTaxasServicos();
        }

        public TaxasServicos TaxasServicos
        {
            get { return taxasServicos; }

            set
            {
                taxasServicos = value;

                txtId.Text = taxasServicos.Id.ToString();
                TipoDeTaxa = taxasServicos.TipoTaxa;
                txtNome.Text = taxasServicos.Nome;
                txtValor.Text = taxasServicos.Valor.ToString();

            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (RbnTaxaDiaria.Checked)
            {
                TipoDeTaxa = "Diaria";
            }
            if (RbnTaxaFixa.Checked)
            {
                TipoDeTaxa = "Fixa";
            }

            string Tipo = TipoDeTaxa;
            string Nome = txtNome.Text;
            decimal Valor = Convert.ToDecimal(txtValor.Text);

            taxasServicos = new TaxasServicos(Tipo,Nome,Valor);

            string resultadoValidacao = taxasServicos.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                DialogResult = DialogResult.None;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
