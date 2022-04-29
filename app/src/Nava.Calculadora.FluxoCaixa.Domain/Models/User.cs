using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nava.Calculadora.FluxoCaixa.Domain.Models
{
    public class User
    {
        [SwaggerSchema("Id do Usuário", Nullable = false, ReadOnly = true)]
        public int Id { get; set; }
        [SwaggerSchema("Login do Usuário", Nullable = false)]
        public string Username { get; set; }
        [SwaggerSchema("Senha do Usuário", Nullable = false)]
        public string Senha { get; set; }
        [SwaggerSchema("Token de autenticação gerado para acessar os endpoints de acesso restrito.", Nullable = true)]
        public string Token { get; set; }
    }
}