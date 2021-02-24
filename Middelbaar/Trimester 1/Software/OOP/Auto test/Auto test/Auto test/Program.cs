using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_test
{
    class Program
    {
        //hoofdprogramma:
        static void Main(string[] args)
        {
            
            Car objCar1 = new Car();
            Car objCar2 = new Car();
            double dblSnelheid;
            string strJANEE, strcode;

            //de kleur wordt opgevraagt
            Console.Write("Standaard kleur: " + objCar1.Kleur);
            Console.Write("Standaard aantal deuren: "+ objCar1.Deur);
            Console.Write("Standaard merk: " + objCar1.Merk);
            Console.Write("Wenst u dit te veranderen? ");
            strJANEE = Console.ReadLine();
            strJANEE = strJANEE.ToLower();
            if (strJANEE == "ja")
            {
                Console.Write("Geef de nieuwe kleur: ");
                objCar1.Kleur = Console.ReadLine();
                Console.Write("Geef het aantal deuren van de auto (groter dan 1, kleiner dan 6): ");
                objCar1.Deur = Convert.ToInt16(Console.ReadLine());
                Console.Write("Geef het merk: ");
                objCar1.Merk = Console.ReadLine();
                
            }
            Console.Write("Geef de code van uw auto in: ");
            strcode = Console.ReadLine();
            if (objCar1.Controlecode(strcode) == true)
            {
                Console.Write("Welkom in uw auto");
            }
            else
            {
                Console.Write("Foute code");
            }

            Console.Write("Geef de snelheid waar mee u wilt verhogen: ");
            dblSnelheid = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Uw gekozen auto is " + objCar1.Kleur + ", heeft " + objCar1.Deur + " deuren, en heeft het merk " + objCar1.Merk);
            Console.ReadLine();

        }
    }
}
