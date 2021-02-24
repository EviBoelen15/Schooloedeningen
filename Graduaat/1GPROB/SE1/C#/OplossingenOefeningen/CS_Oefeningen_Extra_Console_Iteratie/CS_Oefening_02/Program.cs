using System;

namespace CS_Oefening_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1 = 0;
            int getal2 = 1;
            Console.Write($"{getal1} {getal2} ");
            const int aantalGetallen = 25 - 2;
            for (int i = 0; i < aantalGetallen; i++)
            {
                int temp;
                temp = getal1;
                getal1 = getal2;
                getal2 = temp + getal2;
                Console.Write($"{getal2} ");
            }
            Console.WriteLine("\r\nDruk op een toets om af te sluiten....");
            Console.ReadLine();
        }
    }
}
