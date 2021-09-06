using LocadoraVeiculos.Controladores.ParceiroModule;
using LocadoraVeiculos.Dominio.ParceiroModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForm.Features.ParceiroModule
{
    public class OperacoesParceiro : ICadastravel
    {
        private readonly ControladorParceiro controlador = null;
        private readonly TabelaParceiro tabela = null;

        public OperacoesParceiro (ControladorParceiro ctlp)
        {
            controlador = ctlp;
            tabela = new TabelaParceiro();
        }

        public void EditarRegistro()
        {
            int id = tabela.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um parceiro para poder editar!", "Edição de parceiros",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Parceiro parceiroSelecionados = controlador.SelecionarPorId(id);

            TelaParceiroForm parceiroForm = new TelaParceiroForm();

            parceiroForm.Parceiro = parceiroSelecionados;

            if (parceiroForm.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, parceiroForm.Parceiro);

                List<Parceiro> grupos = controlador.SelecionarTodos();

                tabela.AtualizarRegistros(grupos);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Parceiro: [{parceiroForm.Parceiro.NomeParceiro}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabela.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um parceiro para poder excluir!", "Exclusão de parceiros",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Parceiro parceiroSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o parceiro: [{parceiroSelecionado.NomeParceiro}] ?",
                "Exclusão de parceiros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<Parceiro> parceiros = controlador.SelecionarTodos();

                tabela.AtualizarRegistros(parceiros);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Parceiro: [{parceiroSelecionado.NomeParceiro}] excluido com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            TelaParceiroForm tela = new TelaParceiroForm();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Parceiro);

                List<Parceiro> parceiros = controlador.SelecionarTodos();

                tabela.AtualizarRegistros(parceiros);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Parceiro: [{tela.Parceiro.NomeParceiro}] adicionado com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<Parceiro> parceiros = controlador.SelecionarTodos();

            tabela.AtualizarRegistros(parceiros);

            return tabela;
        }
    }
}
