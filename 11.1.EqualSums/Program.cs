using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i; j < input.Length - 1; j++)
                {
                    rightSum += input[j + 1];
                }
                if (i != 0)
                {
                    for (int k = i - 1; k >= 0; k--)
                    {
                        leftSum += input[k];
                    }

                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
                leftSum = 0;
                rightSum = 0;
            }
            Console.WriteLine("no");
        }
    }
}