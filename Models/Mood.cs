using System.ComponentModel.DataAnnotations;

namespace MusicPlaylist.Models
{
    public class Mood
    {
        [Key]
        public string Id { get; set; }

        public string Nome { get; set; }
        
        public string Desc { get; set; }
         
    }
}