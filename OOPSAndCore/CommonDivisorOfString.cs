using System;

namespace OOPSAndCore
{
    public class CommonDivisorOfString
    {
        public static void Main1()
        {
            //string word1 = "ABCABC", word2 = "ABC";
            string word1 = "ABABAB", word2 = "ABAB";
            //string word1 = "LEET", word2 = "CODE";

            string commonDivisorOfString = GcdOfStrings(word1, word2);

            Console.WriteLine("Word 1 = " + word1 + ", Word2 = " + word2);
            Console.WriteLine("String Divisor = " + commonDivisorOfString);
            Console.ReadKey();
        }

        public static string GcdOfStrings(string str1, string str2)
        {
            if (str1.Length == 0 || str2.Length == 0 || (str1 + str2 != str2 + str1))
                return string.Empty;

            int previousShortest = str1.Length;

            int previousRemainder = str2.Length;

            int remainder = previousShortest % previousRemainder;

            while (remainder != 0)
            {
                previousShortest = previousRemainder;
                previousRemainder = remainder;

                remainder = previousShortest % previousRemainder;
            }

            return str1.Substring(0, previousRemainder);
        }
    }
}
