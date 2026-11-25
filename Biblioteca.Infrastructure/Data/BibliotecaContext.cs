using System;
using System.Collections.Generic;
using Biblioteca.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Infrastructure.Data
{
    // Classe responsável por gerenciar a comunicação entre a aplicação e o banco de dados.
    public class BibliotecaContext : DbContext
    {
        // Recebe as configurações do Entity Framework e as repassa para a classe DbContext.
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options)
            : base(options)
        {
        }

        // Define as entidades que serão gerenciadas pelo DbContext
        // e representadas no banco de dados.
        public DbSet<Autor> Autores { get; set; }

        public DbSet<Livro> Livros { get; set; }

        // Configura os relacionamentos entre as entidades do banco de dados.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define o relacionamento de um autor para vários livros,
            // utilizando IdAutor como chave estrangeira.

            modelBuilder.Entity<Autor>()
               .HasKey(a => a.IdAutor);

            modelBuilder.Entity<Livro>()
                .HasKey(l => l.IdLivro);

            modelBuilder.Entity<Autor>()
                .HasMany(a => a.Livros)
                .WithOne(l => l.Autor)
                .HasForeignKey(l => l.IdAutor)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}