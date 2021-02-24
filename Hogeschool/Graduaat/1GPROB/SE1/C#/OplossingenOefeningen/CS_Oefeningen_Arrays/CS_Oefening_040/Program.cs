using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace CS_Oefening_040
{
    class Program
    {
        static void Main(string[] args)
        {
            // Voordat je Interaction.InputBox() kan gebruiken:
            // Maak een C# console app met .NET Framework, niet .NET Core!
            // using Microsoft.VisualBasic;
            int aantalNamen = int.Parse(Interaction.InputBox("Hoeveel namen wens je te beheren?", "Namen"));
            string[] namen = new string[aantalNamen];

            Console.WriteLine("==== Namen in array stockeren en afdrukken. ====\r\n");
            for (int i = 0; i < namen.Length; i++)
            {
                Console.Write($"Geef naam {i + 1}/{namen.Length} : ");
                namen[i] = Console.ReadLine();
            }

            Console.WriteLine("\r\n\r\n==== Namen afdrukken. ====\r\n");
            for (int i = 0; i < namen.Length; i++)
            {
                Console.WriteLine($"Naam {i + 1} is  {namen[i].ToUpper()}");
            }

            // Of via foreach
            /*
            int index = 1; 
            foreach (string naam in namen) 
            { 
                Console.WriteLine($"Naam {index} is  {naam.ToUpper()}"); 
                index++; 
            }
            */
            Console.ReadLine();
        }
    }
}
