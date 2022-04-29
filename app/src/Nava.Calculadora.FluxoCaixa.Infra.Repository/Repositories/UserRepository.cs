using Nava.Calculadora.FluxoCaixa.Domain.Models;
using Nava.Calculadora.FluxoCaixa.Infra.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Nava.Calculadora.FluxoCaixa.Infra.Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User Get(string username, string senha)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, Username = "Leandro", Senha = "123456" });
            users.Add(new User { Id = 2, Username = "Douglas", Senha = "1234" });
            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Senha.ToLower() == senha.ToLower()).FirstOrDefault();
        }
    }
}