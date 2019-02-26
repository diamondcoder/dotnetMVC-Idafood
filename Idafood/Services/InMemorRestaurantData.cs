using Idafood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Idafood.Services
{

    public class InMemorRestaurantData : IRestaurantData
    {
        public InMemorRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant {id=1, name= "Scott's Pizza"},
                new Restaurant { id = 2, name = "FOsu's pancakes" },
                new Restaurant { id = 3, name = "Anna's rice" }
            };

        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.name); 
        }

        List<Restaurant> _restaurants;
    }
        

        
       

   
}
