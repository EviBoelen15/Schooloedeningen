using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekening
{
    class Zichtrekening : HoofdklasseRekening
    {
        const decimal cKostPerVerrichting = 0.10m;
        decimal _kost;


        public decimal Kost
        {
            get
            {
                _kost = _aantalVerrichtingen * cKostPerVerrichting;
                return _kost;
            }
        }

        public override string ToonInformatie()
        {
            string Informatie = "";

            Informatie = "\nEigenaar " + _eigenaar + " Rekening " + _rekening + "\n" + "Bedrag opgenomen: " + _opneming +
                " Bedragen gestort: " + _storting + " Totaal verichtingen: " + _aantalVerrichtingen + " Totaal saldo: " + _saldo + "\n" +
                "Kost van de rekening: " + Kost + " cent, oftewel " +  (Kost / 10) + " euro.";
            return Informatie;
        }
    }
}

