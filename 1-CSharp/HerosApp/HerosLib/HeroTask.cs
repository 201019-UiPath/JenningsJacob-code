using System;
using System.IO;
using System.Threading.Tasks;

namespace HerosLib
{
    public delegate void HeroDel();
    public class HeroTask : IHeroOperations, IHeroSuperPowers
    {
        // string path = "SuperPowers.txt";
        string path = @"C:\Revature\201019-UTA0UiPath\JenningsJacob-code\1-CSharp\HerosApp\SuperPowers.txt";
        public event HeroDel workDone;
        public async void DoWork()
        {
            Console.WriteLine("Work started....");
            await Task.Run(new Action(GetPowers));
            Console.WriteLine("Saving humanity is my work");
            Console.WriteLine("Work finsihed....");
            OnWorkDone();
        }

        public void OnWorkDone(){
            // workDone?.Invoke();
            if(workDone != null)
                workDone(); // raising the event
        }

        public void GetPowers()
        {
            Console.WriteLine("Getting Powers");
            System.Threading.Thread.Sleep(6000);
            string superPower = File.ReadAllText(path);
            Console.WriteLine($"Power obtained: {superPower}");
        }

        public void ManageLife()
        {
            Console.WriteLine("I have a cranky partner to manage");
        }
    }
}