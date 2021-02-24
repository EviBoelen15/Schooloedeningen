using System;

namespace CS_Oefening_06
{
    class Program
    {
        static void Main(string[] args)
        {
            const int stapGrootte = 10;
            int aantal;
            bool isGelukt;
            do
            {
                Console.Write("Hoe vaak moet je optellen met 10 tot deze eindsom? ");
                isGelukt = int.TryParse(Console.ReadLine(), out aantal);
            } while (!isGelukt || aantal <= 0 || aantal % stapGrootte != 0);

            Console.WriteLine();
            int som = 0;
            int i = 0;
            Console.WriteLine(0);
            while (som != aantal)
            {
                som += stapGrootte;
                i++;
                Console.WriteLine(som);
            }
            Console.WriteLine($"\r\nAantal keren opgeteld: {i}");
            Console.WriteLine("\r\nDruk op Enter...");
            Console.ReadLine();
        }
    }
}
