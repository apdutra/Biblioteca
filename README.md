# 📚 Biblioteca — Sistema de Gerenciamento

Projeto acadêmico desenvolvido em **C# e .NET 10**, com ASP.NET Core Web API, Entity Framework Core e SQLite.

O sistema permite gerenciar autores e livros, aplicando conceitos de desenvolvimento de software, arquitetura em camadas, persistência de dados e processamento assíncrono.

## 🚀 Tecnologias utilizadas

- C#
- .NET 10
- ASP.NET Core Web API
- Entity Framework Core
- SQLite
- Swagger / OpenAPI
- Injeção de Dependência
- Repository Pattern
- Programação assíncrona (`async/await`)

## 🏗️ Arquitetura do projeto

A solução está organizada em quatro projetos:

| Projeto | Responsabilidade |
|---|---|
| **Biblioteca.Domain** | Entidades e regras do domínio |
| **Biblioteca.Application** | Interfaces e serviços da aplicação |
| **Biblioteca.Infrastructure** | Contexto do banco de dados e repositórios |
| **Biblioteca.API** | Controllers, DTOs e endpoints HTTP |

## 📖 Funcionalidades

- Cadastro, consulta, atualização e exclusão de autores.
- Cadastro, consulta, atualização e exclusão de livros.
- Consulta de livros relacionados a um autor.
- Relacionamento 1:N entre Autor e Livro.
- Persistência de dados com Entity Framework Core e SQLite.
- Operações assíncronas utilizando `async/await`.
- Documentação e testes dos endpoints com Swagger.

## 🔗 Relacionamento entre entidades

Um autor pode possuir vários livros, enquanto cada livro está associado a um único autor.

**Autor (1) → (N) Livro**

## ⚙️ Como executar o projeto

1. Instale o .NET 10 SDK.
2. Clone o repositório:

   `git clone https://github.com/apdutra/Biblioteca.git`

3. Entre na pasta do projeto:

   `cd Biblioteca`

4. Abra `Biblioteca.sln` no Visual Studio.
5. Defina `Biblioteca.API` como projeto de inicialização.
6. Execute a aplicação.
7. Acesse a interface Swagger pela URL indicada no navegador.

## 🌐 Principais endpoints

### Autores

| Método | Endpoint | Operação |
|---|---|---|
| GET | `/api/Autor` | Listar autores |
| GET | `/api/Autor/{id}` | Consultar autor |
| GET | `/api/Autor/{id}/livros` | Consultar autor e seus livros |
| POST | `/api/Autor` | Cadastrar autor |
| PUT | `/api/Autor/{id}` | Atualizar autor |
| DELETE | `/api/Autor/{id}` | Excluir autor |

### Livros

| Método | Endpoint | Operação |
|---|---|---|
| GET | `/api/Livro` | Listar livros |
| GET | `/api/Livro/{id}` | Consultar livro |
| POST | `/api/Livro` | Cadastrar livro |
| PUT | `/api/Livro/{id}` | Atualizar livro |
| DELETE | `/api/Livro/{id}` | Excluir livro |

## 🎓 Objetivo acadêmico

Projeto desenvolvido para estudo e aplicação prática de conceitos de programação orientada a objetos, Entity Framework Core, arquitetura em camadas, Repository Pattern, Services, Injeção de Dependência, relacionamento entre entidades e processamento assíncrono em ASP.NET Core.

## 👩‍💻 Repositório

[GitHub — Biblioteca](https://github.com/apdutra/Biblioteca)
