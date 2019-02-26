using Microsoft.AspNetCore.Mvc;
using Idafood.ViewModels;
using Idafood.Models;
using Idafood.Services;

namespace Idafood.Controllers
{
    public class HomeController:Controller
    {

        private IRestaurantData _restaurantData;
        private IGreeter _greeter;

        public HomeController(IRestaurantData restaurantData, IGreeter Greeter)
        {
            _restaurantData = restaurantData;
            _greeter = Greeter;
        }


        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
              model.Restaurants=  _restaurantData.GetAll();
            model.CurrentMessage = _greeter.GetMessageOfTheDay();
            return View(model);
        }
    }
}
