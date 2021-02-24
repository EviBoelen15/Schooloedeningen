using System;

namespace Oefening40
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            string[] arrayNamen;
            int intAantalNamen;

            //invoer
            Console.Write("Hoeveel namen wil je invoeren? ");
            intAantalNamen = Convert.ToInt32(Console.ReadLine());

            arrayNamen = new string[intAantalNamen];


            //verwerking 
            Console.WriteLine("=== Namen in dr aarray zetten ====");
            for(int i = 0; i < arrayNamen.Length; i++)
            {
                Console.Write($"Geef naam {i + 1} : ");
                arrayNamen[i] = Console.ReadLine();
            }

            //uitvoer
            Console.WriteLine("Namen afdrukken. ");
            for (int i = 0; i <= arrayNamen.Length; i++)
            {
                Console.WriteLine($"Naam {i + 1} is: {arrayNamen[i]}");
            }
            Console.ReadLine();
        }
    }
}
