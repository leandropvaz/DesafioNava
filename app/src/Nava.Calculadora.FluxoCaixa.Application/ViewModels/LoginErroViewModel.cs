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
    public class LoginErroViewModel
    {
        [SwaggerSchema("Mensagem de erro ao não validar usuário", Nullable = true)]
        public string Menssage { get; set; }
    }
}