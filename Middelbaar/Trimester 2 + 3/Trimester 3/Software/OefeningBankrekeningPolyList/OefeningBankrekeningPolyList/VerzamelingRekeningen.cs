using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningBankrekeningPolyList
{
    class VerzamelingRekeningen
    {
        List<Rekening> _rekenings = new List<Rekening>();
        Random random = new Random();
        int _aantalrekeningen;

        public int Aantalrekeningen
        {
            get
            {
                _aantalrekeningen = _rekenings.Count;
                return _aantalrekeningen;
            }
        }

        public void VoegRekeningToe(Rekening rekening)
        {
            _rekenings.Add(rekening);
        }
        public string LaatRekeningenZien()
        {
            string strUitvoer = "";
            foreach (Rekening rekening in _rekenings)
            {
                strUitvoer += rekening.InformatieRekening();
            }
            if (_aantalrekeningen <= 0)
            {
                strUitvoer = "Er bevinden zich geen rekeningen";
            }
            return strUitvoer;
        }
    }
}
