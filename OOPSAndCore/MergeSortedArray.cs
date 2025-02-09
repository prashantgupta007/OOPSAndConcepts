using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSAndCore
{
    public class MergeSortedArray
    {
        public void Main()
        {

        }


        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            Array.Copy(nums2, 0, nums2, m, n);
            Array.Sort(nums1);
        }
    }
}
