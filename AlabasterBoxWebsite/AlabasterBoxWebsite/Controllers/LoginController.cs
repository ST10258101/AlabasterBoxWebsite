using Microsoft.AspNetCore.Mvc;

namespace AlabasterBoxWebsite.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
