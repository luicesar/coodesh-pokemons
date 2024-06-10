# Backend Challenge - Pokémons

# Pokémon API

## Descrição
Esta é uma API para listar Pokémon utilizando a PokeAPI. Permite também cadastrar um mestre Pokémon e registrar Pokémon capturados.

## Configuração do Ambiente
1. Instale o .NET SDK: [Instalação do .NET SDK](https://docs.microsoft.com/pt-br/dotnet/core/install/linux-ubuntu)
2. Configure o Visual Studio Code com a extensão C#.

## Como Rodar o Projeto
1. Clone o repositório.
2. Execute `dotnet restore` para instalar as dependências.
3. Execute `dotnet run` para iniciar o servidor.

## Endpoints
- `GET /pokemon/{id}`: Obtém um Pokémon pelo ID.
- `GET /pokemon/random`: Obtém 10 Pokémon aleatórios.
- `POST /trainer`: Cadastra um mestre Pokémon.
- `POST /trainer/{trainerId}/capture/{pokemonId}`: Registra um Pokémon capturado.
- `GET /trainer/{trainerId}/captured`: Lista os Pokémon capturados por um mestre Pokémon.

## Decisões de Design
- A API interage com a PokeAPI para obter dados de Pokémon.
- Utiliza Entity Framework Core com SQLite para armazenar dados de mestres Pokémon e Pokémon capturados.

## Pontos de Melhoria
- Implementar cache para reduzir chamadas à PokeAPI.
- Adicionar autenticação para proteger os endpoints.
