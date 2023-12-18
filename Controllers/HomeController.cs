using Microsoft.AspNetCore.Mvc;

namespace MobiAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
