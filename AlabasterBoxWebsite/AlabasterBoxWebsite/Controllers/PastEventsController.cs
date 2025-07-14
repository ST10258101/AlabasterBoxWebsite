using Microsoft.AspNetCore.Mvc;

namespace AlabasterBoxWebsite.Controllers
{
    public class PastEventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
