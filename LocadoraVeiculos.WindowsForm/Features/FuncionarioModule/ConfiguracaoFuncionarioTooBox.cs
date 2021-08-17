using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.WindowsForm.Features.FuncionarioModule
{
    public class ConfiguracaoFuncionarioTooBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar
        {
            get { return "Adicionar um novo Funcionario"; }
        }

        public string TipoCadastro
        {
            get { return "Funcionario"; }
        }

        public string ToolTipEditar
        {
            get { return "Editar um Funcionario"; }
        }

        public string ToolTipExcluir
        {
            get { return "Excluir um Funcionario"; }
        }
    }
}
