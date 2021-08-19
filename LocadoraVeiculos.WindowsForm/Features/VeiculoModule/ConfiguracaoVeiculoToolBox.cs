using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.WindowsForm.Features.GrupoVeiculosModule
{
    public class ConfiguracaoVeiculoToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar
        {
            get { return "Adicionar um novo de Veículo"; }
        }

        public string TipoCadastro
        {
            get { return "Veículos"; }
        }

        public string ToolTipEditar
        {
            get { return "Editar um Veículo"; }
        }

        public string ToolTipExcluir
        {
            get { return "Excluir um Veículo"; }
        }
    }
}
