using LocadoraVeiculos.Controladores.LocacoesPendentesModule;
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
        ControladorLocacoesPendentes controlador;
        TabelaLocacoesPendentes tabela;

        public OperacoesLocacoesPendentes(ControladorLocacoesPendentes controlador)
        {
            this.controlador = controlador;
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
            List<LocacoesPendentes> locacoes = controlador.SelecionarTodos();

            tabela.AtualizarRegistros(locacoes);

            return tabela;
        }
    }
}
