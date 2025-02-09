using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSAndCore.Org
{
    public class BiValue
    {

        public static void Main1()
        {
            var a = FindMaxBiValueSlice();

        }

        //get longet bi-value
        public static int FindMaxBiValueSlice()
        {
            //int[] A = { 4, 5, 5, 4, 5 };
            //int[] A = { 1, 5, 4, 5 };
            //int[] A = { 4, 2, 2, 4, 2 };
            //int[] A = { 1, 2, 3, 2 };
            //int[] A = { 0, 5, 4, 4, 5, 12 };
            int[] A = { 4, 4 };

            if (A.Length < 2)
            {
                return 0;
            }

            int[] arr = { A[0], A[1] };

            var maxSlice = 2;
            var counter = 2;

            for (int i = 2; i < A.Length; i++)
            {
                if (Array.IndexOf(arr, A[i]) < 0)
                {
                    if (counter > maxSlice)
                    {
                        maxSlice = counter;
                    }
                    counter = 1;

                    var temp = arr[1];
                    arr[1] = A[i];
                    arr[0] = temp;
                }
                counter++;
            }

            if (counter > maxSlice)
            {
                maxSlice = counter;
            }
            return maxSlice;
        }


        //http://www.cplusplus.com/forum/beginner/246604/
        //https://www.chegg.com/homework-help/questions-and-answers/james-businessman-tight-schedule-week-week-starts-monday-00-00-ends-sunday-24-00-schedule--q32522439
        public static int FindTimeInterval(string S)
        {
            if (S.Length == 0)
            {
                return 0;
            }
            var meetings = S.Split(new[] { "\n" }, StringSplitOptions.None);
            if (meetings.Length == 0)
            {
                return 0;
            }

            string[] days = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };


            foreach (var day in days)
            {
                var meeting = meetings.Where(m => m.Contains(day));
            }

            var result = 0;
            return result;
        }

        public class Interval
        {
            public String Day { get; set; }
            public DateTime Start { get; set; }
            public DateTime End { get; set; }
        }



    }


}
