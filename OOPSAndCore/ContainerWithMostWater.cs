using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSAndCore
{
    //https://leetcode.com/problems/container-with-most-water/solutions/5957753/container-with-most-water-in-c/?envType=study-plan-v2&envId=leetcode-75
    public class ContainerWithMostWater
    {
        public static void Main1()
        {
            int[] heights = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            //int[] heights = { 1, 1 };

            Console.WriteLine("Current heights array: " + string.Join(", ", heights));
            Console.WriteLine("Max Area:" + MaxArea(heights));
            Console.ReadKey();
        }

        public static int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;

            int maxArea = 0;

            while (left < right)
            {
                int currentArea = Math.Min(height[left], height[right]) * (right -left);
                maxArea = Math.Max(maxArea, currentArea);

                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }

            return maxArea;
        }
    }


}
