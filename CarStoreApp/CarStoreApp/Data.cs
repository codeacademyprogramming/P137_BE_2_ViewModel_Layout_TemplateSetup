using CarStoreApp.Models;

namespace CarStoreApp
{
    public static class Data
    {
        public static List<Brand> Brands = new List<Brand> { new Brand { Id = 1, Name = "Mercedes" }, new Brand { Id = 2, Name = "Ford" }, new Brand { Id = 3, Name = "Lada" } };
        public static List<Car> Cars = new List<Car>
            {
                new Car{ Id = 1,Brand="Mercedes",Model="E200",Year=2008},
                new Car{ Id = 2,Brand="Mercedes",Model="E300",Year=2010},
                new Car{ Id = 3,Brand="Lada",Model="07",Year=2020},
                new Car{ Id = 4,Brand="Mercedes",Model="S500",Year=2018},
                new Car{ Id = 5,Brand="Mercedes",Model="S320",Year=2003},
            };
    }
}
