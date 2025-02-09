using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSAndCore
{
    // Identify the min step to start from given jumps to climb a grashopper on stairs having said that the first step should be numbered as 1, second as 2 and so on.
    // Also insure that the step number can never be in negative during the each forword and backword jump
    public class MinStepToClimbSteps
    {
        public static void Main()
        {
            //int[] jumps = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int[] jumps = { 1, -4, -3, 2 };

            Console.WriteLine("Current jumps array: " + string.Join(", ", jumps));
            Console.WriteLine("Minimun step to start jump:" + MinStep(jumps));
            Console.ReadKey();
        }


        // Need to solve
        public static int MinStep(int[] jumps)
        {
            int minStep = 1;
            int currentStep = 1;

            foreach (int jump in jumps)
            {
                currentStep = currentStep + jump;

                if (currentStep < 1)
                {
                    minStep = minStep - currentStep;
                }
            }

            return minStep;
        }
    }
}
