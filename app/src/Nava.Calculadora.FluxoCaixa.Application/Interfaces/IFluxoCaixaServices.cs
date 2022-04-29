using Nava.Calculadora.FluxoCaixa.Domain.Enum;
using Nava.Calculadora.FluxoCaixa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nava.Calculadora.FluxoCaixa.Application.Interfaces
{
    public interface IFluxoCaixaService
    {
        List<ConsolidadoDiario> GetConsolidadoDiario(DateTime data);
        bool SetLancamento(DateTime data, double valor, TipoLancamento operacao);
    }
}