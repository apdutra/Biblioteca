using System.Collections.Generic;
using System.Threading.Tasks;
using Biblioteca.Application.Interfaces;
using Biblioteca.Domain.Entities;
using Biblioteca.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Infrastructure.Repositories
{
    // Implementa os métodos definidos na interface IAutorRepository.
    public class AutorRepository : IAutorRepository
    {
        // Contexto responsável pelo acesso ao banco de dados.
        private readonly BibliotecaContext _context;

        // Recebe o contexto do banco através da injeção de dependência.
        public AutorRepository(BibliotecaContext context)
        {
            _context = context;
        }

        // Adiciona um autor ao contexto e salva no banco de dados de forma assíncrona.
        public async Task AdicionarAsync(Autor autor)
        {
            await _context.Autores.AddAsync(autor);
            await _context.SaveChangesAsync();
        }

        // Retorna todos os autores cadastrados no banco de forma assíncrona.
        public async Task<List<Autor>> ListarTodosAsync()
        {
            return await _context.Autores.ToListAsync();
        }

        // Busca o autor pelo identificador de forma assíncrona.
        // Retorna o autor encontrado ou null caso não exista.
        public async Task<Autor?> BuscarPorIdAsync(int id)
        {
            return await _context.Autores.FindAsync(id);
        }

        // Atualiza os dados de um autor no banco de forma assíncrona.
        public async Task AtualizarAsync(Autor autor)
        {
            _context.Autores.Update(autor);
            await _context.SaveChangesAsync();
        }

        // Busca o autor pelo identificador e, se existir,
        // realiza sua exclusão do banco de dados de forma assíncrona.
        public async Task ExcluirAsync(int id)
        {
            var autor = await _context.Autores.FindAsync(id);

            if (autor != null)
            {
                _context.Autores.Remove(autor);
                await _context.SaveChangesAsync();
            }
        }

        // Busca um autor pelo ID incluindo seus livros relacionados.
        public async Task<Autor?> BuscarPorIdComLivrosAsync(int id)
        {
            return await _context.Autores
                .Include(a => a.Livros)
                .FirstOrDefaultAsync(a => a.IdAutor == id);
        }
    }
}
