using System;
using HerosLib;
using HerosBL;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace HerosUI.Menus
{
    /// <summary>
    /// The Welcome menu
    /// </summary>
    public class MainMenu:IMenu
    {
        HeroBL heroBL = new HeroBL(); 
        string userInput;
        public void Start(){
            do {
                Console.WriteLine("Welcome friend! What would you like to do today?");
                //Options
                Console.WriteLine("[0] Create a hero\n[1] Get all heros");
                userInput = Console.ReadLine();
                switch(userInput) {
                    case "0":
                        Hero newHero = GetHeroDetails();
                        heroBL.AddHero(newHero);
                        Console.WriteLine($"Hero {newHero.Name} was created with a superpower of {Hero.superPowers.Pop()}");
                        break;
                    case "1":
                        List<Hero> allHeros = heroBL.GetAllHeros();
                        foreach (var hero in allHeros)
                        {
                            Console.WriteLine($"Hero {hero.Name}");
                        }
                        break;
                }
            } while(!userInput.Equals("0") || !userInput.Equals("1"));
            
        }

        public Hero GetHeroDetails(){
            Hero hero = new Hero();
            do {
                System.Console.WriteLine("Enter Hero Name: ");
                hero.Name = Console.ReadLine();
            } while (Regex.IsMatch(hero.Name, "[\\d]"));
            
            Console.WriteLine("Enter to add a super power to your hero: ");
            hero.AddSuperPower(Console.ReadLine());
            Console.WriteLine("Hero Created!"); // use logging software to log this
            // add step that pushes this hero's detail to BL

            return hero;
        }
    }
}