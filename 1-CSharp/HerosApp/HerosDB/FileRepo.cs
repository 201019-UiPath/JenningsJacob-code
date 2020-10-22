using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using HerosLib;

namespace HerosDB
{
    /// <summary>
    /// Repository using files
    /// </summary>
    public class FileRepo : IRepository
    {
        string filepath = @"HerosDB/HerosData/Heros.txt";
        /// <summary>
        /// Adds hero to file
        /// </summary>
        /// <param name="hero"></param>
        public async void AddHeroAsync(Hero hero)
        {
            using (FileStream fs = File.Create(filepath))
            {   
                // TODO: serilalize list of heros, deserialize the list and add the new hero 
                await JsonSerializer.SerializeAsync(fs, hero);
                
                System.Console.WriteLine("Hero is being written to file");
            }
            // File.AppendAllText(filepath, hero.Name);
        }
        /// <summary>
        /// Gets all heros from file
        /// </summary>
        /// <returns></returns>
        public async Task<List<Hero>> GetAllHerosAsync()
        {
            List<Hero> heros = new List<Hero>();
            using (FileStream fs = File.OpenRead(filepath))
            {
                heros.Add(await JsonSerializer.DeserializeAsync<Hero>(fs));
            }
            return heros;
        }
    }
}