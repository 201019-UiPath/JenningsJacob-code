using System;
using HerosLib;

namespace HerosUI.Menus
{
    /// <summary>
    /// The Wwelcome menu
    /// </summary>
    public class MainMenu:IMenu
    {
        public void Start(){
            do {
                Console.WriteLine("Welcome friend! What would you like to do today?");
                //Options
                Console.WriteLine("[0] Create a hero");
            } while(!System.Console.ReadLine().Equals("0"));
            Hero newHero = GetHeroDetails();
            Console.WriteLine($"Hero {newHero.Name} was created with a superpower of {Hero.superPowers.Pop()}");
        }

        public Hero GetHeroDetails(){
            Hero hero = new Hero();
            System.Console.WriteLine("Enter Hero Name: ");
            hero.Name = Console.ReadLine();
            Console.WriteLine("Enter to add a super power to your hero: ");
            hero.AddSuperPower(Console.ReadLine());
            Console.WriteLine("Hero Created!");

            return hero;
        }
    }
}