using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicPlaylist.Data;
using MusicPlaylist.Models;

namespace MusicPlaylist.Controllers 
{
    public class GenerosController : Controller
    {
        public  AppDbContext _db { get; }
        public GenerosController(AppDbContext db)
        {
            this._db = db;
        }

        public IActionResult Index()
        {   
            return View();
        }

        [HttpPost]
        public IActionResult Index(Genero genero)
        {   
            if(ModelState.IsValid){
                try
                {
                    this._db.Generos.Add(genero);
                    this._db.SaveChanges();
                    
                }
                catch (System.Exception ex)
                {
                    return View(genero);
                }
            }
            return RedirectToAction("Index");
        }

    }
}