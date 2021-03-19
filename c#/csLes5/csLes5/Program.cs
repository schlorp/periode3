using System;

namespace csLes5
{
    class Program
    {
        static void Main(string[] args)
        {
            eenfunctie();


           void eenfunctie()
           { 
                if (true)
                {
                    Console.WriteLine("wank");
                }

                {
                    int scope = 420;
                    for (int i = 0; i <= 10; i++)
                    {
                        Console.WriteLine(scope);

                        if(i == 10)
                        {
                            Console.WriteLine("dit is de if: " s+ scope);
                        }
                    }
                }
           }

        }
    }
}
