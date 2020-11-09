using ConsomeHerosApp.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace ConsomeHerosApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAllHeroes();
        }

        public static void GetAllHeroes()
        {
            string url = "https://localhost:44380/superhero/get";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                var response = client.GetAsync("");
                response.Wait();

                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTeask = result.Content.ReadAsAsync<SuperHero[]>();
                    readTeask.Wait();

                    var superHeroes = readTeask.Result;
                    foreach(var hero in superHeroes)
                    {
                        Console.WriteLine($"{hero.Id}:\t{hero.Alias}");
                    }
                }
            }
        }
    }
}
