using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
            int k = inputArr.Length / 4; 
            int[] firstArr = new int[k * 2]; 
            int[] sumArr = new int[k * 2];   

            for (int i = 0; i < k ; i++)
            {
                firstArr[i] = inputArr[k - 1 - i];
            }

            for (int i = 0; i < k; i++)
            {
                firstArr[i + k] = inputArr[inputArr.Length - 1 - i];

            }

            for (int i = 0; i < k * 2; i++)
            {
                sumArr[i] = inputArr[k + i] + firstArr[i];
            }

            Console.WriteLine(string.Join(" ",sumArr));
        }
    }
}
