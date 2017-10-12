using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MaxSequenceOfIncreasingElements
{
    class MaxSequenceOfIncreasingElements
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int currLenght = 1;
            int bestLenght = 1;
            int index = 0;
            int startindex = 0;

            for (int i = 1; i < input.Length; i++)
            {
                int prev = input[i - 1];
                int curr = input[i];

                if (curr > prev)
                {
                    currLenght++;

                    if (bestLenght < currLenght)
                    {
                        bestLenght = currLenght;
                        startindex = index;                       
                    }
                }
                else
                {
                    index = i;
                    currLenght = 1;
                }
            }

            for (int i = startindex; i < startindex + bestLenght; i++)
            {
                Console.Write(input[i] + " ");
            }
            Console.WriteLine();
        }
    }
}