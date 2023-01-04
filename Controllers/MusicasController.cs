
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicPlaylist.Data;
using MusicPlaylist.Models;

namespace MusicPlaylist.Controllers
{
    public class MusicasController : Controller
    {
        public  AppDbContext _db { get; }
        public MusicasController(AppDbContext db)
        {
            this._db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {   
            IEnumerable<Musica> listaMusicas = this._db.Musicas;
            return View(listaMusicas);
        }

        [HttpPost]
        public IActionResult Index(string identifier, string filter)
        {   


            ViewBag.filter = filter;
            ViewBag.ident = identifier;

            string identString = $"%{identifier}%";

            IEnumerable<Musica> listaMusicas = this._db.Musicas.Where( 
                    m =>  EF.Functions.Like(m.Nome,identString)
            );
            
            switch (filter)
            {
                case "nome":
                    listaMusicas = this._db.Musicas.Where( 
                        m =>  EF.Functions.Like(m.Nome,identString)
                    );
                    break;
                case "autor":
                    listaMusicas = this._db.Musicas.Where( 
                        m =>  EF.Functions.Like(m.Autor,identString)
                    );
                    break;
                case "genero":
                    listaMusicas = this._db.Musicas.Where( 
                        m =>  EF.Functions.Like(m.Genero,identString)
                    );
                    break;
                case "humor":
                    listaMusicas = this._db.Musicas.Where( 
                        m =>  EF.Functions.Like(m.Mood,identString)
                    );
                    break;
                case "aleatorio":
                    Random rand = new Random();
                    
                    int skipper = rand.Next(0, _db.Musicas.Count());
                    listaMusicas = this._db.Musicas.OrderBy(product => Guid.NewGuid()).Skip(0)
                    .Take(20)
                    .ToList();
                    break;
                default:
                    listaMusicas = this._db.Musicas.Where( 
                             m =>  EF.Functions.Like(m.Nome,identString)
                    );
                    break;
            }
            


            return View(listaMusicas);
        }

    }
}