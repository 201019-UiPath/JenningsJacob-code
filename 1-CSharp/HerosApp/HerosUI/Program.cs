using System;
using HerosLib;

namespace HerosUI
{
    class Program:Hero
    {
        static void Main(string[] args)
        {
            #region default constructor
            Hero obj = new Hero();
            // Console.WriteLine($"{obj.id}\t{obj.name}");
            #endregion
            #region parameterized constructor
            Hero obj1 = new Hero(101, "Hulk");
            // Console.WriteLine($"{obj1.id}\t{obj1.name}"); // Cannot access variables if not public
            #endregion
            #region access via properties
            Console.WriteLine(obj1.Id);                 // Read property value
            obj1.Id=202;
            Console.WriteLine($"New ID = {obj1.Id}");   // Write into property
            #endregion
        }
    }
}
