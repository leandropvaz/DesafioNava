using Nava.Calculadora.FluxoCaixa.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nava.Calculadora.FluxoCaixa.Domain.Models
{
    public class Lancamento
    {
        //public int Id { get; set; }
        public DateTime DataLancamento { get; set; }
        public Double Valor { get; set; }
        public TipoLancamento Operacao { get; set; }
    }
}