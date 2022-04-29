using System;
using System.Collections.Generic;

namespace Nava.Calculadora.FluxoCaixa.Domain.Models
{
    public class ConsolidadoDiario
    {
        public DateTime DataConsolidado { get; set; }
        public Double SaldoConsolidado { get; set; }
        public List<Lancamento> lancamentosDiarios { get; set; }
    }
}