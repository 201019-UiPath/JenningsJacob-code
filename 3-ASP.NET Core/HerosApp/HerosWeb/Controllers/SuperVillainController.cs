using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HerosDB;
using Microsoft.AspNetCore.Mvc;
using HerosDB.Models;

namespace HerosWeb.Controllers
{
    public class SuperVillainController : Controller
    {
        private readonly IVillainRepo _repo;
        public SuperVillainController(IVillainRepo repo)
        {
            _repo = repo;
        }
        public IActionResult GetAllVillains()
        {
            var viliains = _repo.GetAllVillains();
            return View(viliains);
        }
        public IActionResult GetVillainByName(string name)
        {
            var villain = _repo.GetVillainByName(name);
            return View(villain);
        }
    }
}
