using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray(); // a ASCII Decimal code = 97;
            byte[] byteArray = Encoding.ASCII.GetBytes(input);
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("{0} -> {1}",input[i] ,byteArray[i] - 97);
            }
        }
    }
}
