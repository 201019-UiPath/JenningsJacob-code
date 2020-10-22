using System.Collections.Generic;
using System.Threading.Tasks;
using HerosLib;

namespace HerosDB
{
    public interface IRepository
    {
        void AddHeroAsync(Hero hero);
        Task<List<Hero>> GetAllHerosAsync();
    }
}