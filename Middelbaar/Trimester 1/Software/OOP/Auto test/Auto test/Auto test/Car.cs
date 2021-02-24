using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_test
{
    class Car
    {
        //Klassen variabelen of velden (private of public + gegevenstype_ + woord met kleine letter)
        private string _kleur, _merk, _code;
        private double _snelheid;
        private int _deur;
        //private: betekend dat het bereik enkel tussen de acollades blijft

        //eigenschappen van de klasse
        public string Kleur//<-- eigenschap
        {
            set//<-- set = schrijven
            {
                _kleur = value; //in het hoofdprogramma wordt een waarde gegeven aan _kleur die doorgegeven wordt.
            }
            get //<-- get = lezen
            {
                return _kleur; //de value wordt gegeven als er bij een variabelen .Kleur achter staat
            }

        }
        public string Merk
        {
            set
            {
                _merk = value;
            }
            get
            {
                return _merk;
            }

        }
        public int Deur
        {
            set
            {    
                if (value > 1 && value < 6)
                {
                    _deur = value;
                }
            }
            get
            {
                return _deur;
            }
        }
        public double Snelheid
        {
            get
            {
                return _snelheid;
            }
        }
        public string Code
        {
            set
            {
                _code = value;
            }
        }
        //methode (procedure)
        public void Gaspedaal(double pSnelheid)
        {
            if (pSnelheid + _snelheid < 200)
            {
                _snelheid = _snelheid + pSnelheid;
            }
            
        }
        //methode (funtie)
        public Boolean Controlecode (string pcode)
        {
            if (pcode == _code)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //constructor(altijd zelfde naam als klasse)<-- geeft standaard waarde 
        public Car()
        {
            _kleur = "wit";
            _snelheid = 0;
            _merk = "Peugot";
            _deur = 2;
            _code = "1234";
        }


    }
}
