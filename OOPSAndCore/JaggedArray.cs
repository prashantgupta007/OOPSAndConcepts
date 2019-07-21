using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPSAndCore
{
    class JaggedArray
    {
        static void Main1()
        {
            // Declare local jagged array with 3 rows.
            pax[][] jagged = new pax[4][];


            // Create a new array in the jagged array, and assign it.
            jagged[0] = new pax[1];
            pax objPax = new pax();
            objPax.paxtype = "Adult";
            jagged[0][0] = objPax;

            // Set second row
            jagged[1] = new pax[1];
            objPax = new pax();
            objPax.paxtype = "Adult";
            jagged[1][0] = objPax;

            // Set third row
            jagged[2] = new pax[1];
            objPax = new pax();
            objPax.paxtype = "Adult";
            jagged[2][0] = objPax;

            // Set fourth row
            jagged[3] = new pax[1];
            objPax = new pax();
            objPax.paxtype = "Child";
            objPax.age = 8;
            jagged[3][0] = objPax;


            // Print out all elements in the jagged array.
            for (int i = 0; i < jagged.Length; i++)
            {
                pax[] innerArray = jagged[i];

                for (int a = 0; a < innerArray.Length; a++)
                {
                    Console.Write("[{paxType:" + innerArray[a].paxtype + (innerArray[a].age != null ? ", age: " + innerArray[a].age  : "") + "}]" );
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

    public class pax
    {
        public string paxtype { get; set; }
        public int? age { get; set; }
    }
}
