using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseGames
{
    public // <<- zorgt er voor dat de klasse publiek accessable is //
    class Dobbelsteen
    {
        private int _zijde, Random;
        Random objRandom = new Random();

        public int Zijden
        {
            get
            {
                return _zijde;
            }
        }
        public Dobbelsteen(int pintZijde) // <-- constructor met parameter(aantal zijden van de dobbelsteen)
        {
            _zijde = pintZijde;
        }

        public int Gooien()
        {
            Random = objRandom.Next(0, _zijde + 1);
            return Random;
        }
    }
}
