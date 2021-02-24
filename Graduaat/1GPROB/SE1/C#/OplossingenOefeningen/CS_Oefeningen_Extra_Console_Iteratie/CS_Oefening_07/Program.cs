using System;

namespace CS_Oefening_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string naam;
            do
            {
                Console.Write("Geef een naam: ");
                naam = Console.ReadLine();

                int lengte = naam.Length;
                Console.WriteLine($"Aantal karakers in {naam.ToUpper()} is: {lengte}");
            } while (!naam.Equals("end", StringComparison.OrdinalIgnoreCase));
        }
    }
}
