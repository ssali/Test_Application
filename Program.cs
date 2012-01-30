using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the World of Cloud");
            Console.WriteLine("What is your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.ReadLine();
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key");
            
            Console.ReadKey();
        }
    }
}
