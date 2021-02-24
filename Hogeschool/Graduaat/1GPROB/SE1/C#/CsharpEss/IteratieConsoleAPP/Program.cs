using System;

namespace IteratieConsoleAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.WriteLine("Input num?");
            int intInput = Convert.ToInt32(Console.ReadLine());

            //aantal rijen en colommen
            int intStartGetal = intInput * intInput;

            //uitvoer
            string uitvoer = "";

            //rijen
            //LET OP i < intStartGetal geeft niet de volledig juiste uitkomst (telt maar tot 6 af) 
            for (int i = 0; i < intInput; i ++) {
                //kolommen
                for(int j = 0; j < intInput; j++)
                {
                    //het nieuwe getal wordt samen met een spatie in de uitvoer geplaatst
                    //dit wordt input aantal keer gedaan (j < input) 
                    uitvoer += intStartGetal + " ";
                    intStartGetal--;
                }
                //"\n" = volgende lijn, en de loop begint opnieuw
                uitvoer += "\n";
            }

            //de volledige uitvoer wordt op de console afgebeeld
            Console.WriteLine(uitvoer);
            Console.ReadLine();
        }
    }
}
