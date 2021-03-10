using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toepassing10
{
    class Persoon
    {
        private string naam;
        private string voornaam;
        private string geslacht;
        private int beoordeling;
        private int startjaar;

        /* Read only eigenschappen */

        public int Dienstjaren => DateTime.Today.Year - startjaar;
        public string geslachtstekst => (geslacht == "V") ? "Vrouwelijk" : "Mannelijk";
        public float premie => BerekenPremie();

        public Persoon()
        {
        }
        public Persoon(string naam, string voornaam, string geslacht, int beoordeling, int startjaar)
        {
            this.naam = naam;
            this.voornaam = voornaam;
            this.geslacht = geslacht;
            this.beoordeling = beoordeling;
            this.startjaar = startjaar;
        }

        public string Naam { get => naam; set => naam = value; }
        public string Voornaam { get => voornaam; set => voornaam = value; }
        public string Geslacht { get => geslacht; set => geslacht = value; }
        public int Beoordeling { get => beoordeling; set => beoordeling = value; }
        public int Startjaar { get => startjaar; set => startjaar = value; }

        private float BerekenPremie()
        {
            float premie = 500 + (20 * Dienstjaren);
            if (beoordeling < 5)
            {
                premie /= 2;
            }
            else if (beoordeling == 7 || beoordeling == 8)
            {
                premie *= 1.5f;
            }else if (beoordeling == 9 || beoordeling == 10)
            {
                premie *= 2f;
            }
            return premie;
        }
        public void VerhoogBeoordeling()
        {
            beoordeling++;
        }
        public void VerlaagBeoordeling()
        {
            beoordeling--;
        }

        public string ToonInfo()
        {
            return $"Personeelslid \n\n" +
                $"Geslacht             : {geslachtstekst}\n" +
                $"Aantal Dienstjaren   : {Dienstjaren}\n" +
                $"Premie               : {premie:c}";
        }
    }
}
