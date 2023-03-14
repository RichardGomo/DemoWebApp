using Microsoft.AspNetCore.Mvc;

namespace DemoWebApp.Controllers
{
    public class ClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
