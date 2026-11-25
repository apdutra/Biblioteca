using System.Collections.Generic;
using System.Threading.Tasks;
using Biblioteca.Application.Interfaces;
using Biblioteca.Domain.Entities;

namespace Biblioteca.Application.Services
{
    public class AutorService
    {
        // Dependência responsável pelas operações de persistência de autores.
        private readonly IAutorRepository _autorRepository;

        // Recebe o repositório através de injeção de dependência.
        public AutorService(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        // Encaminha a solicitação de cadastro de um autor ao repositório.
        // Aguarda de forma assíncrona a conclusão da operação.
        public async Task AdicionarAsync(Autor autor)
        {
            await _autorRepository.AdicionarAsync(autor);
        }

        // Solicita ao repositório todos os autores cadastrados.
        // Retorna a lista após a conclusão da operação assíncrona.
        public async Task<List<Autor>> ListarTodosAsync()
        {
            return await _autorRepository.ListarTodosAsync();
        }

        // Solicita ao repositório a busca de um autor pelo identificador.
        // Retorna o autor encontrado ou null caso não exista.
        public async Task<Autor?> BuscarPorIdAsync(int id)
        {
            return await _autorRepository.BuscarPorIdAsync(id);
        }

        // Encaminha a solicitação de atualização dos dados do autor ao repositório.
        // Aguarda de forma assíncrona a conclusão da operação.
        public async Task AtualizarAsync(Autor autor)
        {
            await _autorRepository.AtualizarAsync(autor);
        }

        // Encaminha a solicitação de exclusão do autor ao repositório.
        // Aguarda de forma assíncrona a conclusão da operação.
        public async Task ExcluirAsync(int id)
        {
            await _autorRepository.ExcluirAsync(id);
        }

        // Solicita ao repositório um autor incluindo seus livros relacionados.
        // Retorna o autor com sua lista de livros ou null caso não exista.
        public async Task<Autor?> BuscarPorIdComLivrosAsync(int id)
        {
            return await _autorRepository.BuscarPorIdComLivrosAsync(id);
        }
    }
}
