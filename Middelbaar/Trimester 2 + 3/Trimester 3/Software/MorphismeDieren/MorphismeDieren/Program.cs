using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorphismeDieren
{
    class Program
    {
        static void Main(string[] args)
        {
            Varken varken = new Varken();
            Kip kip = new Kip();
            Hond hond = new Hond();

            Console.WriteLine("Een hond zegt " + hond.Geluid());
            Console.WriteLine("Een varken zegt " + varken.Geluid());
            Console.WriteLine("Een kip zegt " + kip.Geluid());
            Console.ReadLine();
        }
    }
}
