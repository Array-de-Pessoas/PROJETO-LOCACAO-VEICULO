using LocadoraVeiculos.WindowsForm.Feature.LoginModule;
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
    public partial class MostrarConta : UserControl
    {
        public MostrarConta()
        {
            InitializeComponent();
            InicializarConta();
        }

        private void InicializarConta()
        {
            if(UsuarioParaValidacao.MudarConta == "ContaAcessada")
            {
                ImagemConta1.Image = Properties.Resources.Imagem_3;
                TxtNomeConta.Text = UsuarioParaValidacao.Usuario;
            }
        }

        private void LinkSairConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
