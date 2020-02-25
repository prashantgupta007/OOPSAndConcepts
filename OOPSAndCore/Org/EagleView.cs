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
            int sqrt = (int)(Math.Sqrt(n));

            if (sqrt * (sqrt + 1) == n)
                return true;
            else
                return false;
        }

        static int CountPronic()
        {
            int A = 6;
            int B = 20;
            var counter = 0;
            for (int n = A; n <= B; n++)
            {
                if (IsPronicNo(n) == true)
                {
                    Console.Write("YES");
                    counter++;
                }
                else
                    Console.Write("NO");
            }

            return counter;
        }

        // Driver Code 
        public static void Main1()
        {
            //CountPronic();
            //GetStatbility();
            GetDeletionCost();
        }

        public static int GetDeletionCost()
        {
            var result = 0;
            //var S = "abccbd";
            //int[] c = { 0, 1, 2, 3, 4, 5 };
            var S = "aaaa";
            int[] C = { 3, 4, 5,6 };
            
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
