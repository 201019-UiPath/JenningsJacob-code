using System;
using System.IO;

namespace HerosLib
{
    public delegate void heroDel();
    public class HeroTask : IHeroOperations, IHeroSuperPowers
    {
        string path = "../SuperPowers.txt";
        public void DoWork()
        {
            Console.Write("Saving humanity is my work");
        }

        public void GetPowers()
        {
            string superPower = File.ReadAllText(path);
        }

        public void ManageLife()
        {
            Console.Write("I have a cranky partner to manage");
        }
    }
}