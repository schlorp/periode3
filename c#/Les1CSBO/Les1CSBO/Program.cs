using System;
using System.Threading;

namespace Les1CSBO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("H");
            Thread.Sleep(1000);
            Console.Write("e");
            Thread.Sleep(1000);
            Console.Write("l");
            Thread.Sleep(1000);
            Console.Write("l");
            Thread.Sleep(1000);
            Console.Write("o");
            Thread.Sleep(1000);
            Console.Write(" ");
            Thread.Sleep(1000);
            Console.Write("Y");
            Thread.Sleep(1000);
            Console.Write("o");
            Thread.Sleep(1000);
            Console.Write("u");
            Thread.Sleep(1000);
            Console.Write("!");
            Thread.Sleep(1000);

            World();
            string MyName = Name();
            Console.WriteLine("your name is " + MyName);
            Date1();

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
}
