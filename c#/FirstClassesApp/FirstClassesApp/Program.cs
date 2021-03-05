using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FirstClassesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.Add(1234, 123);
            int mult = calc.Multiply(12, 123);
            Console.WriteLine("mult: " + mult);
            float circle = calc.Circumference(10);
            Console.WriteLine("circ= " + circle);

            int myInt = 1;
            bool loop = true;
            int NuMijnInt = 1;

            while (loop == true)
            {
                switch (myInt)
                {
                    case 0:
                        Console.WriteLine("hallo, dit is case 0");
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("hallo, dit is de default case");
                        myInt = 0;
                        break;
                }
            }

            Console.WriteLine("case 0 of 1?: ");
            string ant = Console.ReadLine();
            Int32.TryParse(ant, out NuMijnInt);

            switch (NuMijnInt)
            {
                case 0:
                    Console.WriteLine("dit is case 0");
                    break;
                case 1:
                    Console.WriteLine("dit is case 1");
                    break;
                default:
                    Console.WriteLine("geen goed nummer ingevuld");
                    break;
            }
            Thread.Sleep(10000);
        }
    }


    class Calculator
    {
        float pi = 3.14f;

        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("a+b= " + c);
        }
        public int Multiply(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("a*b= " + c);
            return c;
        }
        public int Delen(int a, int b)
        {
            int c = a / b;
            Console.WriteLine("a / b= " + c);
            return c;
        }
        public float Circumference(float radius)
        {
            return radius * radius * pi;
        }

    }

}
