
namespace Biblioteca.API.DTOs
{
    public class LivroResumoDto
    {
        public int IdLivro { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public int AnoPublicacao { get; set; }
        public string Genero { get; set; } = string.Empty;
        public int QuantidadeExemplares { get; set; }
    }
}
