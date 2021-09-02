using LocadoraVeiculos.Controladores.LocacaoModule;
using LocadoraVeiculos.Controladores.VeiculoModule;
using LocadoraVeiculos.Dominio.LocacaoModule;
using LocadoraVeiculos.Dominio.VeiculoModule;
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
    public partial class Dashboard : UserControl
    {
        ControladorVeiculo controladorVeiculos;
        ControladorLocacao controladorLocacao;
        public Dashboard()
        {
            btnLocacoesPendentes = new Label();
            btnCarrosAlugados = new Label();
            btnCarrosDisponiveis = new Label();
            InitializeComponent();
            controladorLocacao = new ControladorLocacao();
            controladorVeiculos = new ControladorVeiculo();
          
            GerarValoresDashboard();
         
        }
        private void GerarValoresDashboard()
        {

            List<Veiculo> veiculos = controladorVeiculos.SelecionarTodos();
            List<Locacao> locacoes = controladorLocacao.SelecionarTodos();

            List<Locacao> locacaoesAbertas = new List<Locacao>();

            foreach (var locacao in locacoes)
            {
                bool locacaoEstaAberta = locacao.locacaoAtiva == 1;
                if (locacaoEstaAberta)
                {
                    locacaoesAbertas.Add(locacao);
                }
            }

            int contadorCarrosAlugados = 0;
            int contadorCarrosDisponiveis = 0;

            foreach (var locacao in locacaoesAbertas)
            {
                foreach (var veiculo in veiculos)
                {
                    if (locacao.id_veiculo == veiculo.Id)
                    {
                        contadorCarrosAlugados++;
                    }
                }
            }
            
            contadorCarrosDisponiveis = veiculos.Count - contadorCarrosAlugados;

            //config as lbls
            btnLocacoesPendentes.Text = locacaoesAbertas.Count.ToString();

            btnCarrosAlugados.Text = contadorCarrosAlugados.ToString();

            btnCarrosDisponiveis.Text = contadorCarrosDisponiveis.ToString();

        }

        private void btnLocacoesPendentes_Click(object sender, EventArgs e)
        {

        }
    }
}
