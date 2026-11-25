
using System.Collections.Generic;

namespace Biblioteca.Domain.Entities
{
    public class Autor
    {
        // Identificador único do autor.
        public int IdAutor { get; set; }

        // Nome do autor.
        public string Nome { get; set; } = string.Empty;

        // Nacionalidade do autor.
        public string Nacionalidade { get; set; } = string.Empty;

        // Relacionamento: um autor possui vários livros.
        // Inicializa a coleção para evitar null reference exceptions.
        public ICollection<Livro> Livros { get; set; } = new List<Livro>();
    }
}

