using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOPSAndCore
{
    public class MultithreadingTest
    {
        static void Main1()
        {
            AsyncAwait.TestAsyncAwaitMethods();
            AsyncAwait.TestAsyncAwaitMethods();
            //AsyncAwait.MyMethodAsync(); // It'll give an error as it's Task kind of method, So, it'll be loking for await keyword
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }



    public class AsyncAwait
    {
        public static int Counter = 0;
        public static async void TestAsyncAwaitMethods()
        {
            Counter++;
            await LongRunningOperationAsync(Counter);
        }

        public static async Task<int> LongRunningOperationAsync(int counter) // assume we return an int from this long running operation 
        {
            Console.WriteLine("Starting Long Running method... & Counter:" + counter);
            await Task.Delay(5000);
            Console.WriteLine("End Long Running method... & Counter:" + counter);
            return 1;
        }

        public static async Task MyMethodAsync(int counter)
        {
            Task<int> longRunningTask = LongRunningOperationAsync(counter);
            // independent work which doesn't need the result of LongRunningOperationAsync can be done here

            //and now we call await on the task 
            var result = await longRunningTask;
            //use the result 
            Console.WriteLine(result);
        }

        //public Task<int> Tasktest()
        //{
        //    var a = 5 + 6;

        //    Task.Run(() =>
        //    {
        //        Console.WriteLine("");
        //        return a;
        //    });
        //}

        public async void AsyncTest()
        {
            await Task.Run(() =>
            {


            });
        }
    }
}
