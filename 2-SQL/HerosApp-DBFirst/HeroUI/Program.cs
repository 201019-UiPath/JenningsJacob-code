using HerosDB.Entities;
using HerosDB;
namespace HeroUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu main = new MainMenu(new HeroContext(), new DBMapper());
            main.start();
        }

    }
}
