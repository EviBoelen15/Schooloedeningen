using System;

namespace CS_Oefening_03
{
    class Program
    {
        static void Main(string[] args)
        {
            const int aantalSommen = 5;
            const int aantalGetallen = aantalSommen * 2;
            Console.WriteLine($"Maak de som van {aantalGetallen} ingevoerde getallen:\r\n\r\n");

            // Arrays: zie hoofdstuk 10
            int[] sommen = new int[aantalSommen];
            for (int i = 0, j = 0; i < aantalGetallen; i+=2, j++)
            {
                Console.Write($"Geef getal {i + 1}: ");
                sommen[j] = int.Parse(Console.ReadLine());

                Console.Write($"Geef getal {i + 2}: ");
                sommen[j] += int.Parse(Console.ReadLine());

                Console.WriteLine();
            }

            Console.WriteLine("\r\n=== Sommen ===");
            for (int i = 0; i < aantalSommen; i++)
            {
                Console.WriteLine($"Som {i + 1}: {sommen[i]}");
            }
            Console.WriteLine("\r\nDruk op een toets om af te sluiten....");
            Console.ReadLine();

        }
    }
}
