using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSAndCore.Org
{
    public class Accolite
    {
        static void Main1(string[] args)
        {
            // Given array and two numbers find the minimum distance.
            // Ex: 4,7,1,5,7,6,4,3,5   -- // Min dis between 4,5 is 2
            // Ex: 4,7,4,5,7,6,4,3,5   -- // Min dis between 4,5 is 1

            //var items = new int[9] { 4, 7, 1, 5, 7, 6, 4, 3, 5 };
            //int[] items1 = { 4, 7, 4, 5, 7, 6, 4, 3, 5 };
            //var firstNumber = 4;
            //var secondNumber = 5;
            //var result = MinimunDistance(items1, firstNumber, secondNumber);

            //Console.WriteLine("Min distance between {0} and {1} is: {2}", firstNumber, secondNumber, result);
            Console.ReadKey();
        }


        static int MinimunDistance(int[] items, int firstNumber, int secondNumber)
        {
            var minDistance = 0;

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == firstNumber)
                {
                    for (int j = i + 1; j < items.Length; j++)
                    {
                        if (items[j] == secondNumber)
                        {
                            if (minDistance == 0 || (j - i) < minDistance)
                            {
                                minDistance = j - i;
                            }
                        }
                    }
                }
            }
            return minDistance;
        }
    }

    class UnsafeCode
    {
        unsafe static void Main1()
        {
            int* p1 = stackalloc int[3];
            p1[0] = 1;
            p1[1] = 2;
            p1[2] = 3;
            for (int j = 2; j >= 0; j--)
                Console.Write(p1[j] + " ");

            Console.ReadKey();
        }
    }
}
