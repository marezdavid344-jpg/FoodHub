using FoodHub.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodHub.Controllers
{
    public class RestaurantsController : Controller
    {
        public readonly List<Restuarnt> restaurants = new List<Restuarnt>()
        {
            new Restuarnt(){ID=1, Name="A1",Cuisine="B5",DeliveryFee=25,DeliveryMinutes=20,Rating=3.5,IsOpen=true},
            new Restuarnt(){ID=1, Name="A2",Cuisine="B6",DeliveryFee=26,DeliveryMinutes=21,Rating=2.5,IsOpen=true},
            new Restuarnt(){ID=1, Name="A3",Cuisine="B7",DeliveryFee=27,DeliveryMinutes=22,Rating=4.5,IsOpen=false},
            new Restuarnt(){ID=1, Name="A4",Cuisine="B8",DeliveryFee=28,DeliveryMinutes=23,Rating=5,IsOpen=true}
        };
        public IActionResult Index()
        {
            var Restaurants = restaurants.OrderByDescending(x => x.Rating).ToList();
            return View(Restaurants);
        }
    }
}
