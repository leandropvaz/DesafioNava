using Nava.Calculadora.FluxoCaixa.Application.Interfaces;
using Nava.Calculadora.FluxoCaixa.Domain.Enum;
using Nava.Calculadora.FluxoCaixa.Domain.Models;
using Nava.Calculadora.FluxoCaixa.Infra.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nava.Calculadora.FluxoCaixa.Application.Services
{
    public class FluxoCaixaService : IFluxoCaixaService
    {

        private readonly ILancamento _lancamento;
        public FluxoCaixaService(ILancamento lancamento)
        {
            _lancamento = lancamento;
        }

        public List<ConsolidadoDiario> GetConsolidadoDiario(DateTime data)
        {
            return _lancamento.GetConsolidadoDiario(data);
        }

        public bool SetLancamento(DateTime data, double valor, TipoLancamento operacao)
        {
            return _lancamento.SetLancamento(data, valor, operacao);
        }
    }
}