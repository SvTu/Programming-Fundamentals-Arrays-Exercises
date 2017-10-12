using System;
using System.Linq;

namespace _08.MostFrequentNumberInArray
{
    class MostFrequentNumberInArray
    {
        static void Main(string[] args)
        {
            ushort[] input = Console.ReadLine().Split().Select(ushort.Parse).ToArray();
            int count = 1;
            int frequentNumber = input[0];
            int tempCount = 0;
            int tempNumber = 0;

            for (int i = 0; i < input.Length ; i++)
            {
                tempNumber = input[i];
                tempCount = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    if (tempNumber == input[j])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    frequentNumber = tempNumber;
                    count = tempCount;
                }
            }
            Console.WriteLine("{0}", frequentNumber);
        }
    }
}
