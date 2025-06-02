using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class ThreadPriority
    {
        static long Count1, Count2;
        static bool stop = false;
        public static void IncrementCount1()
        {
            while (!stop)
            {
                Count1 += 1;
            }
        }

              public static void IncrementCount2()
        {
            while (!stop)
            {
                Count2 += 1;
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(IncrementCount1);
            Thread t2 = new Thread(IncrementCount2);
            t1.Priority=System.Threading.ThreadPriority.Lowest;
            t2.Priority=System.Threading.ThreadPriority.Highest;
            t1.Start();
            t2.Start();
            Console.WriteLine("Main thread going to sleep");
            Thread.Sleep(10000);
            stop = true;
            //  t1.Abort();//Deprecated
            //t2.Abort();
            t1.Join();
            t2.Join();

            Console.WriteLine("Count1 :" + Count1);

            Console.WriteLine("Count2 :" + Count2);
        }
    }
}
