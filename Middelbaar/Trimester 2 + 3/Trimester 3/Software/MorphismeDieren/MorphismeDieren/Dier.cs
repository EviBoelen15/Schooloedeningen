using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorphismeDieren
{
    abstract class Dier
    {
        protected int _gewicht; 

        public Dier()
        {
            _gewicht = 0;
        }

        public int Gewicht
        {
            set { _gewicht = value; }
            get { return _gewicht; }
        }
        public virtual string Geluid()
        {
            string strGeluid = "";
            return strGeluid;
        }
    }
}
