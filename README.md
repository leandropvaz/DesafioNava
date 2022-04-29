# DesafioNava
Desafio Nava / Carrefour - Serviço responsável por gerenciar lançamentos de fluxo diário.

## Principais funcionalidades do fluxo diário:

Funcionalidades:

<ol>
	<li> Lançamento de Débitos e Créditos; </li>
	<li> Relatório Consolidado até a data especifica; </li>
	<li> Serviço de validação e controle de usuários; </li>
</ol>


## Hierarquia de Pastas


| **Diretório**                                 | **Descrição**                        | **O que o diretório pode conter**                                                                                                               |
| -------------------------------------------   |--------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------|
| **/app**                                      | Source da aplicação e Teste Unitário | Código Fonte da aplicação `(Source) juntamente com o Teste Unitário`                                                                              |


## Environment variables
- **SECRET_KEY**: Hash utilizada para gerar Token de autenticação

## Cobertura de testes
- **Code Coverage**: Visando a qualidade código está coberto em 98,21% 

## Rodando ambiente com Docker
- Acesse o diretório em que o repositório foi clonado através do terminal e execute os comandos:
- docker-compose build para compilar imagens, criar containers etc.



