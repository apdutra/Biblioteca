using Biblioteca.Application.Interfaces;
using Biblioteca.Domain.Entities;
using Biblioteca.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Biblioteca.Infrastructure.Repositories
{
    // Implementa os métodos definidos na interface ILivroRepository.
    public class LivroRepository : ILivroRepository
    {
        // Contexto responsável pelo acesso ao banco de dados.
        private readonly BibliotecaContext _context;

        // Recebe o contexto do banco através da injeção de dependência.
        public LivroRepository(BibliotecaContext context)
        {
            _context = context;
        }

        // Métodos assincronos para operações de CRUD (Create, Read, Update, Delete) de livros.
        
        // Adicionar
        public async Task AdicionarAsync(Livro livro)
        {
            await _context.Livros.AddAsync(livro);
            await _context.SaveChangesAsync();
        }

        // Listar livros
        public async Task<List<Livro>> ListarTodosAsync()
        {
            return await _context.Livros
                .Include(l => l.Autor)
                .ToListAsync();
        }

        // Buscar livro pelo ID
       
        public async Task<Livro?> BuscarPorIdAsync(int id)
        {
            return await _context.Livros
                .Include(l => l.Autor)
                .FirstOrDefaultAsync(l => l.IdLivro == id);
        }

        // Atualizar cadastro
        public async Task AtualizarAsync(Livro livro)
        {
            var livroExistente = await _context.Livros.FindAsync(livro.IdLivro);

            if (livroExistente != null)
            {
                livroExistente.Titulo = livro.Titulo;
                livroExistente.AnoPublicacao = livro.AnoPublicacao;
                livroExistente.Genero = livro.Genero;
                livroExistente.QuantidadeExemplares = livro.QuantidadeExemplares;
                livroExistente.IdAutor = livro.IdAutor;

                await _context.SaveChangesAsync();
            }
        }

        // Excluir livro
        public async Task ExcluirAsync(int id)
        {
            var livro = await _context.Livros.FindAsync(id);

            if (livro != null)
            {
                _context.Livros.Remove(livro);
                await _context.SaveChangesAsync();
            }
        }
    }
}