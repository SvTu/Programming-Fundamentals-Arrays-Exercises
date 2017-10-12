using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] rotatedArray = new int[input.Length];
            int[] sumArray = new int[input.Length];
            int count = int.Parse(Console.ReadLine());

            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    rotatedArray[i] = input[(i + input.Length - 1) % input.Length];             
                }
                for (int i = 0; i < input.Length; i++)
                {
                    sumArray[i] += rotatedArray[i];
                }
                input = rotatedArray;
                rotatedArray = new int[input.Length];   
            }

            foreach (var item in sumArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
