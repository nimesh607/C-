using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLProject
{
    internal class Class1
    {
        static void Print1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}; Print1 Method: {i}");
            }
        }
        static void Print2()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}; Print2 Method: {i}");
            }
        }
        static void Print3()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}; Print3 Method: {i}");
            }
        }

        static void Main()
        {
            //Thread is applying "Time Sharing " Principle
            Thread t1 = new Thread(Print1);
            Thread t2 = new Thread(Print2);
            Thread t3 = new Thread(Print3);
            t1.Start(); t2.Start(); t3.Start();
            t1.Join();t2.Join(); t3.Join();
        }
    }
}
