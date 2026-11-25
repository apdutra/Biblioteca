using Microsoft.AspNetCore.Mvc;
using Biblioteca.Application.Services;
using Biblioteca.Domain.Entities;
using Biblioteca.API.DTOs;
using System.Linq;

namespace Biblioteca.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AutorController : ControllerBase
    {
        // Serviço responsável pelas operações relacionadas aos autores.
        private readonly AutorService _autorService;

        // Recebe o serviço por meio da injeção de dependência.
        public AutorController(AutorService autorService)
        {
            _autorService = autorService;
        }

        // Consulta todos os autores cadastrados e retorna HTTP 200 (OK).
        [HttpGet]
        public async Task<IActionResult> ListarTodos()
        {
            var autores = await _autorService.ListarTodosAsync();

            return Ok(autores);
        }

        // Busca um autor pelo ID e retorna HTTP 200 (OK) ou 404 (Not Found).
        [HttpGet("{id}")]
        public async Task<IActionResult> BuscarPorId(int id)
        {
            var autor = await _autorService.BuscarPorIdAsync(id);

            if (autor == null)
            {
                return NotFound();
            }

            return Ok(autor);
        }


        [HttpGet("{id}/livros")]
        public async Task<IActionResult> BuscarPorIdComLivros(int id)
        {
            // Busca o autor pelo ID, incluindo seus livros relacionados.
            var autor = await _autorService.BuscarPorIdComLivrosAsync(id);

            if (autor == null)
            {
                return NotFound();
            }

            // Converte a entidade Autor em AutorConsultaDto.
            var resultado = new AutorConsultaDto
            {
                IdAutor = autor.IdAutor,
                Nome = autor.Nome,
                Nacionalidade = autor.Nacionalidade,

                // Converte a coleção de livros em uma lista de LivroResumoDto.
                Livros = autor.Livros.Select(l => new LivroResumoDto
                {
                    IdLivro = l.IdLivro,
                    Titulo = l.Titulo,
                    AnoPublicacao = l.AnoPublicacao,
                    Genero = l.Genero,
                    QuantidadeExemplares = l.QuantidadeExemplares
                }).ToList()
            };

            return Ok(resultado);
        }


        // Recebe os dados do autor, realiza o cadastro de forma assíncrona
        // e retorna HTTP 201 (Created).

        [HttpPost]
        public async Task<IActionResult> Cadastrar([FromBody] AutorCadastroDto dto)
        {
            // Cria uma entidade Autor a partir dos dados recebidos no DTO.
            var autor = new Autor
            {
                Nome = dto.Nome,
                Nacionalidade = dto.Nacionalidade
            };

            // Encaminha a solicitação de cadastro ao Service.
            await _autorService.AdicionarAsync(autor);

            // Retorna HTTP 201 e o endereço para consulta do autor cadastrado.
            return CreatedAtAction(
                nameof(BuscarPorId),
                new { id = autor.IdAutor },
                autor);
        }


       

        // Localiza o autor pelo ID, atualiza seus dados e retorna HTTP 200 (OK).
        // Caso o registro não exista, retorna HTTP 404 (Not Found).

        [HttpPut("{id}")]
        public async Task<IActionResult> Atualizar(int id, [FromBody] AutorCadastroDto dto)
        {
            // Busca o autor pelo identificador.
            var autorExistente = await _autorService.BuscarPorIdAsync(id);

            if (autorExistente == null)
            {
                return NotFound();
            }

            // Atualiza os dados do autor.
            autorExistente.Nome = dto.Nome;
            autorExistente.Nacionalidade = dto.Nacionalidade;

            // Encaminha a solicitação de atualização ao Service.
            await _autorService.AtualizarAsync(autorExistente);

            return Ok(autorExistente);
        }


        // Verifica a existência do autor pelo ID e realiza sua exclusão.
        // Retorna HTTP 204 (No Content) ou HTTP 404 (Not Found).
        [HttpDelete("{id}")]
        public async Task<IActionResult> Excluir(int id)
        {
            var autor = await _autorService.BuscarPorIdAsync(id);

            if (autor == null)
            {
                return NotFound();
            }

            await _autorService.ExcluirAsync(id);

            return NoContent();
        }
    }
}
