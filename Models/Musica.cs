
using System.ComponentModel.DataAnnotations;

namespace MusicPlaylist.Models
{
    public class Musica
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }
        
        [Required]
        public string Autor { get; set; }
        
        [Required]
        public string Mood { get; set; }
        
        [Required]
        public string Genero { get; set; }
        
    }
}