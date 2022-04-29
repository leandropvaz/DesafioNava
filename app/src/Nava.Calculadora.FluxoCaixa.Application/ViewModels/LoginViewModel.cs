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
    public class LoginViewModel
    {
        [SwaggerSchema("Login do Usuário", Nullable = false)]
        public string Username { get; set; }
        [SwaggerSchema("Senha do Usuário", Nullable = false)]
        public string Senha { get; set; }
    }
}