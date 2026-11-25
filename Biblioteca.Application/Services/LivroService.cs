using System;
using System.Collections.Generic;
using Biblioteca.Application.Interfaces;
using Biblioteca.Domain.Entities;
using System.Threading.Tasks;

namespace Biblioteca.Application.Services
{

    public class LivroService
    {
        // Dependência responsável pelo acesso às operações de persistência dos livros.
        private readonly ILivroRepository _livroRepository;

        // Recebe o repositório por meio da injeção de dependência.
        public LivroService(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        // Encaminha a solicitação de cadastro de um livro ao repositório.
        // Aguarda de forma assíncrona a conclusão da operação.
        public async Task AdicionarAsync(Livro livro)
        {
            await _livroRepository.AdicionarAsync(livro);
        }

        // Solicita ao repositório a lista de todos os livros cadastrados.
        // Retorna os dados após a conclusão da operação assíncrona.
        public async Task<List<Livro>> ListarTodosAsync()
        {
            return await _livroRepository.ListarTodosAsync();
        }

        // Solicita ao repositório a busca de um livro pelo identificador.
        // Retorna o livro encontrado ou null caso não exista.
        public async Task<Livro?> BuscarPorIdAsync(int id)
        {
            return await _livroRepository.BuscarPorIdAsync(id);
        }

        // Encaminha a solicitação de atualização dos dados de um livro ao repositório.
        // Aguarda de forma assíncrona a conclusão da operação.
        public async Task AtualizarAsync(Livro livro)
        {
            await _livroRepository.AtualizarAsync(livro);
        }

        // Encaminha a solicitação de exclusão de um livro ao repositório.
        // Aguarda de forma assíncrona a conclusão da operação.
        public async Task ExcluirAsync(int id)
        {
            await _livroRepository.ExcluirAsync(id);
        }
    }

}