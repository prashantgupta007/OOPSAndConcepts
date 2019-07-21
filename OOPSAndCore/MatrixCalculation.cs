using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPSAndCore
{
    class MatrixCalculation
    {
        public static void Main1()
        {
            MatrixCalculation obj = new MatrixCalculation();

            obj.SumOfTwoArray();

            Console.ReadKey();
        }

        public void SumOfTwoArray()
        {
            // int[][] arr = new int[3][3];         // Compile time error  "Invalid rank specifier: expected ',' or ']"
            //int[][] arr = new int[3][];           // It is correct way of initialization but its not a 2-D arrays, It is Array of Array(i.e. Jagged Array)

            // Correct methods of 2-D  Array initialization
                                                                        // int[,] this type of arrays are called rectangler array 
            //int[,] arr = new int[3, 3];                               // Array declaration
            int[,] arr1 = { { 3, 4, 5 }, { 1, 3, 5 }, { 4, 8, 9 } };    // Array declaration with initialization
            int[,] arr2 = { { 9, 3, 2 }, { 4, 3, 7 }, { 1, 0, 5 } };
            int[,] newArr = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    newArr[i, j] = arr1[i, j] + arr2[j, i];
                }
            }
        }
    }
}
