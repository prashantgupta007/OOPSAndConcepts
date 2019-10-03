using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPSAndCore
{
    class DelegateTest
    {
        public delegate int DelegateMethod(int n1, int n2);

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public static void Main1()
        {
            DelegateTest objDelegateTest = new DelegateTest();
            DelegateMethod obj = new DelegateMethod(objDelegateTest.Sum);   // It is Singlecast delegate
            int result = obj(5, 10);
            Console.WriteLine("Sum is:" + result);
            result = obj(5, 5);
            Console.WriteLine("Sum is:" + result);

            //obj = new DelegateMethod(objDelegateTest.Sub);                // It is Singlecast delegate
            obj += new DelegateMethod(objDelegateTest.Sub);                 // It is Mullticast Delegates i.e. adding more than one functions to one delegate object
            result = obj(5, 10);
            Console.WriteLine("Sub is:" + result);
            Console.ReadKey();
        }
    }
}
