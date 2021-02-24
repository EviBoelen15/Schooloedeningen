using System;
using System.Collections;

namespace CS_Oefening_08_Sneller
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dit is geen leerstof, maar hier gebruiken we een BitArray om
            // bij te houden welke getallen gekozen zijn.
            // We vermijden zo een geneste loop en maken het genereren nu lineair ipv kwadratisch.
            // Dit is eigenlijk een bucket sort algoritme, want de getallen zijn nadien gesorteerd
            const int minLottoGetal = 1;
            const int maxLottoGetal = 45 + 1;

            Console.Write("Hoeveel keren wil je lotto genereren? ");
            string consoleRead = Console.ReadLine();

            int aantalTrekkingen;
            {
                bool isGelukt = int.TryParse(consoleRead, out aantalTrekkingen);
                if (!isGelukt || aantalTrekkingen <= 0)
                {
                    Console.WriteLine("Geef een getal in groter dan 0!");
                    return;
                }
                Console.WriteLine("\r\n");
            }

            Random rnd = new Random();
            const int aantalLottoGetallen = 6;
            BitArray isGekozen = new BitArray(maxLottoGetal, false);
            for (int i = 0; i < aantalTrekkingen; i++)
            {
                // Genereer een reeks unieke LOTTO-getallen
                int j = 0;
                do
                {
                    int index = rnd.Next(minLottoGetal, maxLottoGetal);
                    if (isGekozen[index])
                        continue;
                    isGekozen[index] = true;
                    j++;
                } while (j < aantalLottoGetallen);

                // Toon resultaat en zet bitArray terug volledig op false
                Console.WriteLine("De 6 LOTTO-getallen zijn:");
                for (int k = minLottoGetal, getal = 1; k < maxLottoGetal; k++)
                    if (isGekozen[k])
                        Console.WriteLine($"Getal {getal++}: {k}");
                Console.WriteLine();
                isGekozen.SetAll(false);
            }
            Console.ReadLine();
        }
    }
}
