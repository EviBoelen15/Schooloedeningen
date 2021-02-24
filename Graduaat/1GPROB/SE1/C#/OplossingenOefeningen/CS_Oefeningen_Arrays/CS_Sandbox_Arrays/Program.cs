using System;

namespace CS_Sandbox_Arrays
{
    class Program
    {
		private static void LelijkeMethod()
		{
			float gemiddelde = 0.0f;
			int getal0 = 100;
			int getal1 = 50;
			int getal2 = 20;
			int getal3 = 60;
			int getal4 = 90;
			int getal5 = 80;

			gemiddelde = (getal0 + getal1 + getal2 + getal3 + getal4 + getal5) / 6.0f;
			// Console.WriteLine("Gemiddelde: {0}", gemiddelde);
			Console.WriteLine($"Gemiddelde: {gemiddelde}");
		}

		private static void MooieMethod()
		{
			float gemiddelde = 0.0f;
			//int[] getallen = new int[6] { 100, 50, 20, 60, 90, 80 };
			int[] getallen = new int[] { 100, 50, 20, 60, 90, 80 };
			/*
			int[] getallen = new int[6];
			getallen[0] = 100;
			getallen[1] = 50;
			//...
			getallen[5] = 80;
			*/

			
			/*
			for (int i = 0; i < getallen.Length; i++)
				gemiddelde += getallen[i];
			*/
			
            //for (int i = getallen.Length - 1; i >= 0; i--)
			//	gemiddelde += getallen[i];

			
            foreach (int getal in getallen)
				gemiddelde += getal;
		


			gemiddelde /= getallen.Length;

			Console.WriteLine("Gemiddelde: {0}", gemiddelde);
		}


		private static int[] MaakArray()
		{
			int[] getallen = new int[10];
			for (int i = 0; i < 10; i++)
			{
				getallen[i] = i;
			}
			return getallen;
		}

		private static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
				Console.Write($"{element}, ");
            }
			Console.WriteLine();
        }



		static void Main(string[] args)
        {
			LelijkeMethod();
			MooieMethod();

			int[] mijnArray = MaakArray();
			PrintArray(mijnArray);

			Console.ReadLine();
        }
    }
}
