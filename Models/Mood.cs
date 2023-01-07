using System.ComponentModel.DataAnnotations;

namespace MusicPlaylist.Models
{
    public class Mood
    {
        
        [Required(ErrorMessage="Considere Criar um genero")][Key]
        public string Nome { get; set; }
        
        public List<Musica>? Generos { get; set; }
    }
}