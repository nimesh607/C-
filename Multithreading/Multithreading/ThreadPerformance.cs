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
            for (long i = 0; i <= 10000000000; i++)
            {
                Count++;
            }
            Console.WriteLine("Increment Count1 : "+ Count);
        }

        public static void IncrementCount2()
        {
            long Count = 0;
            for (long i = 0; i <= 10000000000; i++)
            {
                Count++;
            }
            Console.WriteLine("Increment Count2 : "+ Count);
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(IncrementCount1);
            Thread t2 = new Thread(IncrementCount2);    
            Stopwatch sw =  new Stopwatch();    
            Stopwatch sw2 = new Stopwatch();

          
            sw.Start();
            IncrementCount1();// using single thread
            IncrementCount2();
           sw.Stop();

            sw2.Start();
            t1.Start();
            t2.Start();
            sw2.Stop();
            t1.Join();
            t2.Join();

            Console.WriteLine("Time taken to complete sw : "+sw.ElapsedMilliseconds);
            Console.WriteLine("Time taken to complete sw2 : "+sw2.ElapsedMilliseconds);
        }
    }
}
