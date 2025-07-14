using Microsoft.AspNetCore.Mvc;

namespace AlabasterBoxWebsite.Controllers
{
    public class UpcomingEventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
