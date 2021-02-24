using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningBankrekeningPolyList
{
    class Zichtrekening : Rekening
    {
        decimal _totaalKost;
        const decimal _kost = 0.10M;

        public decimal TotaalKost
        {
            get
            {
                _totaalKost = _totaalSaldo * _kost;
                return _totaalKost;
            }
        }

        public override string InformatieRekening()
        {
            string strUitvoer;

            strUitvoer = _naam + ", " + _rekeningnummer + "\n" +
                "Totaal opnames: " + _bedragOpgenomen + " euro.  Totaal stortingen: "
                + _bedragGestort + " euro.   Totaal saldo: " + _totaalSaldo + "\n" +
                "Kost: " + this.TotaalKost + " euro.";

            return strUitvoer;
        }
    }
}
