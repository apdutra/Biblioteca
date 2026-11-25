
namespace Biblioteca.API.DTOs
{
    public class LivroConsultaDto
    {
        public int IdLivro { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public int AnoPublicacao { get; set; }
        public string Genero { get; set; } = string.Empty;
        public int QuantidadeExemplares { get; set; }
        public int IdAutor { get; set; }

        public AutorResumoDto Autor { get; set; } = null!;
    }
}
