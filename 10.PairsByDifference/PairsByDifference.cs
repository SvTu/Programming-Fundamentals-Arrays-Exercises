using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PairsByDifference
{
    class PairsByDifference
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int count = 0;
            

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] - input[j] == difference || input[j] - input[i] == difference)
                    {
                         count++;
                    }
                    
                }
            }
            Console.WriteLine(count);
        }
    }
}
