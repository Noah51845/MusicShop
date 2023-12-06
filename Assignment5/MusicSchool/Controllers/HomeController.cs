using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicSchool.Data;
using MusicSchool.Models;
using System.Diagnostics;

namespace MusicSchool.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MusicShopContext _context;

        public HomeController(ILogger<HomeController> logger, MusicShopContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index(string selectedGenre)
        {
            // Get all genres for dropdown
            ViewData["Genres"] = new List<string> { "hip-hop", "rap", "country", "r&b", "pop", "jazz" };

            // Filter songs based on the selected genre
            var songs = string.IsNullOrEmpty(selectedGenre)
                ? _context.Music.ToList()  // Show all songs if no genre is selected
                : _context.Music.Where(s => s.Genre == selectedGenre).ToList();

            ViewData["FilteredSongs"] = songs;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}