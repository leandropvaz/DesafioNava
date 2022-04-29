using Microsoft.Extensions.DependencyInjection;
using Nava.Calculadora.FluxoCaixa.Application.Interfaces;
using Nava.Calculadora.FluxoCaixa.Application.Services;
using Nava.Calculadora.FluxoCaixa.Infra.Repository.Interfaces;
using Nava.Calculadora.FluxoCaixa.Infra.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nava.Calculadora.FluxoCaixa.Infra.CrossCutting.IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ILoginService, LoginService>();
            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddSingleton<ILancamento, LancamentoRepository>();
            services.AddScoped<IFluxoCaixaService, FluxoCaixaService>();
        }
    }
}