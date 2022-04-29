using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nava.Calculadora.FluxoCaixa.Application.Interfaces;
using Nava.Calculadora.FluxoCaixa.Application.ViewModels;
using Nava.Calculadora.FluxoCaixa.Domain.Enum;
using Nava.Calculadora.FluxoCaixa.Domain.Models;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Nava.Calculadora.FluxoCaixa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class FluxoCaixaController : ControllerBase
    {
        private readonly ILoginService _loginService;
        private readonly IFluxoCaixaService _fluxoCaixaService;

        public FluxoCaixaController(ILoginService loginService, IFluxoCaixaService fluxoCaixaService)
        {
            _loginService = loginService;
            _fluxoCaixaService = fluxoCaixaService;
        }


        [HttpPost("Autenticar")]
        [SwaggerOperation(Summary = "EndPoint de validação/autenticação", Description = "Endpoint responsável por validar e autenticar o usuário")]
        [SwaggerResponse(200, "Validação de usuário realizada com sucesso.", typeof(User))]
        [SwaggerResponse(401, "Error ao validar usuário. Usuário sem permissão de acesso.", typeof(LoginErroViewModel))]
        [SwaggerResponse(400, "Error ao processar requisição.")]
        [ExcludeFromCodeCoverage]
        public IActionResult Autenticar([FromBody, SwaggerRequestBody("Login playload", Required = true)] LoginViewModel login)
        {
            var user = _loginService.EfetuaLogin(login.Username, login.Senha);
            try
            {
                if (user == null)
                    return Unauthorized(new { Menssage = "Usuário ou senha inválidos." });

                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("InserirLancamento")]
        [Authorize]
        [SwaggerOperation(Summary = "Lançamentos de débitos/créditos", Description = "Endpoint responsável por inserir os lançamentos de débitos/créditos")]
        [SwaggerResponse(200, "Validação de usuário realizada com sucesso.")]
        [SwaggerResponse(400, "Error ao processar operação de Lançamentos de débitos/créditos.")]
        [ExcludeFromCodeCoverage]
        public IActionResult InserirLancamento([FromBody, SwaggerRequestBody("Lançamento playload", Required = true)] LancamentoViewModel lancamento)
        {
            try
            {
                if (String.IsNullOrEmpty(lancamento.DataLancamento) || String.IsNullOrEmpty(lancamento.Valor) || String.IsNullOrEmpty(lancamento.Operacao))
                    return BadRequest(new { Menssage = "Error ao processar operação de Lançamentos de débitos/créditos. - Campos obrigatórios não preenchidos" });

                var lancamentos = _fluxoCaixaService.SetLancamento(Convert.ToDateTime(lancamento.DataLancamento), Convert.ToDouble(lancamento.Valor), Enum.Parse<TipoLancamento>(lancamento.Operacao));
                return Ok(new { Menssage = "Lançamento inserido com sucesso!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpGet("ConsolidadoDiario")]
        [Authorize]
        [SwaggerOperation(Summary = "Relatório consolidado até a data informada", Description = "Endpoint responsável por gerar relatório consolidado até a data informada.")]
        [SwaggerResponse(200, "Relatório consolidado gerado com sucesso.")]
        [SwaggerResponse(400, "Error ao buscar relatório consolidado.")]
        [ExcludeFromCodeCoverage]
        public IActionResult ConsolidadoDiario(string dataconsolidado)
        {
            try
            {
                DateTime data;
                if (!DateTime.TryParse(dataconsolidado, out data))
                    return BadRequest(new { Menssage = "Error ao buscar relatório consolidado. - Verifique a data informada." });

                var consolidado = _fluxoCaixaService.GetConsolidadoDiario(data);

                if (consolidado == null || consolidado.Count == 0)
                    return BadRequest(new { Menssage = "Não existe dados para a data informada." });

                return Ok(consolidado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}