using System;
using System.Text;

namespace CS_Oefening_038
{
    class Program
    {
        static void Main(string[] args)
        {
            const int aantalWaarden = 5;
            int[] getallen1 = new int[aantalWaarden];
            int[] getallen2 = new int[aantalWaarden];
            int[] sommen = new int[aantalWaarden];
            Random rnd = new Random();
            
            // Random initialisatie
            for (int i = 0; i < getallen1.Length; i++)
                getallen1[i] = rnd.Next(11);

            for (int i = 0; i < getallen2.Length; i++)
                getallen2[i] = rnd.Next(11);

            // Berekening van sommen
            for (int i = 0; i < sommen.Length; i++)
                sommen[i] = getallen1[i] + getallen2[i];

            // Bouw de resultererende string op via StringBuilder
            // en toon het resultaat.
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("=== Som maken van getallen uit 2 arrays ====\r\n\r\n");
            builder.Append("Array 1 ==>");
            foreach (int getal in getallen1)
                builder.Append($"{getal, 6}");
            builder.AppendLine();
            
            builder.Append("Array 2 ==>");
            foreach (int getal in getallen2)
                builder.Append($"{getal, 6}");
            builder.AppendLine();

            builder.Append("Array 3 ==>");
            foreach (int getal in sommen)
                builder.Append($"{getal, 6}");
            builder.AppendLine();

            Console.Write(builder.ToString());
            Console.ReadLine();
        }
    }
}
