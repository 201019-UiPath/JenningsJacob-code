using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace HerosWeb.Controllers
{
    public class SuperHeroController : Controller
    {
        public String Index()
        {
            return "Welcome to Super Hero World";
        }
    }
}
