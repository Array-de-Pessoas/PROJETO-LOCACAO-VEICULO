using LocadoraVeiculos.Controladores.GrupoVeiculosModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForm
{
    public class OperacoesGrupoVeiculos : ICadastravel
    {
        private readonly ControladorGrupoVeiculos controlador = null;

        public OperacoesGrupoVeiculos(ControladorGrupoVeiculos ctrlGrupoVeiculos)
        {
            controlador = ctrlGrupoVeiculos;
        }

        public void EditarRegistro()
        {
            GrupoDeVeiculosForm grupoDeVeiculosForm = new GrupoDeVeiculosForm();
            grupoDeVeiculosForm.ShowDialog();
        }

        public void ExcluirRegistro()
        {
            System.Windows.Forms.MessageBox.Show("Tem certeza que deseja remover esse item?");
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            GrupoDeVeiculosForm tela = new GrupoDeVeiculosForm();
            
            if (tela.ShowDialog() == DialogResult.OK)
            {
                //controlador.InserirNovo(tela.grupo);
            }
        }

        public UserControl ObterTabela()
        {
            return new TabelaGrupoVeiculos();
        }
    }
}
