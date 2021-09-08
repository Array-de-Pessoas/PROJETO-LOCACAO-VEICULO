using LocadoraVeiculos.Controladores.LocacaoModule;
using LocadoraVeiculos.Dominio.LocacaoModule;
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
           
            List<Locacao> locacaoesAbertas = controladorLocacao.SelecionarTodasLocacoesAtivas();

            tabela.AtualizarRegistros(locacaoesAbertas);

            return tabela;
        }
    }
}
