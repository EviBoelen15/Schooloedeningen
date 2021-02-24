using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningBankrekeningPolyList
{
    class Rekening
    {
        //var 
        protected string _naam; //read en write
        protected string _rekeningnummer; //read
        protected decimal _bedragOpgenomen; //read
        protected decimal _bedragGestort; //read
        protected decimal _totaalSaldo; //read
        protected int _aantalVerrichtingen;

        //eig
        public string Naam
        {
            set { _naam = value; }
            get { return _naam; }
        }
        public string Rekeningnummer
        {
            get { return _rekeningnummer; }
        }
        public decimal Opnames
        {
            get { return _bedragOpgenomen; }
        }
        public decimal Stortingen
        {
            get { return _bedragGestort; }
        }
        public decimal TotaalSaldo
        {
            get { return _totaalSaldo; }
        }
        public int AantalVerrichtingen
        {
            get { return _aantalVerrichtingen; }
        }

        //meth 
        public void Storten(decimal pdecBedrag)
        {
            _totaalSaldo += pdecBedrag;
            _bedragGestort += pdecBedrag;
            _aantalVerrichtingen++;
        }

        public void Opnemen(decimal pdecBedrag)
        {
            _totaalSaldo -= pdecBedrag;
            _bedragOpgenomen += pdecBedrag;
            _aantalVerrichtingen++;
        }

        public virtual string InformatieRekening()
        {
            string strUitvoer;

            strUitvoer = _naam + ", " + _rekeningnummer + "\n" +
                "Totaal opnames: " + _bedragOpgenomen + " euro.  Totaal stortingen: "
                + _bedragGestort + " euro.   Totaal saldo: " + _totaalSaldo;

            return strUitvoer;
        }
    }
}
