using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningMobiel
{
    public class Menu
    {
        public string _gsmmenu;
        public string _keuze;
        public string _boodschap;

        public string GsmMenu
        {
            set
            {
                value = _gsmmenu;
            }
            get
            {
                return _gsmmenu;
            }
        }
        public string Keuze
        {
            set
            {
                value = _keuze;
            }
            get
            {
                return _keuze;
            }
        }
        public string Geefmenu()
        {
            _gsmmenu = "Maak je keuze: Druk X om af te sluiten." + "\n" + "A: Nieuwe pincode invoeren."
                     + "\n" + "B: GSM aanzetten" + "\n" + "C: Bellen" + "\n" + "D: Herladen" + "\n"
                    + "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            return _gsmmenu;
        }
        public void Opdrachtgsm(string pstrboodschap)
        {
            _keuze = _keuze.ToUpper();
            Boolean gsmaan = false;
            double dblKrediet = 0;
            string strPin, strEigenpin = "1234";
            while (_keuze != "X")
            {
                switch (_keuze)
                {
                    case "A":
                        if (gsmaan == false)
                        {
                            pstrboodschap = "Je kan de code niet wijzigen. Schakel de gsm eerst in.";
                        }
                        else
                        {
                            Console.Write("Geef de nieuwe pincode in: ");
                            strEigenpin = Console.ReadLine();
                            pstrboodschap = "Je pincode is gewijzigd.";
                        }
                        break;
                    case "B":
                        if (gsmaan == false)
                        {
                            Console.WriteLine("Geef uw pincode");
                            strPin = Console.ReadLine();
                            if (strPin == strEigenpin)
                            {
                                gsmaan = true;
                                pstrboodschap = "Je GSM werd opgestart";
                            }
                            else
                            {
                                pstrboodschap = "Je hebt de foute code ingegeven";
                            }
                        }
                        else
                        {
                            pstrboodschap = "Je gsm staat al aan.";
                        }
                        break;
                    case "C":
                        if (gsmaan == true && dblKrediet > 0.25)
                        {
                            Console.WriteLine("Welk nummer zou je graag bellen?");
                            string strNummer = Console.ReadLine();
                            pstrboodschap = "Er wordt gebeld naar het nummer " + strNummer;
                        }
                        else
                        {
                            pstrboodschap = "Je kan niet bellen. Schakel je GSM eerst in of zorg voor voldoende belkrediet.";
                        }
                        break;
                    case "D":
                        Console.Write("Geef het bedrag waar je mee wilt herladen: ");
                        double dblherlaadbedrag = Convert.ToDouble(Console.ReadLine());
                        dblKrediet = dblKrediet + dblherlaadbedrag;
                        pstrboodschap = "Er werd " + dblherlaadbedrag + " Euro herladen." + "\n" + "Het je nieuwe saldo is gelijk aan " + dblKrediet + " Euro.";
                        break;
                }
            }
        }

    }
}
