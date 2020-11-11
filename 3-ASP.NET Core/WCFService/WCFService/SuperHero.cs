using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCFService
{
    [DataContract]
    public class SuperHero
    {
        public int Id { get; set; }
        [DataMember]
        public string RealName { get; set; }
        [DataMember]
        public string Alias { get; set; }
        [DataMember]
        public string Hideout { get; set; }

        public IEnumerable<SuperHero> AllHeroes()
        {
            List<SuperHero> superHeroes = new List<SuperHero>()
            {
                {new SuperHero(){Id = 1, RealName = "Peter Parker", Alias = "Spiderman", Hideout = "Basement"}},
                {new SuperHero(){Id = 2, RealName = "Thor Odison", Alias = "Thor", Hideout = "Asgard"}}
            };

            return superHeroes;
        }
    }
}