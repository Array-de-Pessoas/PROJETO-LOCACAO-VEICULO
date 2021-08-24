
using LocadoraVeiculos.Controladores.GrupoVeiculosModule;
using LocadoraVeiculos.Dominio.GrupoVeiculosModule;
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


namespace LocadoraVeiculos.WindowsForm.Features.GrupoVeiculosModule
{
    public partial class TelaGrupoDeVeiculosForm : Form
    {
        private GrupoVeiculos grupoVeiculos;

        public TelaGrupoDeVeiculosForm()
        {
            InitializeComponent();       
        }

        public GrupoVeiculos GrupoVeiculos
        {
            get { return grupoVeiculos; }

            set
            {
                grupoVeiculos = value;

                TxtNomeGrupoVeiculos.Text = grupoVeiculos.Grupo;
                txtValorDiariaPlanoDiario.Text = grupoVeiculos.ValorDiariaPlanoDiario.ToString();
                txtValorDiariaPlanoControlado.Text = grupoVeiculos.ValorDiariaPlanoControlado.ToString();
                txtValorDiariaPlanoLivre.Text = grupoVeiculos.ValorDiariaPlanoLivre.ToString();
                txtLimiteKMPlanoControlado.Text = grupoVeiculos.LimiteKMPlanoControlado.ToString();
                txtValorDoKMPlanoDiario.Text = grupoVeiculos.ValorDoKMPlanoDiario.ToString();
                txtValorKmExcedentePlanoControlado.Text = grupoVeiculos.ValorKmExcedentePlanoControlado.ToString();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string Grupo = TxtNomeGrupoVeiculos.Text;

            double valorDiariaPlanoDiario, valorDiariaPlanoControlado, valorDiariaPlanoLivre, valorDoKMPlanoDiario, limiteKMPlanoControlado, valorKmExcedentePlanoControlado;
            double.TryParse(txtValorDiariaPlanoDiario.Text, out valorDiariaPlanoDiario);
            double.TryParse(txtValorDiariaPlanoControlado.Text, out valorDiariaPlanoControlado);
            double.TryParse(txtValorDiariaPlanoLivre.Text, out valorDiariaPlanoLivre);
            double.TryParse(txtValorDoKMPlanoDiario.Text, out valorDoKMPlanoDiario);
            double.TryParse(txtLimiteKMPlanoControlado.Text, out limiteKMPlanoControlado);
            double.TryParse(txtValorKmExcedentePlanoControlado.Text, out valorKmExcedentePlanoControlado);           

            grupoVeiculos = new GrupoVeiculos(Grupo, valorDiariaPlanoDiario,valorDiariaPlanoControlado,valorDiariaPlanoLivre,valorDoKMPlanoDiario,limiteKMPlanoControlado,valorKmExcedentePlanoControlado);

            string resultadoValidacao = grupoVeiculos.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();
                TelaPrincipal.Instancia.AtualizarRodape(primeiroErro);
                DialogResult = DialogResult.None;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
