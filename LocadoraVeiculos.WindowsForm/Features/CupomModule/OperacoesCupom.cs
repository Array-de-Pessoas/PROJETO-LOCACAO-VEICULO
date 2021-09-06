using LocadoraVeiculos.Controladores.CupomModule;
using LocadoraVeiculos.Dominio.CupomModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForm.Features.CupomModule
{
    public class OperacoesCupom : ICadastravel
    {
        private readonly ControladorCupom controlador = null;
        private readonly TabelaCupom tabela = null;

        public OperacoesCupom(ControladorCupom ctrlC)
        {
            controlador = ctrlC;
            tabela = new TabelaCupom();
        }

        public void EditarRegistro()
        {
            int id = tabela.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um cupom para poder editar!", "Edição de cupom",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Cupom cupomSelecionados = controlador.SelecionarPorId(id);

            TelaCupomForm cupomForm = new TelaCupomForm();

            cupomForm.Cupom = cupomSelecionados;

            if (cupomForm.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, cupomForm.Cupom);

                List<Cupom> grupos = controlador.SelecionarTodos();

                tabela.AtualizarRegistros(grupos);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Cupom: [{cupomForm.Cupom.Codigo}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabela.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um cupom para poder excluir!", "Exclusão de cupom",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Cupom cupomSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o cupom: [{cupomSelecionado.Codigo}] ?",
                "Exclusão de cupom", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<Cupom> taxasServicos = controlador.SelecionarTodos();

                tabela.AtualizarRegistros(taxasServicos);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Cupom: [{cupomSelecionado.Codigo}] excluido com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            TelaCupomForm tela = new TelaCupomForm();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Cupom);

                List<Cupom> combustivels = controlador.SelecionarTodos();

                tabela.AtualizarRegistros(combustivels);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Cupom: [{tela.Cupom.Codigo}] adicionado com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<Cupom> cupom = controlador.SelecionarTodos();

            tabela.AtualizarRegistros(cupom);

            return tabela;
        }
    }
}
