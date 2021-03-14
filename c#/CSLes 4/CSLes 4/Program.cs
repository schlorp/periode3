using System;

namespace CSLes_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal = 10;
            int[] getallen = { 10, 20, 30, 40, 50, 60 };

            foreach (int eengetal in getallen)
            {
                Console.WriteLine(eengetal);
            }

            for(int i = 0; i < getallen.Length; i++)
            {
                Console.WriteLine(getallen[i]);
            }

        }
    }
}
