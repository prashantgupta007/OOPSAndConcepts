using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSAndCore.Org
{
    public class EagleView
    {
        static bool IsPronicNo(int n)
        {
            int sqrt = Convert.ToInt32(Math.Sqrt(n));

            if (sqrt * (sqrt + 1) == n)
                return true;
            else
                return false;
        }

        static int CountPronic(int A, int B)
        {
            var counter = 0;
            if ((A <= B) && (A >= 1 && A <= 10000000))
                for (int n = A; n <= B; n++)
                {
                    if (IsPronicNo(n))
                    {
                        counter++;
                    }
                }

            Console.Write($"Total Pronic numbers: {counter}");

            return counter;
        }

        // Driver Code 
        public static void Main1()
        {
            //CountPronic(21, 1000000000);
            //GetStatbility();
            //GetDeletionCost();
            CountSubArrayWithSumZero();

            Console.ReadKey();
        }

        static int CountSubArrayWithSumZero(int[] A, int startIndex)
        {
            var result = 0;
            int sum = 0;
            for (int i = startIndex; i < A.Length; i++)
            {
                sum += A[i];
                break;
            }

            return result;
        }
        static int CountSubArrayWithSumZero()
        {
            //int[] A = { 1, 0, -1 };
            int[] A = { 10000, -2, 3, 0, 4, -7 };

            if (A.Distinct().All(a => a == 0) || A.Distinct().Any(a => a < -10000 || a > 10000))
            {
                Console.WriteLine("Wrong input");
                return -1;
            }
                

            var counter = 0;
            for (int i = 0; i < A.Length; i++)
            {
                var sum = 0;
                for (int j = i; j < A.Length; j++)
                {
                    sum += A[j];
                    if (sum == 0)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine($"Result is {counter}");
            return counter;
        }

        public static int GetDeletionCost()
        {
            var result = 0;
            //var S = "abccbd";
            //int[] c = { 0, 1, 2, 3, 4, 5 };
            var S = "aaaa";
            int[] C = { 3, 4, 5, 6 };

            if (S.Length != C.Length)
                result = 0;
            for (int i = 0; i < S.Length - 1; i++)
            {
                if (S[i] == S[i + 1])
                    result += C[i];
            }
            return result;
        }
        public static int GetStatbility()
        {
            var counter = 0;

            int[] arr = { 1, 3, 5, 7, 9 };
            //int[] arr = { 7, 7, 7, 7 };
            //int[] arr = { 3, -1, -5, -9 };
            //int[] arr = { 0, 1 };
            //int[] arr = { 1,  1,  2,  5,  7 };
            if (arr.Length > 3)
            {
                var stabilityDiff = arr[0] - arr[1];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if ((arr[i] - arr[i + 1]) != stabilityDiff)
                    {
                        counter = 0;
                        break;
                    }
                    else
                        counter++;
                }
            }
            else
            {
                counter = 0;
            }
            return counter;
        }


    }
}
