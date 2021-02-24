using System;

namespace CS_Oefening_037
{
    class Program
    {
        static void Main(string[] args)
        {
            const int aantalGetallen = 10;
            int[] getallen = new int[aantalGetallen];

            Console.WriteLine($"==== Even getallen uit {aantalGetallen} getallen tonen. ====\r\n\r\n");
            for (int i = 0; i < getallen.Length; i++)
            {
                Console.Write($"Geef getal {i + 1}/{getallen.Length} : ");
                //getallen[i] = int.Parse(Console.ReadLine());
                bool isGelukt = int.TryParse(Console.ReadLine(), out getallen[i]);
                if (!isGelukt)
                {
                    Console.WriteLine("Geef een getal in.");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine();
            }

            Console.WriteLine("==== Even getallen afdrukken. ====\r\n");
            for (int i = 0; i < getallen.Length; i++)
            {
                if (getallen[i] % 2 == 0)
                {
                    Console.WriteLine($"Getal {i + 1} is een even getal : {getallen[i]}");
                }
            }

            Console.ReadLine();
        }
    }
}
