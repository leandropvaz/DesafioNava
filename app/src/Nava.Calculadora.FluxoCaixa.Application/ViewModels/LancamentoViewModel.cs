using Nava.Calculadora.FluxoCaixa.Domain.Enum;
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
    public class LancamentoViewModel
    {
        [SwaggerSchema("Data da Operação", Nullable = false)]
        public string DataLancamento { get; set; }
        [SwaggerSchema("Valor da Operação", Nullable = false)]
        public string Valor { get; set; }
        [SwaggerSchema("Tipo da Operação (1 - Débito / 2 - Crédito)", Nullable = false)]
        public string Operacao { get; set; }
    }
}