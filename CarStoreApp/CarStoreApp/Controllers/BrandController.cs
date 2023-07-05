using CarStoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarStoreApp.Controllers
{
    public class BrandController : Controller
    {
        public IActionResult Index()
        {
            return View(Data.Brands);
        }
    }
}
