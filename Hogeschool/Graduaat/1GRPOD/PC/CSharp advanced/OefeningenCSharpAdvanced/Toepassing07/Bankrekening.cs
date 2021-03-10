using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toepassing07
{
    public class Bankrekening
    {
        private decimal huidigSaldo;

        public Bankrekening()
        {
            
        }
        public decimal HuidigSaldo 
        {
            get
            {
                return huidigSaldo;
            }
            set 
            {
                huidigSaldo = value;
            } 
        }

        public void Opname(decimal getal)
        {
            huidigSaldo -= getal;
        }
        public void Storting(decimal getal)
        {
            huidigSaldo += getal;
        }
    }
}
