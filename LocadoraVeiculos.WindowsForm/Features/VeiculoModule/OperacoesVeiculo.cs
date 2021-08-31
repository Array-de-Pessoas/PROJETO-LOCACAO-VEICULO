using LocadoraVeiculos.Controladores.CarrosDisponiveisModule;
using LocadoraVeiculos.Controladores.VeiculoModule;
using LocadoraVeiculos.Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForm.Features.GrupoVeiculosModule
{
    
    public class OperacoesVeiculo : ICadastravel
    {
        ControladorCarrosDisponiveis carrosDisponiveis = new ControladorCarrosDisponiveis();
        ControladorVeiculo controladorVeiculo;
        TabelaVeiculosControl tabelaVeiculosControl;
        public OperacoesVeiculo(ControladorVeiculo controladorVeiculo)
        {
            this.controladorVeiculo = controladorVeiculo;
            tabelaVeiculosControl = new TabelaVeiculosControl();
        }

        public void EditarRegistro()
        {
            int id = tabelaVeiculosControl.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Veículo para poder editar!", "Edição de veículos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Veiculo veiculo = controladorVeiculo.SelecionarPorId(id);

            TelaVeiculoForm telaVeiculoForm = new TelaVeiculoForm();

            telaVeiculoForm.Veiculo = veiculo;

            if (telaVeiculoForm.ShowDialog() == DialogResult.OK)
            {
                controladorVeiculo.Editar(id, telaVeiculoForm.Veiculo);

                List<Veiculo> veiculos = controladorVeiculo.SelecionarTodos();

                tabelaVeiculosControl.AtualizarRegistros(veiculos);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Veículo: [{telaVeiculoForm.Veiculo.marca}] editada com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaVeiculosControl.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Veículo para poder excluir!", "Exclusão de veículos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Veiculo veiculo = controladorVeiculo.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o Veículo: [{veiculo.marca}] ?",
                "Exclusão  de veículos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controladorVeiculo.Excluir(id);

                List<Veiculo> veiculos = controladorVeiculo.SelecionarTodos();

                tabelaVeiculosControl.AtualizarRegistros(veiculos);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Veículo removido com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            TelaVeiculoForm telaVeiculoForm = new TelaVeiculoForm();

            if (telaVeiculoForm.ShowDialog() == DialogResult.OK)
            {
                controladorVeiculo.InserirNovo(telaVeiculoForm.Veiculo);

                carrosDisponiveis.InserirNovo(telaVeiculoForm.CarrosDisponiveis);

                List<Veiculo> veiculos = controladorVeiculo.SelecionarTodos();

                tabelaVeiculosControl.AtualizarRegistros(veiculos);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Veículo: [{telaVeiculoForm.Veiculo.marca}] inserido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<Veiculo> veiculos = controladorVeiculo.SelecionarTodos();

            tabelaVeiculosControl.AtualizarRegistros(veiculos);

            return tabelaVeiculosControl;
        }

    }
}
