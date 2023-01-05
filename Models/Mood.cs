using System.ComponentModel.DataAnnotations;

namespace MusicPlaylist.Models
{
    public class Mood
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Nome { get; set; }
        
        public string Desc { get; set; }
         
    }
}