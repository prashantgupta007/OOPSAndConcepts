using System;
using System.Linq;

namespace OOPSAndCore
{
    class CandyDistribution
    {
        public static void Main1()
        {
            //int[] ratings = { 1, 0, 2 };
            //int[] ratings = { 1, 2, 2 };
            //int[] ratings = { 1, 3, 2, 2, 1 };
            int[] ratings = { 1, 3, 2, 1 };


            int totalCandies = Candy(ratings);

            Console.WriteLine("Total no of candies = " + totalCandies);
            Console.ReadKey();
        }

        static int Candy(int[] ratings)
        {
            int n = ratings.Length;
            if (n == 1)
                return 1;

            int[] candies = new int[n];

            for (int i = 0; i < ratings.Length; i++)
            {
                candies[i] = 1;
            }

            // Scan from left to right, make sure each child with a higher rating gets more candies than the left neighbor.
            for (int i = 1; i < n; i++)
            {
                if (ratings[i] > ratings[i - 1])
                {
                    candies[i] = candies[i - 1] + 1;
                }
            }

            // Scan from right to left, make sure each child with a higher rating gets more candies than the right neighbor.
            for (int i = n - 2; i >= 0; i--)
            {
                if (ratings[i] > ratings[i + 1])
                {
                    candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
                }
            }

            Console.WriteLine("Input Array = [{0}]", string.Join(", ", ratings));
            Console.WriteLine("Candies = [{0}]", string.Join(", ", candies));

            //if (ratings[ratings.Length - 2] < ratings[ratings.Length - 1])
            //{
            //    candies[ratings.Length - 1] = candies[ratings.Length - 1] + 1;
            //}

            //if (ratings[0] < ratings[1])
            //{
            //    candies[1] = candies[1] + 1;
            //}

            return candies.Sum();
        }
    }
}
