using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefeningzwembad
{
    class Zwembad
    {
        private double _lengte, _breedte, _diepte;

        public double Lengte
        {
            set
            {
                _lengte = value;
            }
            get
            {
                return _lengte;
            }
        }
        public double Breedte
        {
            set
            {
                _breedte = value;
            }
            get
            {
                return _breedte;
            }
        }
        public double Diepte
        {
            set
            {
                _diepte = value;
            }
            get
            {
                return _diepte;
            }
        }
        public double Aantalliter ()
        {
            double dblLiter;
            dblLiter = (_diepte - 20) * _lengte * _breedte;
            return dblLiter;
        }
        public Zwembad()
        {
            _lengte = 0;
            _breedte = 0;
            _diepte = 0;
        }
    }
}
