using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPSAndCore
{
    public class MicroSoft
    {
        public static void Main1()
        {

            //Int32 i = 10;
            //Object j = i;
            //Int16 k = (Int16)(Int32)j;
            //Int16 l = (Int16)j;
            //char ch;
            //Int32 num;
            //ch = (char)66;
            //Console.WriteLine(ch);
            //Console.ReadLine();

            SubPalindrom("abccba");

            int[] numbers = new[] { 1, 2, 3 };
            count(numbers, 6);
        }

        public static List<T[]> CreateSubsetsGeneric<T>(T[] originalArray)
        {
            List<T[]> subsets = new List<T[]>();

            for (int i = 0; i < originalArray.Length; i++)
            {
                int subsetCount = subsets.Count;
                subsets.Add(new T[] { originalArray[i] });

                for (int j = 0; j < subsetCount; j++)
                {
                    T[] newSubset = new T[subsets[j].Length + 1];
                    subsets[j].CopyTo(newSubset, 0);
                    newSubset[newSubset.Length - 1] = originalArray[i];
                    subsets.Add(newSubset);
                }
            }

            return subsets;
        }

        static long count(int[] numbers, int k)
        {
            long counter = 0;
            List<int[]> substets = CreateSubsets(numbers);
            if (substets.Count > 0)
            {
                foreach (var item in substets)
                {
                    if (item.Sum() < k)
                        counter++;
                }
            }
            Console.WriteLine(counter);

            Console.ReadKey();

            return counter;
        }

        public static List<int[]> CreateSubsets(int[] originalArray)
        {
            List<int[]> subsets = new List<int[]>();

            for (int i = 0; i < originalArray.Length; i++)
            {
                int subsetCount = subsets.Count;
                subsets.Add(new int[] { originalArray[i] });

                for (int j = 0; j < subsetCount; j++)
                {
                    int[] newSubset = new int[subsets[j].Length + 1];
                    subsets[j].CopyTo(newSubset, 0);
                    newSubset[newSubset.Length - 1] = originalArray[i];
                    subsets.Add(newSubset);
                }
            }

            return subsets;
        }

        private static void SubPalindrom(String str)
        {
            int counter = 0;
            var query =
                        from i in Enumerable.Range(0, str.Length)
                        from j in Enumerable.Range(0, str.Length - i + 1)
                        where j >= 1
                        select str.Substring(i, j);

            if (query.Count() > 0)
            {
                foreach (var v in query)
                {
                    if (IsPalindrome(v))
                        counter++;
                }
            }

            Console.WriteLine(counter);
            Console.ReadKey();
        }

        private static bool IsPalindrome(string inputString)
        {
            string str = string.Empty;
            for (int j = inputString.Length - 1; j >= 0; j--)
            {
                str += inputString[j];
            }
            if (str == inputString)
                return true;
            else return false;
        }

        private static void FindRequiredSumSubArray(int[] arr, int sum)
        {
            //create an array for the subset with max length od input array  
            int[] sub = new int[arr.Length];
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i, col = 0; j < arr.Length; j++, col++)
                {
                    //add the value of input array one by one  
                    temp += arr[j];
                    sub[col] = arr[j];
                    //if addition is equal to sum then print it  
                    if (temp == sum)
                    {
                        int total = 0;
                        for (int k = 0; k < sub.Length; k++)
                        {
                            total += sub[k];
                            Console.Write(sub[k].ToString() + " ");

                            //if total and sum are equal then leave the print  
                            if (total == sum)
                            {
                                Console.Write("\n");
                                break;
                            }
                        }
                    }
                    //if temp is greater than sum are equal then clear the sub array, set temp value and leave the loop for next  
                    if (temp > sum)
                    {
                        Array.Clear(sub, 0, sub.Length);
                        temp = 0;
                        break;
                    }
                }
            }
        }
    }
}
