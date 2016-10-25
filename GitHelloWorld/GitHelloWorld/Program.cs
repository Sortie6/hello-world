using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is just to test and show that there's a program in the repository.");
            Console.WriteLine("Now close this and gtfo already.");
            Console.WriteLine("This is a new line in here just added in this particular new branch!");
            Console.WriteLine("Now tell us your name.");
            string name = Console.ReadLine();
            Console.WriteLine("Ok, so your name is " + name + "?");
            Console.ReadKey();
        }
    }
}
