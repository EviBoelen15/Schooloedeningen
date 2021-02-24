using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningMobiel
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Menu objmenu = new Menu();
            string strBoodschap = "";
            Console.WriteLine(objmenu.Geefmenu());
            objmenu.Keuze = Console.ReadLine();
            objmenu.Opdrachtgsm(strBoodschap);
            Console.WriteLine(strBoodschap);
            Console.ReadLine();
        }
    }
}
