using AlabasterBoxWebsite.Models;
using AlabasterBoxWebsite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Diagnostics;


namespace AlabasterBoxWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // <— define these in code (or better, inject via IConfiguration)
        private const string YouTubeApiKey = "AIzaSyBHLkEHH9kmnS-B-BFiZaBUjZNugn4dHiM";
        private const string YouTubeChannelId = "UCBdi3O3UDeD5gleDqi5gx3g";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // <— only one Index method, async
        public async Task<IActionResult> Index()
        {
            var yt = new YouTubeHelper(YouTubeApiKey, YouTubeChannelId);
            string? videoId = await yt.GetLatestOrLiveAsync();
            ViewBag.YouTubeVideoId = videoId;
            return View();
        }

        public IActionResult Privacy()
            => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
            => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
