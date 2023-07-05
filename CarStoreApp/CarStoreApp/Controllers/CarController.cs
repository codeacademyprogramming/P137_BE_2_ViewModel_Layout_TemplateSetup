using CarStoreApp.Models;
using CarStoreApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarStoreApp.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.Cars = cars;

            return View(Data.Cars);
        }

        public IActionResult Detail(int id)
        {
            var car = Data.Cars.Find(x=>x.Id == id);

            if (car == null)
                return View("error");

            CarDetailViewModel vm = new CarDetailViewModel
            {
                Brands = Data.Brands,
                Car = car
            };
           
            return View(vm);
        }


    }
}
