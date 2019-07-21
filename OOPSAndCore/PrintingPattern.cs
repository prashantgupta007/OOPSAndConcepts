using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPSAndCore
{
    class PrintingPattern
    {
        public static void Main1()
        {
            PrintingPattern obj = new PrintingPattern();

            //obj.PrintStarPyramid(0);
            //obj.PrintInvertedStarPyramid(0);
            //obj.PrintEmptyInvertedStarPyramid(0);
            //obj.PrintNumberPyramid(0);
            obj.PrintSteps();
            obj.PrintInvertedSteps();

            Console.ReadKey();
        }

        private void PrintStarPyramid(int maxNo)
        {
            Console.Write("Please enter any no: ");
            maxNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nUsing First Method: ");
            for (int i = 1; i <= maxNo; i++)
            {
                int j;
                for (j = maxNo - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                for (j = i - 1; j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nUsing Second Method: ");
            int k = maxNo;
            for (int i = 1; i <= maxNo; i++)
            {
                int j;
                for (j = maxNo - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i + (maxNo - k); j++)
                {
                    Console.Write("*");
                }
                k--;

                Console.WriteLine();
            }
        }

        private void PrintInvertedStarPyramid(int maxNo)
        {
            Console.Write("\n---------------------------------\n");
            Console.Write("Please enter any no: ");
            maxNo = Convert.ToInt32(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int k = 0; k < maxNo; k++)
            {
                if (k < maxNo / 2 + 1)
                {
                    for (int l = 0; l <= k; l++)
                    {
                        sb.Append("*");
                    }
                    sb.Append("\n");
                }
                if (k >= maxNo / 2)
                {
                    for (int l = maxNo - k; l >= 2; l--)
                    {
                        sb.Append("*");
                    }
                    sb.Append("*");
                    sb.Append("\n");
                }
            }
            Console.WriteLine(sb);
        }

        private void PrintEmptyInvertedStarPyramid(int maxNo)
        {
            Console.Write("\n---------------------------------\n");
            Console.Write("Please enter any no: ");
            maxNo = Convert.ToInt32(Console.ReadLine());
            StringBuilder sb1 = new StringBuilder();
            for (int k = 0; k < maxNo; k++)
            {
                if (k < maxNo / 2 + 1)
                {
                    for (int l = 0; l <= k - 1; l++)
                    {
                        sb1.Append(" ");
                    }
                    sb1.Append("*\n");
                }
                if (k > maxNo / 2)
                {
                    for (int l = maxNo - k; l >= 2; l--)
                    {
                        sb1.Append(" ");
                    }
                    sb1.Append("*\n");
                }
            }
            Console.WriteLine(sb1);
        }

        private void PrintNumberPyramid(int maxNo)
        {
            Console.Write("\n---------------------------------\n");
            Console.Write("Please enter any no: ");
            maxNo = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= maxNo; i++)
            {
                int j;
                for (j = maxNo; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for (j = i - 1; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        private void PrintSteps()
        {
            Console.WriteLine("---------------------------");

            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        private void PrintInvertedSteps()
        {
            Console.WriteLine("---------------------------");

            for (int i = 5; i >= 1; i--)
            {
                int j = 1;
                for (j = j; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (j = j; j <= 5; j++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }
    }
}
