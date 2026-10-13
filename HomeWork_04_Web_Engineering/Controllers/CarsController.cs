using HomeWork_04_Web_Engineering.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork_04_Web_Engineering.Controllers
{
    public class CarsController : Controller
    {
        private static List<Car> availableCars = new List<Car>
        {
            new Car { Id = 1, Name = "Alto", PricePerDay = 3000 },
            new Car { Id = 2, Name = "Corolla", PricePerDay = 6000 },
            new Car { Id = 3, Name = "Civic", PricePerDay = 8000 }
        };
        private static List<Car> bookedCars = new List<Car>();
        [HttpGet]
        public ViewResult Index()
        {
            return View(availableCars);
        }
        [HttpPost]
        public RedirectToActionResult Book(int id)
        {
            if(availableCars.Count == 0)
                return RedirectToAction("Index");
            Car? car = null;
            foreach (Car c in availableCars) {
                if (c.Id == id)
                {
                    car = c;
                    break;
                }
            }
            if (car != null)
            {
                availableCars.Remove(car);
                bookedCars.Add(car);
                return RedirectToAction("Booked");
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ViewResult Booked()
        {
            return View(bookedCars);
        }
    }
}
