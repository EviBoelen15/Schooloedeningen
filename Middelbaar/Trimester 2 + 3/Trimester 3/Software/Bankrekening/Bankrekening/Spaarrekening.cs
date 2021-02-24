using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekening
{
    class Spaarrekening : HoofdklasseRekening
    {
        const decimal cIntrest = 0.01m;
        decimal _intrest;


        public decimal Intrest
        {
            get
            {
                _intrest = _saldo * cIntrest;
                return _intrest;
            }
        }

        public override string ToonInformatie()
        {
            string Informatie = "";

            Informatie = "\nEigenaar " + _eigenaar + " Rekening " + _rekening + "\n" + "Bedrag opgenomen: " + _opneming +
                " Bedragen gestort: " + _storting + " Totaal verichtingen: " + _aantalVerrichtingen + " Totaal saldo: " + _saldo + "\n" +
                "Intrest: " + Intrest + " euro.";
            return Informatie;
        }
    }
}
