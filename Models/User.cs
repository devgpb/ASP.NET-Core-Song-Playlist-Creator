using System.ComponentModel.DataAnnotations;

namespace MusicPlaylist.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Senha { get; set; }
        
        
    }
}