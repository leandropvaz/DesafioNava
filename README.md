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
- 
## User Credentials
- **UserName**: Leandro
- **Password**: 123456

## Token Credentials
- A autenticação é implementada por meio de tokens de acesso JWT. A API retorna um token de curta duração (JWT), que expira em 1 hora.
- Os serviços de lançamentos de créditos e débitos e geraçao do consolidado requer autenticação.

## Cobertura de Testes
- **Code Coverage**: Visando a qualidade código está coberto em 98,21% 

## Rodando ambiente com Docker
- Acesse o diretório em que o repositório foi clonado através do terminal e execute os comandos:
- docker-compose build para compilar imagens, criar containers etc.
