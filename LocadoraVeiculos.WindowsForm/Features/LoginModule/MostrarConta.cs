using LocadoraVeiculos.WindowsForm.Features.LoginModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForm.Features.LoginModule
{
    public partial class MostrarConta : UserControl
    {
        private OperacoesLogin operacoes;
        private static string status;
        
        public MostrarConta()
        {
            InitializeComponent();
            operacoes = new OperacoesLogin();
            Status = "Entrar";
        }

        public string Status { get => status; set => status = value; }

        private void LinkSairConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Status = LinkConta.Text;

            if (Status.Equals("Entrar"))
            {
                operacoes.RealizarLogin();
                txtNomeConta.Text = operacoes.GerarUsuario();

                if (operacoes.GerarUsuario() == null)
                {
                    txtNomeConta.Text = "Faça login";
                    ImagemConta1.Image = Properties.Resources.Sem_conta;
                    LinkConta.Text = "Entrar";
                    Status = "Entrar";
                    return;
                }

                LinkConta.Text = "Sair";
                Status = "Sair";
                ImagemConta1.Image = Properties.Resources.Imagem_3;
                return;
            }

            if (Status.Equals("Sair"))
            {
                txtNomeConta.Text = "Faça login";
                ImagemConta1.Image = Properties.Resources.Sem_conta;
                LinkConta.Text = "Entrar";
                Status = "Entrar";
                operacoes.Usuario = null;
                operacoes.GerarUsuario();

                return ;
            }
        }

    }
}
