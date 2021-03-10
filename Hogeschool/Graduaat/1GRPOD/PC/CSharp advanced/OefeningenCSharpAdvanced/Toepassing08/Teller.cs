using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toepassing08
{
    public class Teller
    {
        private int counter;

        public Teller()
        {
            
        }

        public int Counter { get => counter; set => counter = value; }

        public void ResetTeller()
        {
            counter = 0;
        }
        public void AddTeller()
        {
            counter++;
        }
        public void AddTeller(int getal)
        {
            counter += getal;
        }
        public void RemoveTeller()
        {
            counter--;
        }
    }
}
