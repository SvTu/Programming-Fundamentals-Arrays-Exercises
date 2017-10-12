using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split().ToArray();
            string[] secondArr = Console.ReadLine().Split().ToArray();

            int lenght = Math.Min(firstArr.Length, secondArr.Length);
            int count1 = 0;
            int count2 = 0;

            for (int i = 0; i < lenght; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    count1++;
                }
            }

            int index = 1;
            for (int i = lenght; i > 0; i--)
            {
                
                if (firstArr[firstArr.Length - index] == secondArr[secondArr.Length - index])
                {
                    count2++;
                    index++;
                }
            }
            Console.WriteLine(Math.Max(count1,count2));
        }
    }
}
