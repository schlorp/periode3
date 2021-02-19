using System;
using System.Threading;

namespace les2CS
{
    class Program
    {
        static void Main(string[] args)
        {
            World();
            string MyName = Name();
            Console.WriteLine("your name is " + MyName);
            Date1();
        }
        static void World()
        {
            string world = "Hello World!";

            Console.WriteLine(world);
        }
        static void Date1()
        {
            int i = 1;
            while (i == 1)
            {
                DateTime date = DateTime.Now;
                Console.WriteLine(date);
                Thread.Sleep(1000);

            }
        }
        static string Name()
        {
            Console.WriteLine("wat is je naam: ");
            string antwoord = Console.ReadLine();
            return antwoord;
        }
    }
}
