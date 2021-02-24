using System;

namespace Oefening39
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayGetallen = new int[3, 5];

            Console.WriteLine("==== 2-Dimentionale tabel ====");
            Console.WriteLine("Geef 5 getallen voor het upvullen van de 2de rij");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Geef getal {i + 1}:   ");
                arrayGetallen[1, i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadLine();

            vulEersteRij(arrayGetallen);
            VulDerdeRij(arrayGetallen);

            ToonArray(arrayGetallen);

            static void vulEersteRij(int[,] array)
            {
                Random rnd;
                int randomGetal;
                for (int i = 0; i < 5; i++)
                {
                    rnd = new Random();
                    randomGetal = rnd.Next(0, 11);
                    array[0, i] = randomGetal;
                }
            }
            static void VulDerdeRij(int[,] array)
            {
                int getal1, getal2;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        getal1 = array[0, i];
                        getal2 = array[1, i];
                        array[2, i] = getal1 + getal2;
                    }
                }
            }
            static void ToonArray(int[,] array)
            {
                string uitvoer = "";
                for (int i = 0; i < 3; i++)
                {
                    uitvoer += $"Rij {i + 1} ===> ";
                    for (int j = 0; j < 5; j++)
                    {
                        uitvoer += $"{array[i, j]}    ";
                    }
                    uitvoer += "\n";                
                }
                Console.WriteLine(uitvoer);
                Console.ReadLine();
            }
        }

        
    }
}
