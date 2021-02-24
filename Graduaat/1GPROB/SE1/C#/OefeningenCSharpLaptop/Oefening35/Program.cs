using System;

namespace Oefening35
{
    class Program
    {
        static void Main(string[] args)
        {

            //declaratie
            int[] arrayGetallen = new int[3];
            int intSom = 0;
            const int MAX_GETALLEN = 3;

            //invoer
            Console.WriteLine("===== Som Bepalen van 3 getallen =====");

            for (int i = 0; i < MAX_GETALLEN; i++)
            {
                Console.Write($"Geef getal {i + 1}/{MAX_GETALLEN}: ");
                arrayGetallen[i] = Convert.ToInt32(Console.ReadLine());
            }

            //verwerking 1
            for(int i = 0; i < arrayGetallen.Length; i++)
            {
                intSom += arrayGetallen[i];
            }

            Console.WriteLine($"De som is {intSom}");
            Console.ReadLine();
        }
    }
}
