using System;
using System.IO;
using System.Collections.Generic;

namespace CS_Console
{
    class Program
    {
        static int[] ReadArrayFromFile(string filePath)
        {
            List<int> values = new List<int>();
            StreamReader file = new StreamReader(filePath);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                values.Add(int.Parse(line));
            }
            file.Close();

            return values.ToArray();
        }

        static int Day1Star1()
        {
            int[] values = ReadArrayFromFile(@".\data\input.txt");


            int result = 0;
            uint index1 = 0;
            uint index2 = 0;
            for (uint i = 0; i < values.Length; i++)
            {
                for (uint j = i + 1; j < values.Length; j++)
                {
                    if (values[i] + values[j] == 2020)
                    {
                        index1 = i;
                        index2 = j;
                        break;
                    }
                }
            }

            result = values[index1] * values[index2];

            return result;
        }


        static int Day1Star2()
        {
            int[] values = ReadArrayFromFile(@".\data\input.txt");

            int result = 0;
            uint index1 = 0;
            uint index2 = 0;
            uint index3 = 0;
            for (uint i = 0; i < values.Length; i++)
            {
                for (uint j = i + 1; j < values.Length; j++)
                {
                    for (uint k = j + 1; k < values.Length; k++)
                    {
                        if (values[i] + values[j] + values[k] == 2020)
                        {
                            index1 = i;
                            index2 = j;
                            index3 = k;
                            break;
                        }
                    }
                }
            }

            result = values[index1] * values[index2] * values[index3];

            return result;
        }



        static void Main(string[] args)
        {
            Console.WriteLine(Day1Star2());
            Console.ReadLine();
        }
    }
}
