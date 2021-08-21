using LocadoraVeiculos.Controladores.TaxasServicosModule;
using LocadoraVeiculos.Dominio.TaxasServicosModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForm.Features.TaxasServicosModule
{
    public class OperacoesTaxasServicos : ICadastravel
    {
        private readonly ControladorTaxasServicos controlador = null;
        private readonly TabelaTaxasServicos tabela = null;

        public OperacoesTaxasServicos(ControladorTaxasServicos ctrlTS)
        {
            controlador = ctrlTS;
            tabela = new TabelaTaxasServicos();
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

            TaxasServicos taxasServicosSelecionados = controlador.SelecionarPorId(id);

            TaxasServicosForm taxasServicosForm = new TaxasServicosForm();

            taxasServicosForm.TaxasServicos = taxasServicosSelecionados;

            if (taxasServicosForm.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, taxasServicosForm.TaxasServicos);

                List<TaxasServicos> grupos = controlador.SelecionarTodos();

                tabela.AtualizarRegistros(grupos);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Grupo: [{taxasServicosForm.TaxasServicos}] editado com sucesso");
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

            TaxasServicos taxasServicosSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o Grupo: [{taxasServicosSelecionado}] ?",
                "Exclusão de Grupo de veículos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<TaxasServicos> taxasServicos = controlador.SelecionarTodos();

                tabela.AtualizarRegistros(taxasServicos);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Grupo: [{taxasServicosSelecionado}] excluido com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            TaxasServicosForm tela = new TaxasServicosForm();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.TaxasServicos);

                List<TaxasServicos> taxasServicos = controlador.SelecionarTodos();

                tabela.AtualizarRegistros(taxasServicos);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Grupo: [{tela.TaxasServicos}] adicionado com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<TaxasServicos> taxas = controlador.SelecionarTodos();

            tabela.AtualizarRegistros(taxas);

            return tabela;
        }
    }
}
