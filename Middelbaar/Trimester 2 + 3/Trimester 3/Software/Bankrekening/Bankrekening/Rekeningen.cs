using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekening
{
    class Rekeningen
    {
        List <HoofdklasseRekening> _rekening = new List<HoofdklasseRekening>();
        int _intaantalrekeningen;

        public int AantalRekeningen
        {
            get
            {
                _intaantalrekeningen = _rekening.Count;
                return _intaantalrekeningen;
            }
        }

        public void Toevoegen(HoofdklasseRekening objrekening)
        {
            _rekening.Add(objrekening);
        }
        public string ToonRekeningen()
        {
            string Uitvoer = "";

            foreach(HoofdklasseRekening objrekening in _rekening)
            {
                Uitvoer += objrekening.ToonInformatie();
            }
            if (AantalRekeningen <= 0)
            {
                Uitvoer = "Er zijn geen rekeningen beschikbaar";
            }
            return Uitvoer;
        }
    }
}
