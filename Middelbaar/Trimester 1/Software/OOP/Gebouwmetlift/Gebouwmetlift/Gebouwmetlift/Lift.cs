using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gebouwmetlift
{
    class Lift
    {
        //Klassenvariabelen
        private int _breedtelift, _hoogtelift, _aantalverdiep, _bestemming, _huidigverdiep;

        //Constructor
        public Lift(Gebouw pobjGebouw)
        {
            _aantalverdiep = pobjGebouw.Aantalverdiep;
            _breedtelift = pobjGebouw.Breedteverdiep;
            _hoogtelift = pobjGebouw.Hoogteverdiep;
            _huidigverdiep = 0;
        }

        //Eigenschappen
        public int AantalVerdiepingen
        {
            get
            {
                return _aantalverdiep;
            }
        }

        public int Breedte
        {
            get
            {
                return _breedtelift;
            }
        }

        public int Hoogte
        {
            get
            {
                return _hoogtelift;
            }
        }

        public int Bestemming
        {
            set
            {
                if (_bestemming <= _aantalverdiep)
                {
                    _bestemming = value;
                }
            }
        }

        public int HuidigVerdiep
        {
            get
            {
                return _huidigverdiep;
            }
        }

        //Methoden
        public void GaNaarBestemming()
        {
            _huidigverdiep = _bestemming;
        }
    }
}
