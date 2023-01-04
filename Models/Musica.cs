
using System.ComponentModel.DataAnnotations;

namespace MusicPlaylist.Models
{
    public class Musica
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Autor { get; set; }
        
        public string Mood { get; set; }
        
        public string Genero { get; set; }
        
    }
}