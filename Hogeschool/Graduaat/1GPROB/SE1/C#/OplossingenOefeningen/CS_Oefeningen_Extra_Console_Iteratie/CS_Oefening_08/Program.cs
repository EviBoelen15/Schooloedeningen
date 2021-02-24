using System;

namespace CS_Oefening_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoeveel keren wil je lotto genereren? ");
            string consoleRead = Console.ReadLine();
            int aantal;
            bool isGelukt = int.TryParse(consoleRead, out aantal);
            if (!isGelukt || aantal <= 0)
            {
                Console.WriteLine("Geef een getal in groter dan 0!");
                return;
            }
            Console.WriteLine("\r\n");

            Random rnd = new Random();
            const int aantalLottoGetallen = 6;
            int[] getallen = new int[aantalLottoGetallen];
            for (int i = 0; i < aantal; i++)
            {
                Console.WriteLine("De 6 LOTTO-getallen zijn:");
                for (int j = 0; j < aantalLottoGetallen; j++)
                {
                    getallen[j] = rnd.Next(1, 46);
                    for(int k = 0; k < j; k++)
                    {
                        if (getallen[k] == getallen[j])
                        {
                            getallen[j] = rnd.Next(1, 46);
                        }
                    }
                    Console.WriteLine($"Getal {j + 1}: {getallen[j]}");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
