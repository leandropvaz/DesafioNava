using Nava.Calculadora.FluxoCaixa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nava.Calculadora.FluxoCaixa.Infra.Repository.Interfaces
{
    public interface IUserRepository
    {
        User Get(string username, string senha);
    }
}