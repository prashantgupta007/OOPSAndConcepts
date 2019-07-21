using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPSAndCore
{
    public class Iris
    {
        public static void Main1()
        {
            try
            {
                //Capture max no of cosecutive numbers list as input from user
                Console.Write("Please enter the max number of consecutive numbers list of your choice, which should be greater than 2: ");

                int maxNumber = Convert.ToInt32(Console.ReadLine());

                //Check if the user input is less than 2
                if (maxNumber < 2)
                {
                    Console.WriteLine("Number should be greater than 1!");

                    //Recapture max number of cosecutive numbers list as input from user
                    Console.Write("Please enter again the max number of consecutive numbers list of your choice, which will be greater than 2: ");
                    maxNumber = Convert.ToInt32(Console.ReadLine());
                }

                //Get and set the list of n consecutive numbers started from 2
                List<int> consecutiveNumbersList = CreateConsecutiveNumbersList(maxNumber);

                //Declare a new list for storing prime numbers
                List<int> primeNumbersList = new List<int>();
                //Add 2 as first prime no
                primeNumbersList.Add(2);

                //Strike off all multiples of 2 from the list of consecutive numbers and set them to the remainNumbersList collection
                List<int> remainNumbersList = StrikeOffDividedNumbers(consecutiveNumbersList, 2);

                //Repeat the remainNumbersList list until no number is left in the remainNumbersList list
                while (remainNumbersList.Count > 0)
                {
                    //Get & set the first no of the list
                    int firstNo = remainNumbersList.First();

                    //Add first value of remain numbers list, which is prime no, to the list of prime numbers
                    primeNumbersList.Add(firstNo);

                    //Get & set list of those numbers which can't be devided by its, i.e. list's, first number
                    remainNumbersList = StrikeOffDividedNumbers(remainNumbersList, firstNo);
                }

                //Print all prime numbers to user console
                StringBuilder sb = new StringBuilder();
                foreach (int primeNo in primeNumbersList)
                    sb.Append(primeNo + ", ");
                sb.Remove(sb.ToString().LastIndexOf(","), 2);

                Console.WriteLine("List of prime numbers between the range of 2 - {0} are: {1}.", maxNumber, sb.ToString());
            }
            catch (FormatException ex) // Handle exception for invalid input
            {
                Console.WriteLine("Please enter only numeric values!");
            }
            catch // Handle all other unknown exception
            {
                Console.WriteLine("Some unknown error occured, please try again!");
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Create a list of consecutive numbers of any length started from 2
        /// </summary>
        /// <param name="maxNumber">Max number of the consecutive numbers list</param>
        /// <returns>A List of n consecutive numbers started from 2</returns>
        public static List<int> CreateConsecutiveNumbersList(int maxNumber)
        {
            //Declare a list of integer type
            List<int> consecutiveNumbersList = new List<int>();

            //Add numbers to list in ascending order
            for (int i = 2; i <= maxNumber; i++)
                consecutiveNumbersList.Add(i);

            return consecutiveNumbersList;
        }

        /// <summary>
        /// Strike off all divided numbers by first number of a list of n numbers
        /// </summary>
        /// <param name="numbersList">List of all numbers</param>
        /// <param name="firstNumber">first number of the passing numbers list</param>
        /// <returns>A list of numbers whose were not divided by its min/first number</returns>
        public static List<int> StrikeOffDividedNumbers(List<int> numbersList, int firstNumber)
        {
            //Declare a list for storing unstriked elements
            List<int> newNumbersList = new List<int>();

            //Strike off all divided numbers
            foreach (int number in numbersList)
            {
                //Check if the no is not divisible by firstNumber then add it to newNumbersList collection
                if (number % firstNumber != 0)
                    newNumbersList.Add(number);
            }
            return newNumbersList;
        }
    }
}


#region Test Objective
//1. Write a list of consecutive integers from 2 to the largest number (100) you want to test for primality
//2. 2 is the first prime number
//3. Strike off all multiples of 2 from the list
//4. The next un-struck number in the list is a prime number. Strike off all multiples of this number from the first list
//5. Repeat step 4 until no more numbers are left
//6. All the unmarked numbers are primes
#endregion