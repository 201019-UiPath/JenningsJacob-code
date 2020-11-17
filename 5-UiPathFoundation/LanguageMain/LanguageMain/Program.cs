using System;

namespace LanguageMain
{
    class Program
    {
        static void Main(string[] args)
        {
            CSharpLib.TestDemo testCSharp = new CSharpLib.TestDemo();
            testCSharp.GetFullName("Jacob", "Aaron", "Jennings");
            var results = testCSharp.LoadFile();
            foreach (var item in results)
                Console.WriteLine(item);
            Console.WriteLine("\n*******************************************\n");

            VBLib.TestDemo testVB = new VBLib.TestDemo(); 
            testVB.GetFullName("Mr.", null, "Sleepy");
            var vbresults = testVB.LoadFile();
            foreach (var item in vbresults)
                Console.WriteLine(item);
        }
    }
}
