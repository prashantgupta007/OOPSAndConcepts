using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSAndCore.Org
{
    class Chubb
    {
        public static void Main1()
        {
            int[] myArray = { 4, 4, 13, 2, 3 };
            int[] sortedCopy = (from element in myArray orderby element ascending select element)
                   .ToArray();

            Console.ReadKey();
        }


        static int Minimum(int x = 2, int y = 4, int z = 3)
        {
            return Minimum(x, Minimum(y, z));
        }

        static void Main1(string[] args)
        {
            /*
             * Complete the missing code
             */
            Console.WriteLine(Minimum());

            Console.WriteLine(Minimum(8, 6, 10));


            Console.WriteLine(Minimum(8, 6));


            Console.WriteLine(Minimum(8, 10));

            Console.ReadKey();
        }
    }
}

//namespace Solution
//{
//    class Matrix
//    {
//        private int[,] mat = new int[5, 5];

//        /*
//         * Complete the missing code
//         */
//        public int this[int i, int j]
//        {
//            set
//            {
//                mat[i, j] = value;
//            }
//        }

//        public int Sum()
//        {
//            var sum = 0;
//            for (var i = 0; i < 5; i++)
//            {
//                for (var j = 0; j < 5; j++)
//                {
//                    sum += mat[i, j];
//                }
//            }

//            return sum;
//        }
//    }

//    class Solution
//    {
//        static void Main(string[] args)
//        {
//            Matrix m = new Matrix();

//            for (var i = 0; i < 5; i++)
//            {
//                for (var j = 0; j < 5; j++)
//                {
//                    m[i, j] = 2 * i + 3 * j;
//                }
//            }

//            Console.WriteLine(m.Sum());
//            Console.ReadKey();
//        }
//    }
//}