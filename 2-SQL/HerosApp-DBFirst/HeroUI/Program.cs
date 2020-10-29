using HerosDB.Entities;
using HerosDB;
using HerosDbWithADO;

namespace HeroUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // IMenu main = new MainMenu(new HeroContext(), new DBMapper());
            // main.start();
            Data data = new Data();
            data.GetSuperPersonDisconnected();
        }

    }
}
