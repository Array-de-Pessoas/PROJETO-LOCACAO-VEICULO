using LocadoraVeiculos.Controladores.FuncionarioModule;
using LocadoraVeiculos.Dominio.FuncionarioModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForm.Features.FuncionarioModule
{
    public class OperacoesFuncionario : ICadastravel
    {
        private readonly ControladorFuncionario controlador = null;
        private readonly TabelaFuncionarioControl tabelaFuncionario = null;

        public OperacoesFuncionario(ControladorFuncionario ctrlFuncionario)
        {
            this.controlador = ctrlFuncionario;
            tabelaFuncionario = new TabelaFuncionarioControl();
        }

        public void InserirNovoRegistro()
        {
            TelaFuncionarioForm tela = new TelaFuncionarioForm();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Funcionario);

                List<Funcionario> funcionarios = controlador.SelecionarTodos();

                tabelaFuncionario.AtualizarRegistros(funcionarios);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Funcionário: [{tela.Funcionario.Nome}] inserido com sucesso");
            }
        }

        public void EditarRegistro()
        {
            int id = tabelaFuncionario.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um funcionário para poder editar!", "Edição de Funcionários",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Funcionario funcionarioSelecionada = controlador.SelecionarPorId(id);
            TelaFuncionarioForm tela = new TelaFuncionarioForm();

            tela.Funcionario = funcionarioSelecionada;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Funcionario);

                List<Funcionario> funcionarios = controlador.SelecionarTodos();

                tabelaFuncionario.AtualizarRegistros(funcionarios);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Funcionário: [{tela.Funcionario.Nome}] editada com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaFuncionario.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um funcionário para poder excluir!", "Exclusão de Funcionários",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Funcionario funcionarioSelecionada = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o funcionário: [{funcionarioSelecionada.Nome}] ?",
                "Exclusão de Funcionários", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<Funcionario> funcionarios = controlador.SelecionarTodos();

                tabelaFuncionario.AtualizarRegistros(funcionarios);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Funcionário: [{funcionarioSelecionada.Nome}] removido com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public UserControl ObterTabela()
        {
            List<Funcionario> funcionarios = controlador.SelecionarTodos();

            tabelaFuncionario.AtualizarRegistros(funcionarios);

            return tabelaFuncionario;
        }
    }
}
