using System.ComponentModel.DataAnnotations;

namespace MusicPlaylist.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Senha { get; set; }
        
        
    }
}