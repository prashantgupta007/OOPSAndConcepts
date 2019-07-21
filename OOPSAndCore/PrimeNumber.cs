using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPSAndCore
{
    /*
     *  A natural number (i.e. 1, 2, 3, 4, 5, 6, 7, ...) is called a prime number (or a prime) 
     *  if it has exactly two positive divisors (i.e. 1, 3, 5, 7, 11)
     *  1 and the number itself. 
     *  Natural numbers (i.e. 1, 2, 3, 4, 5, 6, 7, ...) greater than 1 that are not prime are called composite.
     *  
     *  A prime number (or a prime) is a natural number greater than 1 that has no positive divisors other than 1 and itself.
     *  A natural number greater than 1 that is not a prime number is called a composite number.
     */

    public class PrimeNumber
    {
        public static void Main1()
        {
            Console.Write("Please enter any no to check for Prime No: ");

            string input = Console.ReadLine();

            int inputNumber;
            if (int.TryParse(input, out inputNumber))
            {
                if (inputNumber > 1)
                {
                    if (CheckIfPrime(inputNumber))
                    {
                        Console.WriteLine("Given input is a prime no");
                    }
                    else
                        Console.WriteLine("Given input is not a prime no");
                }
                else
                    Console.WriteLine("Given input is not a prime no");
            }
            else
                Console.WriteLine("Given input was not a valid number");

            Console.ReadLine();
        }

        public static bool CheckIfPrime(int inputNumber)
        {
            bool result = true;
            for (int i = 2; i < inputNumber; i++)
            {
                if (inputNumber % i == 0)
                    result = false;
            }

            return result;
        }
    }
}
