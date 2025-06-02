using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class Test1
    {
        static void Test()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test 1  : " + i);

            }
            Console.WriteLine("Thread 1 is exiting");
        }

        static void Test2()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test 2  : " + i);
                if (i == 50)
                {
                    Console.WriteLine("Thread 2 is going to sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("Thread 2 is woke up");
                }
                 
            }
            Console.WriteLine("Thread 2 is exiting");
        }

        static void Test3()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test 3  : " + i);

            }
            Console.WriteLine("Thread 3 is exiting");
        }

        static void Main(string[] args)
        {
            Thread T1 = new Thread(Test);
            Thread T2 = new Thread(Test2);
            Thread T3 = new Thread(Test3);
            T1.Start();
            T2.Start();
            T3.Start();

            Console.WriteLine("Thread Main is exiting");
        }
    }
}
