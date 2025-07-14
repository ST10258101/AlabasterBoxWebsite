using Microsoft.AspNetCore.Mvc;

namespace AlabasterBoxWebsite.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
