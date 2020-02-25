using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSAndCore
{
    public class CommonTest
    {
        private static int Multiply(int firstNumber, int secondNumber)
        {
            int value;

            value = firstNumber * secondNumber;

            return value;
        }

        static void Calculate()
        {
            Console.WriteLine(Multiply(2, 5));
        }

        static void Main1(string[] args)
        {
            try
            {
                Calculate();
            }
            catch
            {
                Console.WriteLine("Something is wrong here!");
            }

            Console.ReadKey();
        }
    }


}
