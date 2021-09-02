using LocadoraVeiculos.Controladores.CarrosDisponiveisModule;
using LocadoraVeiculos.Controladores.LocacaoModule;
using LocadoraVeiculos.Controladores.VeiculoModule;
using LocadoraVeiculos.Dominio.CarrosDisponiveisModule;
using LocadoraVeiculos.Dominio.LocacaoModule;
using LocadoraVeiculos.Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForm.Features.Dashboard.CarrosDisponiveisModule
{
    public class OperacoesCarrosDisponiveis : ICadastravel
    {
        ControladorLocacao controladorLocacao = new ControladorLocacao();
        ControladorVeiculo controladorVeiculo = new ControladorVeiculo();
        TabelaCarrosDisponiveis tabela;

        public OperacoesCarrosDisponiveis()
        {        
            tabela = new TabelaCarrosDisponiveis();
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

            List<Veiculo> veiculosDisponiveis = controladorVeiculo.SelecionarTodos();

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
                    bool veiculoEstaAlugado = locacao.id_veiculo == veiculo.Id;
                    if (veiculoEstaAlugado)
                    {
                        veiculosDisponiveis.RemoveAt(veiculos.IndexOf(veiculo));
                    }
                }
            }

            tabela.AtualizarRegistros(veiculosDisponiveis);

            return tabela;
        }
    }
}
