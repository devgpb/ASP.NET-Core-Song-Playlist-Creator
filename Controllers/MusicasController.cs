
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
            ViewBag.jsfile = "musicas.js";
            IEnumerable<Musica> listaMusicas = this._db.Musicas;
            return View(listaMusicas);
        }

        [HttpPost]
        public IActionResult Index(string identifier, string filter)
        {   


            ViewBag.filter = filter;
            ViewBag.ident = identifier;
            ViewBag.jsfile = "musicas.js";

            string identString = $"%{identifier}%";

            IEnumerable<Musica> listaMusicas = this._db.Musicas.Where( 
                    m =>  EF.Functions.Like(m.Nome,identString)
            );
            
            switch (filter)
            {
                case "Nome":
                    listaMusicas = this._db.Musicas.Where( 
                        m =>  EF.Functions.Like(m.Nome,identString)
                    );
                    break;
                case "Autor":
                    listaMusicas = this._db.Musicas.Where( 
                        m =>  EF.Functions.Like(m.Autor,identString)
                    );
                    break;
                case "Genero":
                    listaMusicas = this._db.Musicas.Where( 
                        m =>  EF.Functions.Like(m.Genero,identString)
                    );
                    break;
                case "Humor":
                    listaMusicas = this._db.Musicas.Where( 
                        m =>  EF.Functions.Like(m.Mood,identString)
                    );
                    break;
                case "Aleatorio":
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

        [HttpGet]
        public IActionResult Add()
        {   
            return View();
        }


        [HttpPost]
        public IActionResult Add(Musica musica)
        {   
            if (ModelState.IsValid)
           {    
                // Genero gender = new Genero();
                // gender.Nome = musica.Genero;


                this._db.Musicas.Add(musica);
                // var obj = this._db.Generos.Find(gender.Nome);

                // if(obj == null ){
                //     this._db.Generos.Add(gender);
                // }

                
                this._db.SaveChanges();
                return RedirectToAction("Index");
           }
            return View(musica);
        }


        [HttpGet]
        public IActionResult Delete(int? id)
        {   
            if (id != null && id > 0)
           {
                var obj = this._db.Musicas.Find(id);
                if(obj != null ){
                    this._db.Musicas.Remove(obj);
                    this._db.SaveChanges();
                    return RedirectToAction("Index");
                }
                
           }
            return View("Index");
        }

        [HttpGet]
        public IActionResult Update(int id = 0)
        {   
            if(id > 0){
                var obj = this._db.Musicas.Find(id);
                if(obj != null ){                                                       
                    return View(obj);
                }
                return RedirectToAction("Index");
            }

            return View("Index");
        }

        [HttpPost]
        public IActionResult Update(Musica obj)
        {   
            if (ModelState.IsValid)
           {
                this._db.Musicas.Update(obj);
                this._db.SaveChanges();
                return RedirectToAction("Index");
           }
            return View("Index");
        }
    }
}