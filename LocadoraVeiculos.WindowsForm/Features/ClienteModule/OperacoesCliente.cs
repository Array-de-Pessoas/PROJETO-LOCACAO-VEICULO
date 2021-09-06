using LocadoraVeiculos.Controladores.ClienteModule;
using LocadoraVeiculos.Controladores.LocacaoModule;
using LocadoraVeiculos.Dominio;
using LocadoraVeiculos.Dominio.LocacaoModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForm.Features.ClienteModule
{
    public class OperacoesCliente : ICadastravel
    {
        ControladorLocacao controladorLocacao = new ControladorLocacao();
        private readonly ControladorCliente controlador = null;
        private readonly TabelaCliente tabela = null;

        public OperacoesCliente(ControladorCliente ctrlC)
        {
            controlador = ctrlC;
            tabela = new TabelaCliente();
        }

        public void EditarRegistro()
        {
            int id = tabela.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um cliente para poder editar!", "Edição de Clientes",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Cliente clienteSelecionados = controlador.SelecionarPorId(id);

            TelaClienteForm clienteForm = new TelaClienteForm();

            clienteForm.Cliente = clienteSelecionados;

            if (clienteForm.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, clienteForm.Cliente);

                List<Cliente> clientes = controlador.SelecionarTodos();

                tabela.AtualizarRegistros(clientes);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Grupo: [{clienteForm.Cliente.NomeCliente}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabela.ObtemIdSelecionado();

            List<Locacao> locacoes = controladorLocacao.SelecionarTodos();

            foreach (var locacao in locacoes)
            {
                if (id == locacao.id_cliente)
                {
                    MessageBox.Show("Não é possível excluir um condutor ativo em locações!", "Exclusão de Clientes",
                     MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (id == 0)
            {
                MessageBox.Show("Selecione um Grupo para poder excluir!", "Exclusão de Clientes",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Cliente clienteSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o Grupo: [{clienteSelecionado.NomeCliente}] ?",
                "Exclusão de Grupo de veículos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<Cliente> taxasServicos = controlador.SelecionarTodos();

                tabela.AtualizarRegistros(taxasServicos);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Cliente: [{clienteSelecionado.NomeCliente}] excluido com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            TelaClienteForm tela = new TelaClienteForm();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Cliente);

                List<Cliente> taxasServicos = controlador.SelecionarTodos();

                tabela.AtualizarRegistros(taxasServicos);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Cliente: [{tela.Cliente.NomeCliente}] adicionado com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<Cliente> taxas = controlador.SelecionarTodos();

            tabela.AtualizarRegistros(taxas);

            return tabela;
        }
    }
}
