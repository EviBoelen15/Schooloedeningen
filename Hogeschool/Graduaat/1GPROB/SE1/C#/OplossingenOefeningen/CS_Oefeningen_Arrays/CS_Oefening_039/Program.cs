using System;

namespace CS_Oefening_039
{
    class Program
    {
        static void Main(string[] args)
        {
            const int rijen = 3;
            const int kolommen = 5;
            
            int[,] tabel = new int[rijen, kolommen];
            Random rnd = new Random();
            
            Console.WriteLine("==== 2-dimensionale tabel ====\r\n\r\n");
            Console.WriteLine($"Geef {kolommen} getallen voor het opvullen van de tweede rij!");

            // Rij 1 (rij met index 0)
            // GetLength(0) is aantal rijen, GetLength(1) is aantal kolommen
            for (int i = 0; i < tabel.GetLength(1); i++)
                tabel[0, i] = rnd.Next(11); // willekeurig getal van 0 tot en met 10
            
            // Rij 2 (rij met index 1)
            for (int i = 0; i < tabel.GetLength(1); i++)
            {
                Console.Write($"Getal {i + 1}: ");
                tabel[1, i] = int.Parse(Console.ReadLine());
            }

            // Rij 3 (rij met index 2)
            Console.WriteLine();
            for (int i = 0; i < tabel.GetLength(1); i++)
                tabel[2, i] = tabel[0, i] + tabel[1, i];

            // Afdrukken van de 2-dimensionale array
            // Loop over de rijen
            for (int i = 0; i < tabel.GetLength(0); i++)
            {
                Console.Write($"Rij {i + 1} ==>");
                // Loop over de kolommen
                for (int j = 0; j < tabel.GetLength(1); j++)
                {
                    Console.Write($"{tabel[i, j], 6}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\r\nDruk op een toets om af te sluiten.");
            Console.ReadLine();
        }
    }
}
