
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MusicPlaylist.Models
{
    public class Musica
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="Nome obrigatório")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage="Autor obrigatório")]
        public string Autor { get; set; }
        
        [ForeignKey("Mood")] [Required(ErrorMessage="Considere Criar um Humor")]
        public string MoodNome { get; set; }
        public Mood? mood { get; set; }


        
        [ForeignKey("Genero")][Required(ErrorMessage="Considere Criar um genero")]
        public string GeneroNome { get; set; }
        public Genero? Genero { get; set; }

    }
}