using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;
            int print = 0;
            bool match = false;

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
                    print = i;
                    match = true;
                }              
                leftSum = 0;
                rightSum = 0;
            }
            if (print != 0)
            {
                Console.WriteLine(print);
            }
            if (match && (print == 0))
            {
                Console.WriteLine(0);
            }
            if (match == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
