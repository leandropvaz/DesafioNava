using Nava.Calculadora.FluxoCaixa.Domain.Models;

namespace Nava.Calculadora.FluxoCaixa.Application.Interfaces
{
    public interface ILoginService
    {
        User EfetuaLogin(string username, string senha);
    }
}