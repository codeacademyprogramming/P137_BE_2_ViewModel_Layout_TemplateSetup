using CarStoreApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarStoreApp.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            var brands = Data.Brands;
            var cars = Data.Cars;

            HomeViewModel vm = new HomeViewModel
            {
                Brands = brands,
                Cars = cars
            };

            return View(vm);
        }

        public IActionResult About()
        {
            
            return View();
        }
    }
}
