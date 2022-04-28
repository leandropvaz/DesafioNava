# DesafioNava
Desafio Nava / Carrefour - Api responsável por gerenciar lançamentos de fluxo diário.

# Enriquecimento(Identificador do TV7) - DotNet Core 3.1

Serviço que captura as operações para o sistema TV7 e enriquece com a parametrização de produto do mesmo.

## Principais funcionalidades do Enriquecimento:

Funcionalidades:

<ol>
	<li> Captura das operações no bucket; </li>
	<li> Enriquecimento com parâmetro próprios (Família Curva de sobrevivência) </li>
	<li> Carimbo das taxas avindos do sistema IM; </li>
	<li> Evolução para o calculo de encurtamento; </li>
</ol>


## Hierarquia de Pastas


| **Diretório**                                 | **Descrição**                        | **O que o diretório pode conter**                                                                                                               |
| -------------------------------------------   |--------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------|
| **/app**                                      | Source da aplicação e Teste Unitário | Código Fonte da aplicação `(Source) juntamente com o Teste Unitário`                                                                              |
| **/tests/test&#x2011;integration**            | Testes de Integração                 | Arquivo `app-gherkin.feature` para testes de Integração de API                                                                                  |
| **/tests/test&#x2011;performance**            | Testes de Performance                | Arquivo `app.jmx` para testes de performance.                                                                                                   |
| **/infra**                                    | Criação de Infraestrutura            | Arquivo YAML em formato CLOUDFORMATION CUSTOMIZADO, para criação de infraestrutura. <br>EX: Services e Tasks do cluster ECS (`service.yaml`).   |

## Requirimentos de infra

- [infrarediscluster](https://gitcorp.prod.cloud.ihf/TV7/TV7/riscovarejo-infrarediscluster)
- [infraenriquecimentoecs](https://gitcorp.prod.cloud.ihf/TV7/riscovarejo-infraenriquecimentoecs)
- [infrasplunk](https://gitcorp.prod.cloud.ihf/TV7/riscovarejo-infrasplunk)
- [infrakaasconnectivity](https://gitcorp.prod.cloud.ihf/TV7/riscovarejo-infrakaasconnectivity)
- [infradomainroles](https://gitcorp.prod.cloud.ihf/TV7/riscovarejo-infradomainroles)
- [inframetricassappdy](https://gitcorp.prod.cloud.ihf/TV7/calculovariaveisfinanceiras-inframetricassappdy)

## Environment variables
- **CLIENT_ID**: identificação do cliente para o Kafka
- **NO_PROXY**: endereço/porta para uso de um proxy
- **APP_NAME**: nome da aplicação
- **ASPNETCORE_ENVIRONMENT**: variável que identifica o ambiente de execução para o Kafka
- **GROUP_ID**: nome do grupo utilizado no `consumer` do Kafka
- **KAFKA_CONSUMER_AUTOCOMMIT**: Confirmação de commit da msg. Quando false a msg poderá ser recuperada mais de uma vez.
- **TOPIC**: tópico da fila do Kafka
- **COMMUNITY**: comunidade da Squad responsável pela aplicação
- **SIGLA**: sigla responsável pela aplicação
- **USER**: usuário utilizado na geração do certificado
- **USER_PASSWORD**: password utilizado na geração do certificado
- **SSL_CERT_LOCATION**: local onde será gerado o certificado `.crt`
- **SSL_KEY_LOCATION**: local onde será gerado o arquivo `.p12`
- **SSL_KEY_PASS**: password utilizado para gerar o certificado.
- **BOOTSTRAP_SERVER**: endereço do Kafka
- **URL_REGISTRY**: caminho do schema registry `(AVROS)`
- **REDIS_ENDPOINT_READ_ONLY**: Endpoint de leitura do cluster do Redis
- **REDIS_ENDPOINT** Endpoint primary do cluster de Redis
- **REDIS_PASS** Secret contendo o password do redis
- **APP_DB_NAME**: Nome da base banco de dados RDS;
- **APP_DB_PASS**: Senha banco de dados RDS;
- **APP_DB_USER**: Usuario banco de dados RDS;
- **APP_DB_ENDPOINT**: Endpoint banco de dados RDS;
- **APP_ENCURTAMENTO_ENDPOINT**: endereço da comunicação com Itau.TV7.encurtamento;

