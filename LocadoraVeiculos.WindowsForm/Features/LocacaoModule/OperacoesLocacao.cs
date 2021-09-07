using LocadoraVeiculos.Controladores.CarrosAlugadosModule;
using LocadoraVeiculos.Controladores.LocacaoModule;
using LocadoraVeiculos.Controladores.LocacoesPendentesModule;
using LocadoraVeiculos.Dominio.LocacaoModule;
using LocadoraVeiculos.GeradorPDF;
using LocadoraVeiculos.WindowsForm;
using LocadoraVeiculos.WindowsForm.Features.Dashboard;
using LocadoraVeiculos.WindowsForm.Features.LocacaoModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraLocacaos.WindowsForm.Features.LocacaoModule
{
    public class OperacoesLocacao : ICadastravel
    {
        ControladorLocacoesPendentes locacoesPendentes = new ControladorLocacoesPendentes();
        ControladorCarrosAlugados carrosAlugados = new ControladorCarrosAlugados();
        ControladorLocacao controladorLocacao;
        TabelaLocacaoControl tabelaLocacaoControl;
      
        //private bool ValidarVeiculo()
        //{
        //    List<Locacao> locacaos = controladorLocacao.SelecionarTodasLocacoesAtivas();

        //    foreach (var locacao in locacaos)
        //    {
        //        if (id_veiculo == locacao.id_veiculo)
        //        {
        //            MessageBox.Show("Não é possível locar um veículo já locado!", "Adição de locação",
        //            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            return;
        //        }
        //    }
        //}

        public OperacoesLocacao(ControladorLocacao controladorLocacao)
        {
            this.controladorLocacao = controladorLocacao;
            tabelaLocacaoControl = new TabelaLocacaoControl();
        }

        public void EditarRegistro()
        {
            int id = tabelaLocacaoControl.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione uma locação para poder editar!", "Edição de locação",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Locacao locacao = controladorLocacao.SelecionarPorId(id);

            TelaLocacaoForm telaLocacaoForm = new TelaLocacaoForm();

            telaLocacaoForm.Locacao = locacao;

            if (telaLocacaoForm.ShowDialog() == DialogResult.OK)
            {
                
                controladorLocacao.Editar(id, telaLocacaoForm.Locacao);

                List<Locacao> locacaos = controladorLocacao.SelecionarTodasLocacoesAtivas();

                tabelaLocacaoControl.AtualizarRegistros(locacaos);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Locação de: [{telaLocacaoForm.Locacao.id_cliente}] editada com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaLocacaoControl.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Locação para poder excluir!", "Exclusão de veículos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Locacao locacao = controladorLocacao.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir a Locação de: [{locacao.id_cliente}] ?",
                "Exclusão  de veículos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controladorLocacao.Excluir(id);

                List<Locacao> locacaos = controladorLocacao.SelecionarTodos();

                tabelaLocacaoControl.AtualizarRegistros(locacaos);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Locação removido com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            TelaLocacaoForm telaLocacaoForm = new TelaLocacaoForm();

            if (telaLocacaoForm.ShowDialog() == DialogResult.OK)
            {            
                controladorLocacao.InserirNovo(telaLocacaoForm.Locacao);         

                GeradorPDF.GerarPDF(telaLocacaoForm.Locacao);

                List<Locacao> locacaos = controladorLocacao.SelecionarTodos();

                tabelaLocacaoControl.AtualizarRegistros(locacaos);

                TelaPrincipal.Instancia.AtualizarRodape($"                                                     Locação: [{telaLocacaoForm.Locacao.id_cliente}] inserido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<Locacao> locacaos = controladorLocacao.SelecionarTodos();

            tabelaLocacaoControl.AtualizarRegistros(locacaos);

            return tabelaLocacaoControl;
        }

    }
}
