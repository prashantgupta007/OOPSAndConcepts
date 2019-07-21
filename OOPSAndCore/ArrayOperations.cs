using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPSAndCore
{
    class ArrayOperations
    {
        int[] a = { 5, 7, 8, 10, 6, 1, 8, 31, 43, 21 };

        public static void Main1()
        {
            ArrayOperations objArrayOperations = new ArrayOperations();

            int[] testArray = { 10, 15, 4, 10, 3, 6, 9, 10, 4, 3, 9 };
            objArrayOperations.Top3RepeatedNo(testArray);
            //objArrayOperations.Top3RepeatedNo(new int[] { 10, 15, 4, 10, 3, 6, 10, 4, 3, 9});  // It is also correct

            Console.ReadKey();
        }


        public void Top3RepeatedNo(int[] inputArray)
        {
            //int[] testArray = { 10, 15, 4, 10, 3, 6, 10, 4, 3, 9 };
            int[] top3Nos = new int[3];

            if (inputArray.Length > 0)
            {
                int counter = 0;

                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (counter < 3)
                    {
                        for (int j = 0; j < inputArray.Length; j++)
                        {
                            if ((inputArray[i] == inputArray[j]) && (i != j))
                            {
                                if (i < j)
                                {
                                    top3Nos[counter] = inputArray[i];
                                    counter++;
                                }
                                break;
                            }
                            //if ((inputArray[i] == inputArray[j]) && (i < j))  // check this one code also
                            //{
                            //        top3Nos[counter] = inputArray[i];
                            //        counter++;
                            //    
                            //    break;
                            //}
                        }
                    }
                    else
                        break;
                }

                Console.Write("Top 3 repeated nos are:");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(" " + top3Nos[i]);
                }
            }
        }
    }
}
