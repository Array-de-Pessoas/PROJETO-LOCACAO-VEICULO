using LocadoraVeiculos.Controladores.CarrosAlugadosModule;
using LocadoraVeiculos.Controladores.LocacaoModule;
using LocadoraVeiculos.Controladores.VeiculoModule;
using LocadoraVeiculos.Dominio.CarrosAlugadosModule;
using LocadoraVeiculos.Dominio.LocacaoModule;
using LocadoraVeiculos.Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForm.Features.Dashboard.CarrosAlugadosModule
{
    public class OperacoesCarrosAlugados : ICadastravel
    {
        ControladorLocacao controladorLocacao = new ControladorLocacao();
        ControladorVeiculo controladorVeiculo = new ControladorVeiculo();
        ControladorCarrosAlugados controlador;
        TabelaCarrosAlugados tabelaCarrosAlugados;

        public OperacoesCarrosAlugados(ControladorCarrosAlugados controladorCarrosAlugados)
        {
            this.controlador = controladorCarrosAlugados;
            tabelaCarrosAlugados = new TabelaCarrosAlugados();
        }

        public void EditarRegistro()
        {
            throw new NotImplementedException();
        }

        public void ExcluirRegistro()
        {
            throw new NotImplementedException();
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            throw new NotImplementedException();
        }

        public UserControl ObterTabela()
        {
            List<Veiculo> veiculos = controladorVeiculo.SelecionarTodos();
            List<Locacao> locacoes = controladorLocacao.SelecionarTodos();

            List<Veiculo> veiculosAlugados = new List<Veiculo>();

            List<Locacao> locacaoesAbertas = new List<Locacao>();

            foreach (var locacao in locacoes)
            {
                bool ehLocacao = locacao.locacaoAtiva == 1;
                if (ehLocacao)
                {
                    locacaoesAbertas.Add(locacao);
                }
            }

            foreach (var locacao in locacaoesAbertas)
            {
                foreach (var veiculo in veiculos)
                {
                    if (locacao.id_veiculo == veiculo.Id)
                    {
                        veiculosAlugados.Add(veiculo);
                    }
                }
            }

            tabelaCarrosAlugados.AtualizarRegistros(veiculosAlugados);

            return tabelaCarrosAlugados;
        }
    }
}
