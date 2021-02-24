using System;

namespace CS_Oefening_036
{
    class Program
    {
        static void Main(string[] args)
        {
            const int aantalGetallen = 9;
            int[] getallen = new int[aantalGetallen];

            Console.WriteLine($"==== Getal opvragen uit {aantalGetallen} ====\r\n\r\n");
            for (int i = 0; i < getallen.Length; i++)
            {
                Console.Write($"Geef getal {i + 1}/{getallen.Length} : ");
                getallen[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.Write($"Welk getal van de {getallen.Length} getallen wens je opnieuw te zien? ");
            int index = int.Parse(Console.ReadLine()) - 1;
            if (index < 0 || index >= getallen.Length)
            {
                Console.WriteLine("\r\n\r\n Dit is geen geldig hoeveelste getal!");
                return;
            }
            int gekozenGetal = getallen[index];
            Console.WriteLine($"\r\n\r\nJouw getal is {gekozenGetal}");
            Console.ReadLine();
        }
    }
}
