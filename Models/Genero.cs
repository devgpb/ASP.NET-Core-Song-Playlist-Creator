using System.ComponentModel.DataAnnotations;

namespace MusicPlaylist.Models
{
    public class Genero
    {
        [Key][Required(ErrorMessage="Considere Criar um genero")]
        public string Nome { get; set; }
        
       public List<Musica>? Generos { get; set; }
    }
}