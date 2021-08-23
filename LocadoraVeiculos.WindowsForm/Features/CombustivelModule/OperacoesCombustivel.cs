using LocadoraVeiculos.Controladores.CombustivelModule;
using LocadoraVeiculos.Dominio.CombustivelModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForm.Features.CombustivelModule
{
    public class OperacoesCombustivel : ICadastravel
    {
        private readonly ControladorCombustivel controlador = null;
        private readonly TabelaCombustivelControl tabela = null;

        public OperacoesCombustivel(ControladorCombustivel ctrlC)
        {
            controlador = ctrlC;
            tabela = new TabelaCombustivelControl();
        }

        public void EditarRegistro()
        {
            int id = tabela.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Grupo para poder editar!", "Edição de Grupo de veículos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Combustivel combustivelSelecionados = controlador.SelecionarPorId(id);

            TelaCombustivelForm combustivelForm = new TelaCombustivelForm();

            combustivelForm.Combustivel = combustivelSelecionados;

            if (combustivelForm.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, combustivelForm.Combustivel);

                List<Combustivel> grupos = controlador.SelecionarTodos();

                tabela.AtualizarRegistros(grupos);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Grupo: [{combustivelForm.Combustivel.TipoCombustivel}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabela.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Grupo para poder excluir!", "Exclusão de Grupos de veículos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Combustivel combustivelSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o Grupo: [{combustivelSelecionado.TipoCombustivel}] ?",
                "Exclusão de Grupo de veículos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<Combustivel> taxasServicos = controlador.SelecionarTodos();

                tabela.AtualizarRegistros(taxasServicos);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Grupo: [{combustivelSelecionado.TipoCombustivel}] excluido com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            TelaCombustivelForm tela = new TelaCombustivelForm();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Combustivel);

                List<Combustivel> combustivels = controlador.SelecionarTodos();

                tabela.AtualizarRegistros(combustivels);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Grupo: [{tela.Combustivel.TipoCombustivel}] adicionado com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<Combustivel> combustivel = controlador.SelecionarTodos();

            tabela.AtualizarRegistros(combustivel);

            return tabela;
        }
    }
}
