using System;
using Nava.Calculadora.FluxoCaixa.Testing.Mock;
using NUnit.Framework;
using NSubstitute;
using ExpectedObjects;
using FluentAssertions;
using Nava.Calculadora.FluxoCaixa.Application.Services;
using Nava.Calculadora.FluxoCaixa.Infra.Repository.Interfaces;
using Nava.Calculadora.FluxoCaixa.Domain.Enum;
using Nava.Calculadora.FluxoCaixa.Infra.Repository.Repositories;

namespace Nava.Calculadora.FluxoCaixa.Testing.UnitTest
{
    public class FluxoCaixaServiceTest
    {
        private ILancamento _lancamento;
        private IUserRepository _userRepository;


        [SetUp]
        public void Setup()
        {
            _lancamento = Substitute.For<LancamentoRepository>();
            _userRepository = Substitute.For<UserRepository>();
            Environment.SetEnvironmentVariable("SECRET_KEY", "a27d05b503cecc994ae196a881d5e1702c8567b447532cd67639401b4e552edc");
        }

        [Test]
        [Order(1)]
        public void Obter_DadosLancamentoFake()
        {
            var dadoslanc = MockDataFake.MockDadosLancamento();
            var expected = dadoslanc.ToExpectedObject();
            expected.Should().NotBeNull();
            expected.ShouldEqual(dadoslanc);
        }
        [Test]
        [Order(2)]
        public void SetLancamentosDiarios_Sucesso()
        {
            var fluxodiario = new FluxoCaixaService(_lancamento);
            var result = fluxodiario.SetLancamento(Convert.ToDateTime("25/04/2022"), 15, Enum.Parse<TipoLancamento>("2"));
            result.Should().BeTrue();
        }

        [Test]
        [Order(3)]
        public void GetConsolidadoDiario_Sucesso()
        {
            var fluxodiario = new FluxoCaixaService(_lancamento);
            fluxodiario.SetLancamento(Convert.ToDateTime("25/04/2022"), 15, Enum.Parse<TipoLancamento>("2"));
            var result = fluxodiario.GetConsolidadoDiario(Convert.ToDateTime("25/04/2022"));
            result.Should().HaveCountGreaterThan(0);
        }
        [Test]
        [Order(4)]
        public void GetConsolidadoDiarioSemDados()
        {
            var fluxodiario = new FluxoCaixaService(_lancamento);
            fluxodiario.SetLancamento(Convert.ToDateTime("26/04/2022"), 15, Enum.Parse<TipoLancamento>("2"));
            var result = fluxodiario.GetConsolidadoDiario(Convert.ToDateTime("25/04/2022"));
            result.Should().HaveCount(0);
        }

        [Test]
        [Order(5)]
        public void EfetuaLogin_Sucesso()
        {
            var user = new LoginService(_userRepository);
            var result = user.EfetuaLogin("Leandro", "123456");
            result.Should().NotBeNull();
        }

        [Test]
        [Order(6)]
        public void EfetuaLogin_Erro()
        {
            var user = new LoginService(_userRepository);
            var result = user.EfetuaLogin("Leandro", "1234567");
            result.Should().BeNull();
        }


    }

}