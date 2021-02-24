using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekening
{
    class HoofdklasseRekening
    {
        //eingenschappen
        protected string _eigenaar; //write and read
        protected string _rekening; //write and read
        protected string _soort; //Read only
        protected decimal _saldo; //Read only
        protected decimal _storting; //Read only
        protected decimal _opneming; //Read only
        protected int _aantalVerrichtingen;

        //eigenschappen die in methodes worden verandert zijn enkel lezen, het schrijven wordt in de methode gedaan
        
        public String Eigenaar
        {
            get { return _eigenaar;}
            set { _eigenaar = value;}          
        }
        public String Rekening
        {
            get { return _rekening; }
            set { _rekening = value; }
        }
        public String Soort
        {
            get { return _soort; }
            set { _soort = value; }
        }
        public decimal Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
        public decimal AantalStorting
        {
            get { return _storting; }
            set { _storting = value; }
        }
        public decimal AantalOpneming
        {
            get { return _opneming; }
            set { _opneming = value; }
        }

        //methoden
        public void Opnemen(decimal pdecBedrag)
        {
            _saldo -= pdecBedrag;
            _opneming += pdecBedrag;
            _aantalVerrichtingen++;
        }

        public void Storten(decimal pdecBedrag)
        {
            _saldo += pdecBedrag;
            _storting += pdecBedrag;
            _aantalVerrichtingen++;
        }
        //virtual omdat deze overschreven zal worden door de subklassen
        public virtual string ToonInformatie()
        {
            string Informatie = "";

            Informatie = "\nEigenaar " + _eigenaar + " Rekening " + _rekening + "\n" + "Bedrag opgenomen: " + _opneming + 
                " Bedragen gestort: " + _storting + " Totaal verichtingen: " + _aantalVerrichtingen + " Totaal saldo: " + _saldo;
            return Informatie;
        }


    }
}
