using System;
using HerosLib;

namespace HerosUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region default constructor
            // Hero obj = new Hero();
            // Console.WriteLine($"{obj.id}\t{obj.name}");
            #endregion
            #region parameterized constructor
            // Hero obj1 = new Hero(101, "Hulk");
            // Console.WriteLine($"{obj1.id}\t{obj1.name}"); // Cannot access variables if not public
            #endregion
            #region access via properties
            // Console.WriteLine(obj1.Id);                 // Read property value
            // obj1.Id=202;
            // Console.WriteLine($"New ID = {obj1.Id}");   // Write into property
            #endregion
            #region accessing 1D arrays
            Hero obj = new Hero();
            // Console.Write("Please enter your hero's id: ");
            // obj.Id = Int32.Parse(Console.ReadLine());
            // Console.Write("Please enter your hero's name: ");
            // obj.Name = Console.ReadLine();
            // Console.Write("Please enter your superpower: ");
            // obj.superPowers[0] = Console.ReadLine();
            // Console.Write($"{obj.Id} {obj.Name} {obj.superPowers[0]}");

            // Jagged arrays
            obj.ja[0] = new int[2]; // first column
            obj.ja[1] = new int[3]; // second column
            obj.ja[2] = new int[1]; // third column

            obj.ja[0][0] = 10;
            obj.ja[1][2] = 20;
            // Console.WriteLine(obj.ja.Length);

            foreach (var row in obj.ja)
            {
                for(int i = 0; i < row.Length; i++)
                    Console.Write($"{row[i]}\t");
                Console.WriteLine();
            }


            #endregion
        }
    }
}
