using LocadoraVeiculos.Controladores.CupomModule;
using LocadoraVeiculos.Dominio.CupomModule;
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

namespace LocadoraVeiculos.WindowsForm.Features.CupomModule
{
    public partial class TelaCupomForm : Form
    {
        private Cupom cupom;
        private readonly ControladorCupom controlador = null;

        public TelaCupomForm()
        {
            InitializeComponent();
            controlador = new ControladorCupom();
        }

        public Cupom Cupom
        {
            get { return cupom; }

            set
            {
                cupom = value;

                txtId.Text = cupom.Id.ToString();
                txtCodigo.Text = cupom.Codigo.ToString();
                txtTipo.Text = cupom.Tipo.ToString();
                txtValor.Text = cupom.Valor.ToString();
                txtValorMinimo.Text = cupom.ValorMinimo.ToString();
                txtQuantidade.Text = cupom.QuantidadeUso.ToString();
                
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string Codigo = txtCodigo.Text;
            string Tipo = txtTipo.Text;
            decimal Valor = Convert.ToDecimal(txtValor.Text);
            decimal ValorMinimo = Convert.ToDecimal(txtValorMinimo.Text);
            string Parceiro = CmbParceiro.SelectedItem.ToString();
            DateTime DiaVencimento = dateTimeVencimento.Value;
            int Quantidade = Convert.ToInt32(txtQuantidade.Text);

            cupom = new Cupom(Codigo, Tipo, Valor, ValorMinimo, Parceiro, DiaVencimento, Quantidade);

            string resultadoValidacao = cupom.Validar();

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
