using System;

namespace VoorbeeldWhile1
{
    class Program
    {
        static void Main(string[] args)
        {
            string invoer = ToonMenu();
            behandelmenu(invoer);


            while (invoer != "9")
            {
                Oefening1();
            }
        }

        static void behandelmenu(string keuze)
        {
            switch (keuze)
            {
                case "0":
                    Console.Clear();
                    ToonMenu();
                    break;
                case "1":
                    Oefening1();
                    Console.Clear();
                    ToonMenu();
                    break;
                case "2":
                    Oefening2();
                    Console.Clear();
                    ToonMenu();
                    break;
                case "3":
                    Oefening3();
                    Console.Clear();
                    ToonMenu();
                    break;
                default:
                    FoutieveIngave();
                    ToonMenu();
                    break;
            }
        }
        static string ToonMenu()
        {
            Console.WriteLine("PXL Console toepassingen");
            Console.WriteLine("------------------------");
            Console.WriteLine("Maak het scherm leeg -> Druk 0");
            Console.WriteLine("Start oefening 1: -> druk 1");
            Console.WriteLine("Start oefening 2: -> druk 2");
            Console.WriteLine("Start oefening 3: -> druk 3");
            Console.WriteLine("Stop het oefeningenscherm: -> druk 9");
            Console.Write("Maak uw keuze:");
            string invoer = Console.ReadLine();
            return invoer;
        }
        static void FoutieveIngave()
        {
            Console.WriteLine("foutieve ingave, druk op enter om opnieuw te beginnen");
            ToonMenu();
        }

        static void Oefening1()
        {
            Header("Oefening 1", "Maak de som van 5 ingevoerde getallen");
            string input;
            int som = 0;
            int getal = 0;
            for (int teller = 0; teller < 5; teller++)
            {
                Console.WriteLine("");
                Console.WriteLine($"Geef getal {teller}: ");
                input = Console.ReadLine();
                int.TryParse(input, out getal);
                som += getal;
                Console.WriteLine($"----> som voorgaande getallen: {som}");
            }
            Console.WriteLine("");
            Console.WriteLine("Druk op enter om terug naar het menu te gaan");
            Console.ReadLine();

        }
        static void Oefening2()
        {
            Header("Oefening 2", "Maak de som van fibonachi");
            int som = 0;
            int getal1 = 0;
            int getal2 = 1;
            Console.Write($"{getal1} {getal2}");
            for (int teller = 0; teller < 25; teller++)
            {
                som = getal1 + getal2;
                Console.Write($" {som}");
                getal1 = getal2;
                getal2 = som;

            }
            Console.WriteLine($"\n ----> som van de getallen: {som}");
            Console.WriteLine("Druk op enter om terug naar het menu te gaan");
            Console.ReadLine();

        }
        static void Oefening3()
        {
            Header("Oefening 3", "Bereken wanneer er 11 miljard mensen op aarden zijn");

            long startBev = 7630000000;
            long addPerdag = 227000;
            long endBev = 11000000000;
            int aantaldagen = 0;
            DateTime vandaag = DateTime.Now;

            do
            {
                startBev += addPerdag;
                aantaldagen++;
            } while (startBev < endBev);

            Console.WriteLine($"\n ----->Op {vandaag.AddDays(aantaldagen).ToLongDateString()} zijn we met 11 000 000 000 mensen op de aarde");
            Console.WriteLine("Druk op enter om terug naar het menu te gaan");
            Console.ReadLine();
        }
        static void Header(string titel, string subtitel)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("PXL Console toepassingen");
            Console.WriteLine("------------------------");
            Console.WriteLine("");
            Console.WriteLine(titel);
            Console.WriteLine(subtitel);
            Console.WriteLine("");
        }
    }
}
