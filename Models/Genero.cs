using System.ComponentModel.DataAnnotations;

namespace MusicPlaylist.Models
{
    public class Genero
    {
        [Key][Required]
        public string Nome { get; set; }
        
       public List<Musica> Generos { get; set; }
    }
}