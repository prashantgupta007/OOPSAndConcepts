using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPSAndCore
{
    class StringBasedTest
    {
        private static void Main()
        {
            StringBasedTest obj = new StringBasedTest();
            obj.SortString("kkksde");
            //obj.StringCompression();
            //obj.ReverseString("hey");
            //obj.GetUniqueCharacters();
            //obj.GetSwappedWord();
            //obj.ReverseEachWordInSentance();
            //obj.DSPriorityValidation();
            Console.ReadKey();
        }

        public void ReverseString(string inputSting)
        {
            char[] charArray = inputSting.ToCharArray();
            StringBuilder sbRreverse = new StringBuilder();
            for (int i = charArray.Length - 1; i > -1; i--)
            {
                sbRreverse.Append(charArray[i]);
            }

            Console.WriteLine("Original string is: " + inputSting);
            Console.WriteLine("Reversed string is: " + sbRreverse);
        }

        private void SortString(string str)
        {
            string[] strArr = new string[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                strArr[i] = str.Substring(i, 1);
            }
            Array.Sort(strArr);

            str = string.Empty;
            for (int i = 0; i < strArr.Length; i++)
            {
                str += strArr[i];
            }
            Console.WriteLine("Sorted String: " + str);
        }

        private void StringCompression()
        {
            Console.Write("\n---------------------------------\n");
            string str = "kkksde", tempStr = string.Empty;
            int j, counter = 1;

            //----  String Compression

            // ------- 1st Method
            for (int i = 0; i < str.Length; i += counter)
            {
                counter = 1;
                for (j = i; j < str.Length - 1; j++)
                {
                    if (str[j] == str[j + 1])
                    {
                        counter++;
                        continue;
                    }
                    break;
                }
                if (counter > 1)
                {
                    tempStr += str[j] + counter;
                }
                else { tempStr += str[j]; }
            }

            Console.WriteLine("First Method: " + tempStr);

            // ------- 2nd Method 
            string strng = "abcefggdfrgsddjhhghjkhjkfffaf";
            int count = 0;
            int size = strng.Length;

            string[] strarray = new string[size];
            for (int i = 0; i < strng.Length; i++)
            {
                strarray[i] = strng.Substring(i, 1);
            }
            //Array.Sort(strarray);
            strng = "";
            for (int i = 0; i < strarray.Length - 1; i++)
            {

                if (strarray[i] == strarray[i + 1])
                {
                    count++;
                }
                else
                {
                    count++;
                    strng += strarray[i] + count;
                    count = 0;
                }
            }
            count++;
            strng += strarray[strarray.Length - 1] + count;
            Console.WriteLine("Second Method: " + strng);
            Console.ReadKey();

            //----  String Compression End
        }

        private void GetUniqueCharacters()
        {
            //inputString = "adfgdsafwed"
            //outputString = "adfgswe"
            Console.Write("\n-------------------------------------------\n");
            Console.Write("----  Its a unique characters collection test  ----");
            Console.Write("\n-------------------------------------------\n");
            Console.Write("Please give some input string for Unique characters:");
            string inputString = Console.ReadLine();

            string tempStr = string.Empty;

            //----  String Compression

            for (int i = 0; i < inputString.Length; i++)
            {
                for (int j = 0; j < inputString.Length - 1; j++)
                {
                    if ((inputString[i] == inputString[j]) && (i < j))
                    {
                        tempStr += inputString[i];

                        break;
                    }
                }

            }
            Console.WriteLine("Original string is: " + inputString);
            Console.WriteLine("Unique characters string is: " + tempStr);
        }

        private void GetSwappedWord()
        {
            //find two swapped nos
            string[] arr1 = { "first", "second", "third", "fourth", "fifth" };
            string[] arr2 = { "first", "fourth", "third", "second", "fifth" };

            string[] swappedWords = new string[2];
            int counter = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (counter < 2)
                {
                    if (arr1[i] != arr2[i])
                    {
                        swappedWords[counter] = arr1[i];
                        counter++;
                    }
                    else continue;
                }
                else break;
            }
        }

        private void ReverseEachWordInSentance()
        {
            string testSentance = "This is the sentance which will be reversed";
            StringBuilder sb = new StringBuilder();

            string[] stringArr = testSentance.Split(' ');
            //foreach (var str in stringArr)
            //{
            //    char[] charArr = str.ToCharArray();
            //    for (int i = charArr.Length - 1; i >= 0; i--)
            //    {
            //        sb.Append(charArr[i]);
            //    }
            //    sb.Append(" ");
            //}

            //for (int j = 0; j < stringArr.Length; j++)
            for (int j = stringArr.Length - 1; j >= 0; j--)
            {
                char[] charArr = stringArr[j].ToCharArray();
                for (int i = charArr.Length - 1; i >= 0; i--)
                {
                    sb.Append(charArr[i]);
                }
                sb.Append(" ");
            }

            Console.WriteLine(sb.ToString());

            Console.ReadKey();
        }
    }
}
