using System;

namespace CS_Oefening_05
{
    class Program
    {
        static void Main(string[] args)
        {
            const long maxWereldBevolking = 11000000000L;
            const int dagelijkseGroei = 227000;
            long wereldBevolking = 7800000000; // ondertussen 7.8 miljard
            DateTime datum = DateTime.Now;

            Console.WriteLine($"Wereldbevolking op {datum.ToLongDateString()} is {wereldBevolking:N0}\r\n");
            while (wereldBevolking < maxWereldBevolking)
            {
                wereldBevolking += dagelijkseGroei;
                datum = datum.AddDays(1);
            }
            Console.WriteLine($"Wereldbevolking op {datum.ToLongDateString()} is {wereldBevolking:N}\r\n");

            Console.WriteLine("\r\nDruk op een toets om af te sluiten....");
            Console.ReadLine();
        }
    }
}
