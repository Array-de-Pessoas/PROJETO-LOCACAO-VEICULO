using LocadoraVeiculos.Controladores.GrupoVeiculosModule;
using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Dominio.GrupoVeiculosModule;
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
        private readonly TabelaGrupoVeiculos tabelaGrupo = null;

        public OperacoesGrupoVeiculos(ControladorGrupoVeiculos ctrlGrupo)
        {
            controlador = ctrlGrupo;
            tabelaGrupo = new TabelaGrupoVeiculos();
        }

        public void EditarRegistro()
        {
            int id = tabelaGrupo.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Grupo para poder editar!", "Edição de Grupo de veículos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            GrupoVeiculos grupoSelecionado = controlador.SelecionarPorId(id);

            GrupoDeVeiculosForm grupoForm = new GrupoDeVeiculosForm();

            grupoForm.GrupoVeiculos = grupoSelecionado;

            if (grupoForm.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, grupoForm.GrupoVeiculos);

                List<GrupoVeiculos> tarefas = controlador.SelecionarTodos();

                tabelaGrupo.AtualizarRegistros(tarefas);
            }
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
                controlador.InserirNovo(tela.GrupoVeiculos);
            }
        }

        public UserControl ObterTabela()
        {
            List<GrupoVeiculos> grupoVeiculos = controlador.SelecionarTodos();

            tabelaGrupo.AtualizarRegistros(grupoVeiculos);

            return tabelaGrupo;
        }
    }
}
