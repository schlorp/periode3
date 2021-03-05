using System;
using System.Threading;

namespace les2CS
{
    class Program
    {
        static void Main(string[] args)
        {   //Variables en Datatypes//
            int N1 = 10;
            float F1 = N1;
            bool B1 = true;

            int N2 = 1;
            float F2 = N2;
            bool B2 = Convert.ToBoolean(F2);

            Console.WriteLine(N1);
            Console.WriteLine(F1);
            Console.WriteLine(B1);

            Console.WriteLine(N2);
            Console.WriteLine(F2);
            Console.WriteLine(B2);
            //var -> DataTypes/////
            int a = 1;
            float b = 0.5f;
            double c = 1.32142412441d;
            string d = "Word";
            char e = 'c';
            bool f = true;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            //arrays//////////////
            int[] array1 = new int[] { 10, 20, 30, 40, 50, 60 };
            foreach (var item in array1)
            {
                Console.WriteLine("dit is een array item: " + item);
            }
            //loops//////////////
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            //linear search//////
            string[] names = new string[]
            {
                "Joe",
                "Rick",
                "Sam",
                "Giovanni",
                "Ramses",
                "Laura",
                "Laurens",
                "Lydia",
                "Eric",
                "Rose"
            };

            string nameToFind = "Laurens";

            for(int i = 0; i >= 0; i++)
            {
                if(names == nameToFind)
                {
                    Console.WriteLine(nameToFind);
                }
            }

            
        }
    }
}
