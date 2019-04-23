using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Idafood.Controllers
{
    //[Route ("[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "1+555+555+5555";
        }

        public string Address()
        {
            return "USA";
        }
    }
}
