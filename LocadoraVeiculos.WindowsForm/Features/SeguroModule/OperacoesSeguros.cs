using LocadoraVeiculos.Controladores.SegurosModule;
using LocadoraVeiculos.Dominio.SegurosModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForm.Features.SeguroModule
{
    public class OperacoesSeguros : ICadastravel
    {
        private readonly ControladorSeguros controlador = null;
        private readonly TabelaSeguros tabela = null;

        public OperacoesSeguros(ControladorSeguros ctrlS)
        {
            controlador = ctrlS;
            tabela = new TabelaSeguros();
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

            Seguros SeguroSelecionados = controlador.SelecionarPorId(id);

            TelaSegurosForm segurosForm = new TelaSegurosForm();

            segurosForm.Seguros = SeguroSelecionados;

            if (segurosForm.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, segurosForm.Seguros);

                List<Seguros> grupos = controlador.SelecionarTodos();

                tabela.AtualizarRegistros(grupos);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Seguro: [{segurosForm.Seguros.TipoSeguro}] editado com sucesso");
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

            Seguros SegurosSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o Seguro: [{SegurosSelecionado.TipoSeguro}] ?",
                "Exclusão de Seguros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<Seguros> taxasServicos = controlador.SelecionarTodos();

                tabela.AtualizarRegistros(taxasServicos);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Seguro: [{SegurosSelecionado.TipoSeguro}] excluido com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            TelaSegurosForm tela = new TelaSegurosForm();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Seguros);

                List<Seguros> taxasServicos = controlador.SelecionarTodos();

                tabela.AtualizarRegistros(taxasServicos);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Seguro: [{tela.Seguros.TipoSeguro}] adicionado com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<Seguros> seguros = controlador.SelecionarTodos();

            tabela.AtualizarRegistros(seguros);

            return tabela;
        }
    }
}
