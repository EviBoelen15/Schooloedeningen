using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefeningzwembad
{
    class Program
    {
        static void Main(string[] args)
        {
            Zwembad objzwembad = new Zwembad();

            Console.Write("Lengte: ");
            objzwembad.Lengte = Convert.ToDouble(Console.ReadLine());
            Console.Write("Breedte: ");
            objzwembad.Breedte = Convert.ToDouble(Console.ReadLine());
            Console.Write("Diepte: ");
            objzwembad.Diepte = Convert.ToDouble(Console.ReadLine());
            objzwembad.Aantalliter();
            Console.WriteLine("Het zwembad is gevult met " + objzwembad.Aantalliter() + " kubieke liters" );
            Console.ReadLine();
        }
    }
}
