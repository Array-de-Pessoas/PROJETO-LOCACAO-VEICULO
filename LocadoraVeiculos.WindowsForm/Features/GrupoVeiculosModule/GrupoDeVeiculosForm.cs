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
    public partial class GrupoDeVeiculosForm : Form
    {
        private GrupoVeiculos grupoVeiculos;

        private readonly ControladorGrupoVeiculos controladorGrupo = null;

        public GrupoDeVeiculosForm()
        {
            InitializeComponent();
            controladorGrupo = new ControladorGrupoVeiculos();
        }

        public GrupoVeiculos GrupoVeiculos
        {
            get { return grupoVeiculos; }

            set
            {
                grupoVeiculos = value;

                TxtNomeGrupoVeiculos.Text = grupoVeiculos.Grupo;
                
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string Grupo = TxtNomeGrupoVeiculos.Text;

            grupoVeiculos = new GrupoVeiculos(Grupo);

            string resultadoValidacao = grupoVeiculos.Validar();

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
