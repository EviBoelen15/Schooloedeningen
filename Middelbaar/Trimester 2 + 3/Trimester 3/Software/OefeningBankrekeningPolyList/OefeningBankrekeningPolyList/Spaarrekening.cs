using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningBankrekeningPolyList
{
    class Spaarrekening : Rekening
    {
        decimal _totaalIntrest;
        const decimal _intrest = 0.01M;

        public decimal TotaalIntrest
        {
            get
            {
                _totaalIntrest = _totaalSaldo * _intrest;
                return _totaalIntrest;
            }
        }

        public override string InformatieRekening()
        {
            string strUitvoer;

            strUitvoer = _naam + ", " + _rekeningnummer + "\n" +
                "Totaal opnames: " + _bedragOpgenomen + " euro.  Totaal stortingen: "
                + _bedragGestort + " euro.   Totaal saldo: " + _totaalSaldo + "\n" +
                "Intrest: " + this.TotaalIntrest;

            return strUitvoer;
        }
    }
}
