using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MusicPlaylist.Models;

namespace MusicPlaylist.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
      
        return  RedirectToRoute(new { controller = "Musicas", action = "Index"});
    }

    public IActionResult Privacy()
    {
        return  RedirectToRoute(new { controller = "Musicas", action = "Index"});
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
