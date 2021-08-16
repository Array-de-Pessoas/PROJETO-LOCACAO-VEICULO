using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.WindowsForm
{
    public interface IConfiguracaoToolBox
    {
        string ToolTipAdicionar { get; }

        string TipoCadastro { get; }
        string ToolTipEditar { get; }
        string ToolTipExcluir { get; }
    }
}
