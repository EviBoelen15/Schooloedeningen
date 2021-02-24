using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorphismeDieren
{
    class Hond : Dier
    {
        public override string Geluid()
        {
            string strGeluid = "Woef Woef Woef";
            return strGeluid;
        }
    }
}
