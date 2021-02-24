using System;

namespace CS_Oefening_04
{
    class Program
    {
        static void Main(string[] args)
        {
            const int aantalSommen = 5;
            Console.WriteLine($"Maak de sommen van de volgende {aantalSommen} optellingen:\r\n\r\n");
            Random rnd = new Random();

            // Arrays: zie hoofdstuk 10
            int[] sommen = new int[aantalSommen];
            for (int i = 0; i < 5; i++)
            {
                int links = rnd.Next(1, 21);
                int rechts = rnd.Next(1, 21);
                Console.Write($"Geef de som van {links} + {rechts} = ");
                
                bool isGelukt = int.TryParse(Console.ReadLine(), out sommen[i]);
                int juisteResultaat = links + rechts;
                if (!isGelukt || (sommen[i] != juisteResultaat))
                {
                    sommen[i] = juisteResultaat;
                    Console.WriteLine("De som was fout!\r\n");
                }
                else
                {
                    Console.WriteLine();
                }
            }

            // Toon resultaten
            Console.WriteLine("\r\n=== Sommen ===");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Som {i+1}: {sommen[i]}");
            }
            Console.WriteLine("\r\nDruk op een toets om af te sluiten....");
            Console.ReadLine();
        }
    }
}
