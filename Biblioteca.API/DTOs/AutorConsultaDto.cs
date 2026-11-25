
namespace Biblioteca.API.DTOs
{
    public class AutorConsultaDto
    {
        public int IdAutor { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Nacionalidade { get; set; } = string.Empty;

        public List<LivroResumoDto> Livros { get; set; } = new();
    }
}
