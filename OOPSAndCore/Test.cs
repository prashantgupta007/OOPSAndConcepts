using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSAndCore
{
    public class Dell
    {
        public static void Main1(string[] args)
        {
            int[] items = { 1, 0, 1, 0, 1, 1 };
            int[] items1 = { 0, 1, 1, 0, 1, 1 };
            int[] items2 = { 1, 0, 0, 0, 0, 1, 1 };

            //output = input[1, 1, 1, 1, 0, 0];

            var result = SortArray(items2);
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }

            Console.Read();
        }


        static int[] SortArray(int[] items)
        {
            var lastZeroItemIndex = 0;
            var isLastItemZero = false;

            for (int i = 0; i < items.Length; i++)
            {
                if (isLastItemZero && items[i] == 1)
                {
                    items[lastZeroItemIndex] = 1;
                    items[i] = 0;
                    isLastItemZero = false;
                }

                if (!isLastItemZero && items[i] == 0)
                {
                    lastZeroItemIndex = i;
                    isLastItemZero = true;
                }
            }

            return items;
        }
        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        double a = 5.0;
        //        double b = 3.0;
        //        double i = Math.Pow(a, b);
        //        Console.WriteLine(i);
        //        Console.ReadLine();
        //    }
        //}
        //class TestHack
        //{
        //    char val = 'X';
        //    public IEnumerator GetEnumerator()
        //    {
        //        for (int j = 20; j >= 0; --j){
        //            if (j == 10) yield break;
        //            yield return (char)((val + j));
        //        }
        //    }

        //    class Program
        //    {
        //        static void Main(string[] args)
        //        {
        //            TestHack th = new TestHack();
        //            foreach (char val in th)
        //                Console.Write(val + " ");
        //            Console.WriteLine();
        //            Console.ReadLine();
        //        }
        //    }
        //}
    }
}
