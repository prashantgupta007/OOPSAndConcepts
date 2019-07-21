using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPSAndCore
{
    public class SortingTest
    {
        static void Main1(string[] args)
        {
            int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9 };

            SortingTest sorting = new SortingTest();
            //sorting.BubbleSort(arr);
            sorting.QuickSort(arr, 0, arr.Length - 1);
        }

        private void BubbleSort(int[] arr)
        {
            int temp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        //Swapping
                        //temp = arr[sort + 1];
                        //arr[sort + 1] = arr[sort];
                        //arr[sort] = temp;
                        //Swapping
                        Exchange(arr, sort + 1, sort);
                    }
                }
            }

            string sortedArray = string.Empty;

            for (int i = 0; i < arr.Length; i++)
            {
                sortedArray += arr[i] + " ";
            }

            Console.Write("Sorted Array using Bubble Sort is: " + sortedArray);

            Console.ReadKey();
        }

        //O(nlogn) 
        private void QuickSort(int[] array, int init, int end)
        {
            if (init < end)
            {
                int pivot = Partition(array, init, end);
                QuickSort(array, init, pivot - 1);
                QuickSort(array, pivot + 1, end);
            }
        }

        //O(n)
        private int Partition(int[] array, int init, int end)
        {
            int last = array[end];
            int i = init - 1;
            for (int j = init; j < end; j++)
            {
                if (array[j] <= last)
                {
                    i++;
                    Exchange(array, i, j);
                }
            }
            Exchange(array, i + 1, end);
            return i + 1;
        }

        private void Exchange(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
