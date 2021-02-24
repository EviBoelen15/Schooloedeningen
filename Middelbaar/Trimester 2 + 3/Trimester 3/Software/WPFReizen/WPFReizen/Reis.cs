using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFReizen
{
    class Reis
    {
        private string _land;
        private int _aantalDagen;
        private decimal _kostPrijs;
        //private int _aantalReizigers;

        public Reis(string pstrLand, int pintAantalDagen, decimal pdecKostPrijs)
        {
            _land = pstrLand;
            _aantalDagen = pintAantalDagen;
            _kostPrijs = pdecKostPrijs;
        }

        public string Land
        {
            set { _land = value; }
            get { return _land; }
        }

        public int Aantaldagen
        {
            set { _aantalDagen = value; }
            get { return _aantalDagen; }
        }

        public decimal Kostprijs
        {
            set { _kostPrijs = value; }
            get { return _kostPrijs; }
        }

        public string OmschrijvingReis()
        {
            string strUitvoer = "";
            if (_aantalDagen == 1)
            {
                strUitvoer = "U gaat op reis voor 1 dag, naar " + _land + "/n"
                     + "Dit kost u " + _kostPrijs;
            }
            else
            {
                strUitvoer = "U gaat op reis voor " + _aantalDagen + " dagen, naar " + _land + "\n"
                     + "Dit kost u " + _kostPrijs + " euro. ";
            }
            return strUitvoer;
        }        
    }
}
