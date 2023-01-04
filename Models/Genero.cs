using System.ComponentModel.DataAnnotations;

namespace MusicPlaylist.Models
{
    public class Genero
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string Nome { get; set; }
         
    }
}