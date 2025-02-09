using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSAndCore
{
    public class MergeWordCharactersAlternately
    {
        public static void Main1()
        {
            string word1 = "abc", word2 = "pqr";
            //string word1 = "ab", word2 = "pqrs";
            //string word1 = "abcd", word2 = "pq";

            string mergeAlternatelyString = MergeAlternately(word1, word2);

            Console.WriteLine("Word 1 = " + word1 + ", Word2 = " + word2);
            Console.WriteLine("New Alternately Merged String = " + mergeAlternatelyString);
            Console.ReadKey();
        }

        public static string MergeAlternately(string word1, string word2)
        {
            StringBuilder mergedString = new StringBuilder();

            int minLenth = word1.Length < word2.Length ? word1.Length : word2.Length;

            for (int i = 0; i < minLenth; i++)
            {
                mergedString.Append(word1[i]);
                mergedString.Append(word2[i]);
            }

            mergedString.Append(word1.Length < word2.Length ? word2.Substring(minLenth) : word1.Substring(minLenth));

            return mergedString.ToString();
        }
    }
}
