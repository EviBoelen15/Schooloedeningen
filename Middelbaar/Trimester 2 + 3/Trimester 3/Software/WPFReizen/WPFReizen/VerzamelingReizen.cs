using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFReizen
{
    class VerzamelingReizen
    {
        int _reisNummer;
        List<Reis> _reis;

        public VerzamelingReizen(int pintReisnummer)
        {
            _reisNummer = pintReisnummer;
            _reis = new List<Reis>();
        }

        public int Reisnummer
        {
            get { return _reisNummer; }
        }

        public List<Reis> Reis
        {
            get { return _reis; }
        }

        public void ReisToevoegen(Reis objReis)
        {
            _reis.Add(objReis);
        }

        public decimal TotaalBerekenen(Reis objReis)
        {
            decimal decTotaalprijs = 0;
            decTotaalprijs += objReis.Kostprijs;

            return decTotaalprijs;
        }

        public Reis Informatie(int pintReisnummer)
        {
            if (pintReisnummer - 1 >= 0 && pintReisnummer - 1 < _reis.Count)
            {
                return _reis[pintReisnummer - 1];
            }
            else
            {
                return null;
            }
        }
    }
}
