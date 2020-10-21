using System;
using HerosLib;
using System.Text.RegularExpressions;

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
            do {
                System.Console.WriteLine("Enter Hero Name: ");
                hero.Name = Console.ReadLine();
            } while (Regex.IsMatch(hero.Name, "[0-9]"));
            
            Console.WriteLine("Enter to add a super power to your hero: ");
            hero.AddSuperPower(Console.ReadLine());
            Console.WriteLine("Hero Created!"); // use logging software to log this
            // add step that pushes this hero's detail to BL

            return hero;
        }
    }
}