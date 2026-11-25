using System;
using System.Collections.Generic;
using Biblioteca.Domain.Entities;
using System.Threading.Tasks;

namespace Biblioteca.Application.Interfaces
{
    public interface ILivroRepository
    {
        // Métodos assíncronos para operações de CRUD (Create, Read, Update, Delete) de livros.
        
        // Adicionar livro
        Task AdicionarAsync(Livro livro);

        // Listar livros
        Task<List<Livro>> ListarTodosAsync();

        // Buscar livro pelo ID
        Task<Livro?> BuscarPorIdAsync(int id);

        // Atualizar cadastro
        Task AtualizarAsync(Livro livro);

        // Excluir livro
        Task ExcluirAsync(int id);
    }
}
