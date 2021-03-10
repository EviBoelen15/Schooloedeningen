using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseGebruiker
{
    class Gebruiker
    {
        private string familienaam;

        public Gebruiker()
        {​​
        }​​
        public string Voornaam {​​ get; set; }​​
        public string Naam
        {​​
            get
            {​​
                return familienaam;
            }​​
                set
            {​​
                familienaam = value.Trim();
            }​​
        }​​
        public string Gegevens => $"{​​Voornaam}​​ {​​Naam.ToUpper()}​​";
        public string ToonNaam() => $"Lector {​​Voornaam}​​ {​​Naam}​​";
        public Gebruiker(string name, string familyname)
        {​​
        familienaam = familyname; // De property Voornaam/Naam krijgt een waarde.
            Voornaam = name;
        }​​
    }
}
        