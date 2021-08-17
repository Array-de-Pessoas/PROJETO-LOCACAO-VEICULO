using LocadoraVeiculos.WindowsForm.Feature.VeiculoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForm
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            TelaVeiculoForm telaVeiculoForm = new TelaVeiculoForm();
            telaVeiculoForm.ShowDialog();
        }
    }
}
