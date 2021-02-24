using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REIZEN
{
    class JaarboekReizen
    {
        //klassevariabelen
        private int _jaartal;
        private List<Reis> _reizen; //<-- declareren van een verzameling objecten van een andere klasse


        //constructor
        public JaarboekReizen(int pJaartal)
        {
            _reizen = new List<Reis>();
            _jaartal = pJaartal;

        }
        //eigenschappen 
        public int Jaartal { get => _jaartal; }

        //methoden
        //reis toevoegen
        public void AddReis(Reis pReis)
        {
            _reizen.Add(pReis);
        }

        //Reis op een bepaalde positienummer zetten
        public Reis geefReis(int pNr)
        {
            if (pNr >= 0 && pNr < _reizen.Count)
            {
                return _reizen[pNr];
            }
            else
            {
                return null;
            }

        }

        //totale kostprijs retourneren van alle reizen in de list
        public decimal TotaalPrijs()
        {
            decimal totaal = 0;
            foreach(Reis objReis in _reizen)
            {
                totaal = totaal + objReis.Kostprijs;
            }
            return totaal;
        }

        //van een opgegeven land via het totaal aantal dagen zoeken
        public int Aantaldageninlan(string pLand)
        {
            int totaalDagen = 0;
            foreach(Reis objReis in _reizen)
            {
                totaalDagen = totaalDagen + objReis.Aantaldagen;
            }
            return totaalDagen;
        }

        //een reis verwijderen op een bepaalde index
        //optie1
        public void VerwijderReis(int pReisnummer)
        {
            if (pReisnummer >= 0 && pReisnummer < _reizen.Count)
            {
                _reizen.RemoveAt(pReisnummer);
            }
            else
            {

            }
                
        }
        //optie 2
        public void VerwijderReis2 (Reis pobjReis)
        {
            _reizen.Remove(pobjReis);
        }

        //alle reizen van een opgegeven land verwijderen
        public void VerijderreizenLand(string pLand)
        {
            foreach(Reis pobjReis in _reizen)
            {
                if (pobjReis.Land == pLand)
                {
                    _reizen.Remove(pobjReis);
                }
            }
        }


    }
}
