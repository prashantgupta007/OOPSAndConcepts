using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPSAndCore
{
    class Palindrome
    {
        public static void Main1(string[] args)
        {
            Console.Write("Enter a String: ");
            string inputString = Console.ReadLine();

            string str = string.Empty;

            for (int j = inputString.Length - 1; j >= 0; j--)
            {
                str += inputString[j];
            }
            if (str == inputString)
                Console.WriteLine(inputString + " is Palindrome.");
            else Console.WriteLine(inputString + " is not a Palindrome.");
            Console.ReadKey();
        }
    }
}
