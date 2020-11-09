using HerosDB.Models;
using HerosDB;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace HerosLib
{
    public class HeroService : IHeroService
    {
        private ISuperHeroRepo repo;

        public HeroService(ISuperHeroRepo repo)
        {
            this.repo = repo;
        }
        public void AddHero(SuperHero newHero)
        {
            //Add some business logic here
            repo.AddAHeroAsync(newHero);
        }
        public List<SuperHero> GetAllHeroes()
        {
            List<SuperHero> getHerosTask = repo.GetAllHeroesAsync();
            return getHerosTask;
        }
        public SuperHero GetHeroByName(string name)
        {
            return repo.GetHeroByName(name);
        }
    }
}