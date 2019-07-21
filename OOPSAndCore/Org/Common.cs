using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPSAndCore
{
    class Common
    {
        public static void Main1()
        {
            int i = 5;                               // Fiserv: from below 3, Which one is best way for converting an int into string
            //Int32 i = 5;                           // this and above lines are some
            String s = Convert.ToString(i); // or    // It is only Correct One
            //string s = (string)i;		    // or    // Compile time error "Cannot convert type 'int' to 'string'"
            //string s = i as string;                // Compile time error "Cannot convert type 'int' to 'string' via a reference conversion, boxing conversion, unboxing conversion etc."

            Common obj = new Common();
            obj.SwapNo(0);

            Console.ReadKey();

        }

        private void SwapNo(int firstNo, int secondNo = 0)
        {
            Console.Write("Please Enter First No to Swap: ");
            firstNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter Second No to Swap: ");
            secondNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nBefore Swapping");
            Console.WriteLine("First No is: " + firstNo);    // 10
            Console.WriteLine("Second No is: " + secondNo);  // 5

            //secondNo = (firstNo + secondNo) - (firstNo = secondNo);
            firstNo = firstNo + secondNo;   //(10 + 5 => 15)
            secondNo = firstNo - secondNo;  //(15 - 5 => 10)
            firstNo = firstNo - secondNo;   //(15 - 10 => 5)

            Console.WriteLine("\nAfter Swapping");
            Console.WriteLine("First No is: " + firstNo);
            Console.WriteLine("Second No is: " + secondNo);
        }
    }
}
