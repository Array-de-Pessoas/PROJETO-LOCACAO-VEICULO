using LocadoraVeiculos.Controladores.GrupoVeiculosModule;
using LocadoraVeiculos.Controladores.Shared;
using LocadoraVeiculos.Dominio.GrupoVeiculosModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForm.Features.GrupoVeiculosModule
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

            TelaGrupoDeVeiculosForm grupoForm = new TelaGrupoDeVeiculosForm();

            grupoForm.GrupoVeiculos = grupoSelecionado;

            if (grupoForm.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, grupoForm.GrupoVeiculos);

                List<GrupoVeiculos> grupos = controlador.SelecionarTodos();

                tabelaGrupo.AtualizarRegistros(grupos);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Grupo: [{grupoForm.GrupoVeiculos.Grupo}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaGrupo.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Grupo para poder excluir!", "Exclusão de Grupos de veículos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            GrupoVeiculos grupoSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o Grupo: [{grupoSelecionado.Grupo}] ?",
                "Exclusão de Grupo de veículos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bool excluido = controlador.Excluir(id);

                List<GrupoVeiculos> grupos = controlador.SelecionarTodos();

                tabelaGrupo.AtualizarRegistros(grupos);
                if (excluido)
                {
                    TelaPrincipal.Instancia.AtualizarRodape($"                                                     Grupo: [{grupoSelecionado.Grupo}] excluido com sucesso");
                }
               
            }
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            TelaGrupoDeVeiculosForm tela = new TelaGrupoDeVeiculosForm();
            
            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.GrupoVeiculos);

                List<GrupoVeiculos> grupos = controlador.SelecionarTodos();

                tabelaGrupo.AtualizarRegistros(grupos);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Grupo: [{tela.GrupoVeiculos.Grupo}] adicionado com sucesso");
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
