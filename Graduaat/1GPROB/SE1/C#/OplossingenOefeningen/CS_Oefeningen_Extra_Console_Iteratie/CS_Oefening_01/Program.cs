using System;

namespace CS_Oefening_01
{
    class Program
    {
        static void Main(string[] args)
        {
            const int aantal = 5;
            Console.WriteLine($"Maak de som van {aantal} ingevoerde gehele getallen:\r\n\r\n");
            int som = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Geef getal {i}: ");
                som += int.Parse(Console.ReadLine());
                Console.WriteLine($" --> Som voorgaande getallen: {som}\r\n");
                
            }
            Console.WriteLine("Druk op een toets om af te sluiten....");
            Console.ReadLine();
        }
    }
}
