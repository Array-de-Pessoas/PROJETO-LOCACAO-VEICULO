using LocadoraVeiculos.Controladores.LocacaoModule;
using LocadoraVeiculos.Dominio.LocacaoModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForm.Features.Devolucao
{
    public class OperacoesDevolucao : ICadastravel
    {
        TabelaDevolucao tabela = new TabelaDevolucao();
        ControladorLocacao controladorLocacao;

        public OperacoesDevolucao(ControladorLocacao controladorLocacao)
        {
            this.controladorLocacao = controladorLocacao;
            
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
            List<Locacao> locacaos = controladorLocacao.SelecionarTodos();

            tabela.AtualizarRegistros(locacaos);

            return tabela;
        }
    }
}
