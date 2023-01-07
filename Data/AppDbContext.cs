using Microsoft.EntityFrameworkCore;
using MusicPlaylist.Models;

namespace MusicPlaylist.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Musica> Musicas { get; set; }
        public DbSet<Mood> Moods { get; set; }
        public DbSet<Genero> Generos { get; set; }
        
    }
}