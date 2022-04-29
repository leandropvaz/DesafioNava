using Nava.Calculadora.FluxoCaixa.Domain.Enum;
using Nava.Calculadora.FluxoCaixa.Domain.Models;
using Nava.Calculadora.FluxoCaixa.Infra.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nava.Calculadora.FluxoCaixa.Infra.Repository.Repositories
{
    public class LancamentoRepository : ILancamento
    {
        List<Lancamento> lancamentos = new List<Lancamento>();

        public List<ConsolidadoDiario> GetConsolidadoDiario(DateTime data)
        {
            List<ConsolidadoDiario> consolidado = new List<ConsolidadoDiario>();

            double saldoConsolidado = 0.0;

            var lstsaldosDiarios = from lanc in lancamentos
                                   where lanc.DataLancamento.Date <= data.Date
                                   group lanc by lanc.DataLancamento into lancGroup
                                   orderby lancGroup.Key ascending
                                   select new
                                   {
                                       Data = lancGroup.Key,
                                       SaldoDiario = lancGroup.Sum(x => x.Valor),
                                   };

            foreach (var item in lstsaldosDiarios.ToList())
            {
                var itensLanc = lancamentos.Where(x => x.DataLancamento.Date == item.Data.Date).ToList();
                saldoConsolidado = (item.SaldoDiario + saldoConsolidado);
                consolidado.Add(new ConsolidadoDiario { DataConsolidado = item.Data, SaldoConsolidado = saldoConsolidado, lancamentosDiarios = itensLanc });

            }

            consolidado = (from lst in consolidado
                           orderby lst.DataConsolidado descending
                           select lst).ToList();

            return consolidado;

        }

        public bool SetLancamento(DateTime data, double valor, TipoLancamento Operacao)
        {
            lancamentos.Add(new Lancamento { DataLancamento = data, Valor = valor, Operacao = Operacao });
            return true;
        }



    }
}