using System;

namespace OOPSAndCore
{
    public class ReverseString
    {
        public static void Main1()
        {
            //string inputString = "the sky is blue";
            //string inputString = "  hello world  ";
            string inputString = "a good   example";

            string reverseString = ReverseWords(inputString);

            Console.WriteLine("Input String = " + inputString);
            Console.WriteLine("Reverse String = '" + reverseString + "'");
            Console.ReadKey();
        }

        public static string ReverseWords(string s)
        {
            string reverseString = String.Empty;

            string[] arrString = s.Split(' ');

            for (int i = arrString.Length - 1; i >= 0; i--)
            {
                if (arrString[i] != "")
                {
                    reverseString += arrString[i] + " ";
                }
            }

            return reverseString.Trim();
        }
    }
}
