using System;
using System.Collections.Generic;

namespace Biblioteca.Domain.Entities
{
    public class Livro
    {
        // Identificador único do livro
        public int IdLivro { get; set; }

        // Título do livro
        public string Titulo { get; set; } = string.Empty;

        // Ano de publicação do livro
        public int AnoPublicacao { get; set; }

        //Gênero literário do livro
        public string Genero { get; set; } = string.Empty;

        // Quantidade de exemplares do livro
        public int QuantidadeExemplares { get; set; }

        // Chave estrangeira
        public int IdAutor { get; set; }

        // Referência ao autor
        public Autor Autor { get; set; } = null!;
    }
}
