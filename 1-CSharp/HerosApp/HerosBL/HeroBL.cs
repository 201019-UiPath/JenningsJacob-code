using System.Collections.Generic;
using System.Threading.Tasks;
using HerosLib;
using HerosDB;


namespace HerosBL
{
    public class HeroBL
    {
        IRepository repo = new FileRepo();
        public void AddHero(Hero newHero){
            // You can add the business logic to check stuff
            // Ex: check if hero name is unique
            repo.AddHeroAsync(newHero);
        }

        public List<Hero> GetAllHeros() {
            Task<List<Hero>> getHeros = repo.GetAllHerosAsync();
            return getHeros.Result;
        }
    }
}
