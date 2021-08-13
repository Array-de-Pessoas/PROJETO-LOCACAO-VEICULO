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


namespace LocadoraVeiculos.WindowsForm
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

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string grupo = TxtNomeGrupoVeiculos.Text;

            grupoVeiculos = new GrupoVeiculos(grupo);

            string resultadoValidacao = grupoVeiculos.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                DialogResult = DialogResult.None;
            }

        }
    }
}
