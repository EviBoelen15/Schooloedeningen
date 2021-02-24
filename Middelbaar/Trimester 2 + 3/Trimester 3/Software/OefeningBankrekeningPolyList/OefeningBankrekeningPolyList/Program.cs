using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningBankrekeningPolyList
{
    class Program
    {
        static void Main(string[] args)
        {
            VerzamelingRekeningen _verzamelingRekeningen = new VerzamelingRekeningen();

            string _keuze;
            string strKeuzeBetaling = "";
            string strAntwoord = "";
            decimal decGestortbedrag;
            decimal decAfgehaaldbedrag;

            Console.WriteLine("Open een spaarrekening, druk <S>");
            Console.WriteLine("Open een zichtrekening, druk <Z>");
            Console.WriteLine("Open een andere rekening, druk <A>");
            Console.WriteLine("Om je invoer te beeindigen, druk <E>");
            Console.WriteLine("Maak je keuze: ");
            _keuze = Console.ReadLine().ToUpper();

            while (_keuze != "E")
            {
                switch (_keuze)
                {
                    case "S":
                        Spaarrekening spaarrekening = new Spaarrekening();
                        Console.Write("Geef uw naam in: ");
                        spaarrekening.Naam = Console.ReadLine();

                        while (strAntwoord.ToLower() != "nee")
                        {
                            Console.WriteLine("Wil u geld storten of afhalen? Kies A om te storten en B om af te halen");
                            strKeuzeBetaling = Console.ReadLine().ToUpper();

                            if (strKeuzeBetaling == "A")
                            {
                                Console.Write("Welk bedrag had u graag gestort? ");
                                decGestortbedrag = Convert.ToDecimal(Console.ReadLine());
                                spaarrekening.Opnemen(decGestortbedrag);
                            }
                            else if (strKeuzeBetaling == "B")
                            {
                                Console.Write("Welk bedrag hadu graag af gehaald? ");
                                decAfgehaaldbedrag = Convert.ToDecimal(Console.ReadLine());
                                spaarrekening.Storten(decAfgehaaldbedrag);
                            }

                            Console.Write("Had u nog graag een transactie gedaan? ");
                            strAntwoord = Console.ReadLine();
                        }
                        _verzamelingRekeningen.VoegRekeningToe(spaarrekening);
                        break;

                    case "Z":
                        Zichtrekening zichtrekening = new Zichtrekening();
                        Console.Write("Geef uw naam in: ");
                        zichtrekening.Naam = Console.ReadLine();

                        while (strAntwoord != "nee")
                        {
                            Console.WriteLine("Wil u geld storten of afhalen? Kies A om te storten en B om af te halen");
                            strKeuzeBetaling = Console.ReadLine().ToUpper();

                            if (strKeuzeBetaling == "A")
                            {
                                Console.Write("Welk bedrag had u graag gestort? ");
                                decGestortbedrag = Convert.ToDecimal(Console.ReadLine());
                                zichtrekening.Opnemen(decGestortbedrag);
                            }
                            else if (strKeuzeBetaling == "B")
                            {
                                Console.Write("Welk bedrag hadu graag af gehaald? ");
                                decAfgehaaldbedrag = Convert.ToDecimal(Console.ReadLine());
                                zichtrekening.Storten(decAfgehaaldbedrag);
                            }

                            Console.Write("Had u nog graag een transactie gedaan? ");
                            strAntwoord = Console.ReadLine();
                        }
                        _verzamelingRekeningen.VoegRekeningToe(zichtrekening);
                        break;

                    case "A":
                        Rekening rekening = new Rekening();
                        Console.Write("Geef uw naam in: ");
                        rekening.Naam = Console.ReadLine();

                        while (strAntwoord != "nee")
                        {
                            Console.WriteLine("Wil u geld storten of afhalen? Kies A om te storten en B om af te halen");
                            strKeuzeBetaling = Console.ReadLine().ToUpper();

                            if (strKeuzeBetaling == "A")
                            {
                                Console.Write("Welk bedrag had u graag gestort? ");
                                decGestortbedrag = Convert.ToDecimal(Console.ReadLine());
                                rekening.Opnemen(decGestortbedrag);
                            }
                            else if (strKeuzeBetaling == "B")
                            {
                                Console.Write("Welk bedrag hadu graag af gehaald? ");
                                decAfgehaaldbedrag = Convert.ToDecimal(Console.ReadLine());
                                rekening.Storten(decAfgehaaldbedrag);
                            }
                            Console.Write("Had u nog graag een transactie gedaan? ");
                            strAntwoord = Console.ReadLine();
                        }
                        _verzamelingRekeningen.VoegRekeningToe(rekening);
                        break;
                }

                Console.WriteLine("Open een spaarrekening, druk <S>");
                Console.WriteLine("Open een zichtrekening, druk <Z>");
                Console.WriteLine("Open een andere rekening, druk <A>");
                Console.WriteLine("Om je invoer te beeindigen, druk <E>");
                Console.WriteLine("Maak je keuze: ");
                _keuze = Console.ReadLine().ToUpper();
            }
            Console.WriteLine(_verzamelingRekeningen.LaatRekeningenZien());
            Console.ReadLine();
        }
    }
}
