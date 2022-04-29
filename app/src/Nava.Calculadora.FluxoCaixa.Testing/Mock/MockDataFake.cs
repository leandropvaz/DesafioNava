using Nava.Calculadora.FluxoCaixa.Domain.Enum;
using Nava.Calculadora.FluxoCaixa.Domain.Models;
using System;
using System.Collections.Generic;

namespace Nava.Calculadora.FluxoCaixa.Testing.Mock
{
    public class MockDataFake
    {

        public static List<Lancamento> MockDadosLancamento()
        {
            List<Lancamento> lancamentos = new List<Lancamento>();


            lancamentos.Add(new Lancamento { DataLancamento = Convert.ToDateTime("25/04/2022"), Valor = 15, Operacao = Enum.Parse<TipoLancamento>("2") });
            lancamentos.Add(new Lancamento { DataLancamento = Convert.ToDateTime("25/04/2022"), Valor = 10, Operacao = Enum.Parse<TipoLancamento>("1") });

            lancamentos.Add(new Lancamento { DataLancamento = Convert.ToDateTime("26/04/2022"), Valor = 10, Operacao = Enum.Parse<TipoLancamento>("2") });
            lancamentos.Add(new Lancamento { DataLancamento = Convert.ToDateTime("26/04/2022"), Valor = 20, Operacao = Enum.Parse<TipoLancamento>("2") });
            lancamentos.Add(new Lancamento { DataLancamento = Convert.ToDateTime("26/04/2022"), Valor = 30, Operacao = Enum.Parse<TipoLancamento>("2") });

            lancamentos.Add(new Lancamento { DataLancamento = Convert.ToDateTime("27/04/2022"), Valor = 10, Operacao = Enum.Parse<TipoLancamento>("2") });
            lancamentos.Add(new Lancamento { DataLancamento = Convert.ToDateTime("27/04/2022"), Valor = -30, Operacao = Enum.Parse<TipoLancamento>("1") });

            lancamentos.Add(new Lancamento { DataLancamento = Convert.ToDateTime("28/04/2022"), Valor = 50, Operacao = Enum.Parse<TipoLancamento>("2") });
            lancamentos.Add(new Lancamento { DataLancamento = Convert.ToDateTime("28/04/2022"), Valor = -20, Operacao = Enum.Parse<TipoLancamento>("1") });

            return lancamentos;

        }
    }
}