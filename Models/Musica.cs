
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


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
        
        [ForeignKey("Genero")]
        public string GeneroNome { get; set; }
        public Genero? Genero { get; set; }

    }
}