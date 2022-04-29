using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nava.Calculadora.FluxoCaixa.Application.ViewModels
{
    [ExcludeFromCodeCoverage]
    public class ConsolidadoViewModel
    {
        [SwaggerSchema("Data do Relatorio consolidado", Nullable = false)]

        public string DataConsolidado { get; set; }

    }
}