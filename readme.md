# Consumindo a API ViaCEP com .NET

Este repositório contém um exemplo simples de como consumir a **API ViaCEP** usando o framework **.NET**. O projeto realiza uma consulta de CEP e exibe as informações relacionadas ao endereço correspondente.

## Funcionalidade

Este projeto utiliza a API pública do ViaCEP para consultar informações sobre um determinado CEP. Quando o CEP é informado, o sistema retorna dados como:

- Logradouro
- Bairro
- Localidade
- UF (Estado)
- Código IBGE
- DDD
- SIAFI

## Requisitos

- **.NET SDK** (versão 6 ou superior)

## Pacotes Utilizados

- **Newtonsoft.Json**: Biblioteca para manipulação de JSON.
  - Pacote: `Newtonsoft.Json`
  - Comando para instalar: `dotnet add package Newtonsoft.Json`

- **System.Net.Http**: Biblioteca padrão do .NET para fazer requisições HTTP.
  - Este pacote já vem incluso no .NET, então não precisa ser instalado separadamente.

## Link da aula
- [Clique aqui](https://youtu.be/e2GSxhS1eaU)