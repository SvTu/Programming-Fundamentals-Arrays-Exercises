using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxSequenceOfEqualElements            
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int print = 0;
            int currLenght = 1;
            int bestLenght = 1;

            for (int i = 1; i < input.Length; i++)
            {
                int prev = input[i - 1];
                int curr = input[i];
                if (curr != prev)
                {
                    currLenght = 1;
                }
                if (curr == prev)
                {
                    currLenght++;
                    if (currLenght > bestLenght)
                    {
                        bestLenght = currLenght;
                        print = input[i];
                    }
                }
            }
            for (int i = 0; i < bestLenght; i++)
            {
                Console.Write(print + " ");
            }
            Console.WriteLine();
        }
    }
}