namespace Biblioteca.API.DTOs
{
    public class LivroCadastroDto
    {
        public string Titulo { get; set; } = string.Empty;
        public int AnoPublicacao { get; set; }
        public string Genero { get; set; } = string.Empty;
        public int QuantidadeExemplares { get; set; }
        public int IdAutor { get; set; }
    }
}