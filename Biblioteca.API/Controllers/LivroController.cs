
using Microsoft.AspNetCore.Mvc;
using Biblioteca.Application.Services;
using Biblioteca.Domain.Entities;
using Biblioteca.API.DTOs;
using System.Linq;

namespace Biblioteca.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivroController : ControllerBase
    {
        // Serviço responsável por intermediar as operações relacionadas aos livros.
        private readonly LivroService _livroService;

        // Recebe o serviço por meio da injeção de dependência.
        public LivroController(LivroService livroService)
        {
            _livroService = livroService;
        }

        // Consulta todos os livros cadastrados e retorna a lista com HTTP 200 (OK).

        [HttpGet]
        public async Task<IActionResult> ListarTodos()
        {
            var livros = await _livroService.ListarTodosAsync();

            // Converte as entidades Livro em objetos LivroConsultaDto.
            var resultado = livros.Select(l => new LivroConsultaDto
            {
                IdLivro = l.IdLivro,
                Titulo = l.Titulo,
                AnoPublicacao = l.AnoPublicacao,
                Genero = l.Genero,
                QuantidadeExemplares = l.QuantidadeExemplares,
                IdAutor = l.IdAutor,

                Autor = new AutorResumoDto
                {
                    IdAutor = l.Autor.IdAutor,
                    Nome = l.Autor.Nome,
                    Nacionalidade = l.Autor.Nacionalidade
                }
            }).ToList();

            return Ok(resultado);
        }


        // Busca um livro pelo ID e retorna HTTP 200 (OK) ou 404 (Not Found).

        [HttpGet("{id}")]
        public async Task<IActionResult> BuscarPorId(int id)
        {
            var livro = await _livroService.BuscarPorIdAsync(id);

            if (livro == null)
            {
                return NotFound();
            }

            // Converte a entidade Livro em LivroConsultaDto.
            var resultado = new LivroConsultaDto
            {
                IdLivro = livro.IdLivro,
                Titulo = livro.Titulo,
                AnoPublicacao = livro.AnoPublicacao,
                Genero = livro.Genero,
                QuantidadeExemplares = livro.QuantidadeExemplares,
                IdAutor = livro.IdAutor,

                Autor = new AutorResumoDto
                {
                    IdAutor = livro.Autor.IdAutor,
                    Nome = livro.Autor.Nome,
                    Nacionalidade = livro.Autor.Nacionalidade
                }
            };

            return Ok(resultado);
        }


        // Recebe os dados do livro, realiza o cadastro de forma assíncrona
        // e retorna HTTP 201 (Created) após a conclusão da operação.
        [HttpPost]
        public async Task<IActionResult> Cadastrar([FromBody] LivroCadastroDto dto)
        {
            // Cria uma entidade Livro a partir dos dados recebidos no DTO.
            var livro = new Livro
            {
                Titulo = dto.Titulo,
                AnoPublicacao = dto.AnoPublicacao,
                Genero = dto.Genero,
                QuantidadeExemplares = dto.QuantidadeExemplares,
                IdAutor = dto.IdAutor
            };

            // Encaminha a solicitação de cadastro ao Service, que delega a operação ao Repository.
            await _livroService.AdicionarAsync(livro);

            // Retorna HTTP 201, os dados cadastrados e o endereço para consulta do livro.
            return CreatedAtAction(
                nameof(BuscarPorId),
                new { id = livro.IdLivro },
                livro);
        }

        // Localiza o livro pelo ID, atualiza seus dados e retorna HTTP 200 (OK).
        // Caso o registro não exista, retorna HTTP 404 (Not Found).
        [HttpPut("{id}")]
        public async Task<IActionResult> Atualizar(int id, [FromBody] LivroCadastroDto dto)
        {
            var livroExistente = await _livroService.BuscarPorIdAsync(id);

            if (livroExistente == null)
            {
                return NotFound();
            }

            livroExistente.Titulo = dto.Titulo;
            livroExistente.AnoPublicacao = dto.AnoPublicacao;
            livroExistente.Genero = dto.Genero;
            livroExistente.QuantidadeExemplares = dto.QuantidadeExemplares;
            livroExistente.IdAutor = dto.IdAutor;

            await _livroService.AtualizarAsync(livroExistente);

            return Ok(livroExistente);
        }

        // Verifica a existência do livro pelo ID e realiza sua exclusão.
        // Retorna HTTP 204 (No Content) ou HTTP 404 (Not Found).
        [HttpDelete("{id}")]
        public async Task<IActionResult> Excluir(int id)
        {
            var livro = await _livroService.BuscarPorIdAsync(id);

            if (livro == null)
            {
                return NotFound();
            }

            await _livroService.ExcluirAsync(id);

            return NoContent();
        }
    }
}
