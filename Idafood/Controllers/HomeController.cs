using Microsoft.AspNetCore.Mvc;
using Idafood.Models;

namespace Idafood.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            var model = new Restaurant { id = 1, name = "Scottäs Pizza Place" };
            return View(model);
        }
    }
}
