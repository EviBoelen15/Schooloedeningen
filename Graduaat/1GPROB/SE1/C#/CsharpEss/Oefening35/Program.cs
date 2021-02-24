using System;

namespace Oefening35
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 3;
            int som = 0;
            int[] arrayGetallen = new int[max];

            Console.WriteLine($"==== SOM BEPALE VAN {max} GETALLEN");

            for(int i = 0; i < max; i++)
            {
                Console.Write($"Geef getal {i + 1}/{3}  :  ");
                arrayGetallen[i] = Convert.ToInt32(Console.ReadLine());
                som += arrayGetallen[i];
            }

            Console.WriteLine($"De som is {som}");
            Console.ReadLine();
        }
    }
}
