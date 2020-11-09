using System.Collections.Generic;

namespace ConsomeHerosApp.Models
{
    public class SuperVillain : SuperPerson
    {
        public List<SuperHero> Nemesis { get; set; }
    }
}