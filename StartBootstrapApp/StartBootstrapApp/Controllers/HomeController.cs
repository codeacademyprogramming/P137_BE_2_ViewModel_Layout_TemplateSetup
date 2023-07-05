using Microsoft.AspNetCore.Mvc;

namespace StartBootstrapApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
