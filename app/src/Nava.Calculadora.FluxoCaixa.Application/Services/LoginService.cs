using Nava.Calculadora.FluxoCaixa.Application.Interfaces;
using Nava.Calculadora.FluxoCaixa.Domain.Models;
using Nava.Calculadora.FluxoCaixa.Infra.Repository.Interfaces;

namespace Nava.Calculadora.FluxoCaixa.Application.Services
{
    public class LoginService : ILoginService
    {

        private readonly IUserRepository _userRepository;
        public LoginService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User EfetuaLogin(string username, string senha)
        {
            var user = _userRepository.Get(username, senha);
            if (user == null)
                return null;
            TokenService.GenerateToken(user);
            return user;
        }
    }
}