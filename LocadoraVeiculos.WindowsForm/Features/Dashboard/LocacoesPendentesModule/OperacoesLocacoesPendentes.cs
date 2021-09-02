using LocadoraVeiculos.Controladores.LocacaoModule;
using LocadoraVeiculos.Controladores.LocacoesPendentesModule;
using LocadoraVeiculos.Dominio.LocacaoModule;
using LocadoraVeiculos.Dominio.LocacoesPendentesModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForm.Features.Dashboard.LocacoesPendentesModule
{
    public class OperacoesLocacoesPendentes : ICadastravel
    {
        ControladorLocacao controladorLocacao;
        TabelaLocacoesPendentes tabela;

        public OperacoesLocacoesPendentes(ControladorLocacao controlador)
        {
            this.controladorLocacao = controlador;
            tabela = new TabelaLocacoesPendentes();
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
            tabela.AtualizarRegistros(locacaoesAbertas);

            return tabela;
        }
    }
}
