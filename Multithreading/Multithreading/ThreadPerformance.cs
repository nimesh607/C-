using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Multithreading
{
    internal class ThreadPerformance
    {
        public  static void IncrementCount1()
        {
            long Count = 0;
            for (long i = 0; i <= 10000000; i++)
            {
                Count++;
            }
            Console.WriteLine("Increment Count1 : "+ Count);
        }

        public static void IncrementCount2()
        {
            long Count = 0;
            for (long i = 0; i <= 10000000; i++)
            {
                Count++;
            }
            Console.WriteLine("Increment Count2 : "+ Count);
        }

        static void Main(string[] args)
        {
            // Create two threads that point to the respective methods
            Thread t1 = new Thread(IncrementCount1);
            Thread t2 = new Thread(IncrementCount2);
            // Stopwatch to measure single-threaded execution time
            Stopwatch sw =  new Stopwatch();
            // Stopwatch to measure multi-threaded execution time
            Stopwatch sw2 = new Stopwatch();

            // Start stopwatch and run methods sequentially (single-threaded)
            sw.Start();
            IncrementCount1();// Executes on main thread(Single Thread)
            IncrementCount2(); // Executes after Count1 completes
            sw.Stop(); // Stop after both methods complete

            // Start second stopwatch and start both threads
            sw2.Start(); // Start the stopwatch to measure multi-threaded execution time

            t1.Start(); // Executes IncrementCount1 on a separate thread
            t2.Start();// Executes IncrementCount2 on another thread
            t1.Join();  // Wait for Thread 1 to complete before moving on
            t2.Join();    // Wait for Thread 2 to complete before stopping the stopwatch


            sw2.Stop();// Stop the stopwatch after both threads have finished execution

            Console.WriteLine("Time taken to complete sw : "+sw.ElapsedMilliseconds);
            Console.WriteLine("Time taken to complete sw2 : "+sw2.ElapsedMilliseconds);
        }
    }
}
