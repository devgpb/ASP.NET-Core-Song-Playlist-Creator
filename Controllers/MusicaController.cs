using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicPlaylist.Data;
using MusicPlaylist.Models;

namespace MusicPlaylist.Controllers
{
    public class MusicaController : Controller
    {
        public  AppDbContext _db { get; }
        public MusicaController(AppDbContext db)
        {
            this._db = db;
        }

    }
}