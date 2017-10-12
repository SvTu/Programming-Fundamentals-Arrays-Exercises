using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            if (firstArray.Length > secondArray.Length)
            {
                Console.WriteLine(string.Join("", secondArray));
                Console.WriteLine(string.Join("", firstArray));
            }
            if (secondArray.Length > firstArray.Length)
            {
                Console.WriteLine(string.Join("", firstArray));
                Console.WriteLine(string.Join("", secondArray));
            }

            if (firstArray.Length == secondArray.Length)
            {
                if (firstArray[0] > secondArray[0])
                {
                    Console.WriteLine(string.Join("", secondArray));
                    Console.WriteLine(string.Join("", firstArray));
                }
                else
                {
                    Console.WriteLine(string.Join("", firstArray));
                    Console.WriteLine(string.Join("", secondArray));
                }              
            }           
        }
    }
}
