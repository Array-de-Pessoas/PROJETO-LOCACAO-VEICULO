using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForm.Features.TaxasServicosModule
{
    public class ConfiguracaoTaxasServicosToolbox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar
        {
            get { return "Adicionar um novo Grupo de Veículos"; }
        }

        public string TipoCadastro
        {
            get { return "Grupo de Veículos"; }
        }

        public string ToolTipEditar
        {
            get { return "Editar um Grupo de Veículos"; }
        }

        public string ToolTipExcluir
        {
            get { return "Excluir um Grupo de Veículos"; }
        }

        
    }
}
