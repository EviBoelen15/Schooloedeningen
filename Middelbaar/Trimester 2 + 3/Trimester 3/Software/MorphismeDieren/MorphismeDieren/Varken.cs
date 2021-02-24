using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorphismeDieren
{
    class Varken : Dier
    {
        public override string Geluid()
        {
            string strGeluid = "Knor Knor Knor ";
            return strGeluid;
        }
    }
}
