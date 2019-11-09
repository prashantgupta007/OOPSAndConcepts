using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPSAndCore
{
    class Palindrome
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a String: ");
            string inputString = Console.ReadLine();
            var result = CountPalindromInSentence("this is level 71", 16);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static int CountPalindromInSentence(string input1, int input2)
        {
            if (input1.Length != input2)
            {
                return 0;
            }

            int count = 0;
            foreach (var word in input1.Split(' '))
            {
                if (IsPalindrom(word))
                {
                    count++;
                }
            }

            return count;
        }

        public static bool IsPalindrom(string word)
        {
            string reverseStr = string.Empty;
            for (int j = word.Length - 1; j >= 0; j--)
            {
                reverseStr += word[j];
            }
            if (reverseStr == word)
                return true;
            else
                return false;
        }
    }
}
