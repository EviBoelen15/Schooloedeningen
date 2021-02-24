using System;

namespace CS_Oefening_035
{
    class Program
    {
        static void Main(string[] args)
        {
            const int aantalGetallen = 3;
            int[] getallen = new int[aantalGetallen];

            Console.WriteLine($"==== Som bepalen van {aantalGetallen} getallen ====\r\n\r\n");
            for (int i = 0; i < getallen.Length; i++)
            {
                Console.Write($"Geef getal {i + 1}/{aantalGetallen} : ");
                getallen[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            /*
            int som = 0;
            for (int i = 0; i < getallen.Length; i++)
            {
                som += getallen[i];
            }
            */

            int som = 0;
            foreach (int getal in getallen)
                som += getal;


            Console.WriteLine($"\r\nDe som is {som}");
            Console.ReadLine();
        }
    }
}
