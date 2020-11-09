using System;
using System.Collections.Generic;
using System.Text;

namespace ConsomeHerosApp.Models
{
    public class SuperHero : SuperPerson
    {
        public List<SuperVillain> Nemesis { get; set; }
    }
}
