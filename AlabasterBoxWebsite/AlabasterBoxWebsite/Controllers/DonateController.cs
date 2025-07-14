using Microsoft.AspNetCore.Mvc;

namespace AlabasterBoxWebsite.Controllers
{
    public class DonateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
