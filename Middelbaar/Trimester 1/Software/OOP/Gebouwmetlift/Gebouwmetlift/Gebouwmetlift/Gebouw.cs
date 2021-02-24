using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gebouwmetlift
{
    class Gebouw
    {
        private int _hoogteverdiep, _breedteverdiep, _aantalverdiep;

        public int Aantalverdiep
        {
            get
            {
                return _aantalverdiep;
            }
        }
        public int Hoogtegebouw
        {
            get
            {
                return _hoogteverdiep * _aantalverdiep;
            }

        }
        public int Hoogteverdiep
        {
            get
            {
                return _hoogteverdiep;
            }

        }
        public int Breedteverdiep
        {
            get
            {
                return _breedteverdiep;
            }

        }
        //Constructor
        public Gebouw(int pintaantalverdiep, int pinthoogteverdiep, int pintbreedteverdiep)
        {
            _aantalverdiep = pintaantalverdiep;
            _hoogteverdiep = pinthoogteverdiep;
            _breedteverdiep = pintbreedteverdiep;
        }
   }
}
