using System;
using System.Collections.Generic;

namespace CS_Oefening_041
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namen = { "Achraf", "Annelies", "Jurgen",
                "Kevin", "Silvio", "Nathan", "Emma", "Nora", "Frank", "Louise",
                "Matty", "Arend", "Simon", "Lise", "Pascal", "Liesbet", "Laura",
                "Charlotte", "Johan", "Vincent", "Wim", "Tuba", "Kristof", 
                "Kenneth"};

            Console.WriteLine("==== Namen afdrukken. ====\r\n");
            int nummer = 1;
            foreach (string naam in namen)
            {
                Console.WriteLine($"Naam {nummer, 2} : {naam.ToUpper()}");
                nummer++;
            }

            Console.WriteLine("\r\n==== Namen gesorteerd afdrukken. ====\r\n");
            Array.Sort(namen);
            for (int i = 0; i < namen.Length; i++)
            {
                Console.WriteLine($"Naam {i + 1, 2} : {namen[i].ToUpper()}");
            }
            Console.ReadLine();
        }
    }
}
