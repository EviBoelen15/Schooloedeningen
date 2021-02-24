using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekening
{
    class Program
    {
        static void Main(string[] args)
        {
            Rekeningen _rekening = new Rekeningen();
            Random objrandom = new Random();
            decimal decBedrag;

            string _keuze = "";

            Console.WriteLine("Open een spaarrekening, druk <S>");
            Console.WriteLine("Open een zichtrekening, druk <Z>");
            Console.WriteLine("Open een andere rekening, druk <A>");
            Console.WriteLine("Om je invoer te beeindigen, druk <E>");
            Console.WriteLine("Maak je keuze: ");
            _keuze = Console.ReadLine().ToUpper();

            while (_keuze != "E")
            {
                switch(_keuze)
                {
                    case "S":
                        Spaarrekening spaarrekening = new Spaarrekening();

                        Console.Write("Geef de naam van de eigenaar:   ");
                        spaarrekening.Eigenaar = Console.ReadLine();
                        spaarrekening.Rekening = Convert.ToString("BE" + objrandom.Next(1, 99));

                        Console.Write("Zet een bedrag op de rekening:   ");
                        decBedrag = Convert.ToDecimal(Console.ReadLine());
                        spaarrekening.Storten(decBedrag);

                        _rekening.Toevoegen(spaarrekening);

                        break;
                    case "Z":
                        Zichtrekening zichtrekening = new Zichtrekening();

                        Console.Write("Geef de naam van de eigenaar:   ");
                        zichtrekening.Eigenaar = Console.ReadLine();
                        zichtrekening.Rekening = Convert.ToString("BE" + objrandom.Next(1, 99));

                        Console.Write("Zet een bedrag op de rekening:   ");
                        decBedrag = Convert.ToDecimal(Console.ReadLine());
                        zichtrekening.Storten(decBedrag);

                        _rekening.Toevoegen(zichtrekening);

                        break;
                    case "A":
                        HoofdklasseRekening rekening = new HoofdklasseRekening();

                        Console.Write("Geef de naam van de eigenaar:   ");
                        rekening.Eigenaar = Console.ReadLine();
                        rekening.Rekening = Convert.ToString("BE" + objrandom.Next(1, 99));

                        Console.Write("Zet een bedrag op de rekening:   ");
                        decBedrag = Convert.ToDecimal(Console.ReadLine());
                        rekening.Storten(decBedrag);

                        _rekening.Toevoegen(rekening);

                        break;
                }

                Console.WriteLine("Open een spaarrekening, druk <S>");
                Console.WriteLine("Open een zichtrekening, druk <Z>");
                Console.WriteLine("Open een andere rekening, druk <A>");
                Console.WriteLine("Om je invoer te beeindigen, druk <E>");
                Console.WriteLine("Maak je keuze: ");
                _keuze = Console.ReadLine().ToUpper();
            }
            Console.WriteLine(_rekening.ToonRekeningen());
            Console.ReadLine();
        }
    }
}
