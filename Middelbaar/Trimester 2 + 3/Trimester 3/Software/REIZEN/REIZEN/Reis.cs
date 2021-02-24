using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REIZEN
{
    class Reis
    {
        //klassenvariabel 
        private string _land;
        private int _aantaldagen;
        private decimal _kostprijs;

        //Constructor
        public Reis(string pLand, int pAantaldagen, decimal pKostprijs)
        {
            Land1 = pLand;
            _aantaldagen = pAantaldagen;
            _kostprijs = pKostprijs;
        }

        //eigenschappen
        public string Land
        {
            get
            {
                return Land1;
            }
            set
            {
                Land1 = value;
            }
        }

        public int Aantaldagen
        {
            get
            {
                return _aantaldagen;
            }
            set
            {
                _aantaldagen = value;
            }
        }

        public decimal Kostprijs
        {
            get
            {
                return _kostprijs;
            }
            set
            {
                _kostprijs = value;
            }
        }

        public string Land1 { get => _land; set => _land = value; }

        //methoden
        public string Omschrijving()
        {
            string uitvoer;
            if (_aantaldagen == 1)
            {
                uitvoer = "1 dag naar " + Land1 + " voor " + _kostprijs + " EURO. "; 
            }
            else
            {
                uitvoer = _aantaldagen + " naar " + Land1 + " voor " + _kostprijs + " EURO. ";
            }
            return uitvoer;
        }

    }
}
