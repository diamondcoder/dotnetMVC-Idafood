using System;
using Idafood.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Idafood.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string CurrentMessage { get; set; }
    }
}
