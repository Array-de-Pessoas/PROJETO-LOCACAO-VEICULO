using LocadoraVeiculos.Controladores.CarrosAlugadosModule;
using LocadoraVeiculos.Controladores.LocacaoModule;
using LocadoraVeiculos.Dominio.CarrosAlugadosModule;
using LocadoraVeiculos.Dominio.LocacaoModule;
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
        ControladorCarrosAlugados controlador;
        TabelaCarrosAlugados carrosAlugados;

        public OperacoesCarrosAlugados(ControladorCarrosAlugados controladorCarrosAlugados)
        {
            this.controlador = controladorCarrosAlugados;
            carrosAlugados = new TabelaCarrosAlugados();
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
            List<CarrosAlugados> carros = controlador.SelecionarTodos();

            carrosAlugados.AtualizarRegistros(carros);

            return carrosAlugados;
        }
    }
}
