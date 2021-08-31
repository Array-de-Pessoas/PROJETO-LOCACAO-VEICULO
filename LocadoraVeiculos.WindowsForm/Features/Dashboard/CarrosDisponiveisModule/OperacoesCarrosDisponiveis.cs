using LocadoraVeiculos.Controladores.CarrosDisponiveisModule;
using LocadoraVeiculos.Dominio.CarrosDisponiveisModule;
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
        ControladorCarrosDisponiveis controlador;
        TabelaCarrosDisponiveis tabela;

        public OperacoesCarrosDisponiveis(ControladorCarrosDisponiveis controladorCarrosDisponiveis)
        {
            this.controlador = controladorCarrosDisponiveis;
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
            List<CarrosDisponiveis> carros = controlador.SelecionarTodos();

            tabela.AtualizarRegistros(carros);

            return tabela;
        }
    }
}
