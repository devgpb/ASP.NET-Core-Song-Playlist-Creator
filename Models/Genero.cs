using System.ComponentModel.DataAnnotations;

namespace MusicPlaylist.Models
{
    public class Genero
    {
        [Key][Required(ErrorMessage="Informe um Genero")]
        public string Nome { get; set; }
        
       public List<Musica>? Generos { get; set; }
    }
}