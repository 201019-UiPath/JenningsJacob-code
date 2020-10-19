using System;   // Predefined namespace
                // Way to distinguish classes

namespace helloWorld    // user defined namespace
{
    class Program       
    {
        // execution starts here
                        // Commandline arguments
                        // vvv
        static void Main(string[] args) // static means dont have to call main method explicitly
        {
            Console.WriteLine("Hello World! " + DateTime.Now);
            string name;
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine(); // takes user's input in string form

            Console.WriteLine("Welcome " + name); // String concatenation: memory intensive
            Console.WriteLine($"Welcome {name}"); // String interpolation 
        }
    }
}