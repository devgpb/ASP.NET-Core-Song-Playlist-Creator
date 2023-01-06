using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicPlaylist.Data;
using MusicPlaylist.Models;


namespace MusicPlaylist.Controllers 
{
    public class MoodsController : Controller
    {
                public  AppDbContext _db { get; }
        public MoodsController(AppDbContext db)
        {
            this._db = db;
        }

        public IActionResult Index()
        {   
            return View();
        }

        [HttpPost]
        public IActionResult Index(Mood mood)
        {   
            if(ModelState.IsValid){
                try
                {
                    this._db.Moods.Add(mood);
                    this._db.SaveChanges();
                    
                }
                catch (System.Exception ex)
                {
                    return View(mood);
                }
            }
            return RedirectToAction("Index");
        }

    }
}