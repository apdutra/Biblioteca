using System.Collections.Generic;
using System.Threading.Tasks;
using Biblioteca.Domain.Entities;

namespace Biblioteca.Application.Interfaces
{
    public interface IAutorRepository
    {
        // Métodos assíncronos para operações de CRUD (Create, Read, Update, Delete) de autores
        
        //Adicionar autor
        Task AdicionarAsync(Autor autor);

        // Listar autores cadastrados
        Task<List<Autor>> ListarTodosAsync();

        // Buscar um autor pelo seu ID
        Task<Autor?> BuscarPorIdAsync(int id);

        // Atualizar dados de um autor cadastrado
        Task AtualizarAsync(Autor autor);

        // Excluir um autor
        Task ExcluirAsync(int id);

        // Buscar um autor pelo seu ID, incluindo os livros associados a ele
        Task<Autor?> BuscarPorIdComLivrosAsync(int id);
    }
}
