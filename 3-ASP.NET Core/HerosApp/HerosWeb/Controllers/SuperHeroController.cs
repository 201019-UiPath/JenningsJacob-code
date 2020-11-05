using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using HerosLib;
using HerosDB;
using HerosDB.Models;

namespace HerosWeb.Controllers
{
    public class SuperHeroController : Controller
    {
        private readonly ISuperHeroRepo _repo;
        
        public SuperHeroController(ISuperHeroRepo repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> GetHeros()
        {
            var superHero = await _repo.GetAllHeroesAsync();
            return View(superHero);
        }
        public IActionResult GetHerosByName(string name)
        {
            var superHero = _repo.GetHeroByName(name);
            return View(superHero);
        }
        public ViewResult AddHero()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddHero(SuperHero superHero)
        {
            SuperHero hero = new SuperHero();
            if (ModelState.IsValid)
            {
                hero.Alias = superHero.Alias;
                hero.RealName = superHero.RealName;
                hero.HideOut = superHero.HideOut;
                _repo.AddAHeroAsync(hero);
                return Redirect("GetHeros");
            }
            else
                return View();
        }
        public ViewResult UpdateHero(int id)
        {
            var hero = _repo.GetHeroById(id);

            return View(hero);
        }
        public IActionResult UpdateHero2(SuperHero superHero)
        {
            if (ModelState.IsValid)
            {
                
                _repo.UpdateHero(superHero);
                return Redirect("GetHeros");
            }
            else
                return View();

        }
    }
}
