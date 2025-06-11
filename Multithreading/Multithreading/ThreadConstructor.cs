using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Multithreading
{
    internal class ThreadConstructor
    {
        static void Test(object max)
        {
            int num = Convert.ToInt32(max);
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("Test : " + i);

            }
            
        }

        static void Main(string[] args)
        {
            // Multiple ways to create threads in C#

            // 1️) Explicit delegate creation (non-parameterized):
           //  ThreadStart obj = new ThreadStart(Test); // Works only if Test has no parameters

            // 2️) Implicit delegate assignment:
            // ThreadStart obj = Test;

            // 3️) Anonymous delegate:
            // ThreadStart obj = delegate { Test(); };

            // 4️) Lambda expression:
            // ThreadStart obj = () => Test();
            // Thread thread = new Thread(obj); //or Thread t = new Thread(Test);
            //ParameterisedThreadStart obj will take object as a parameter
            ParameterizedThreadStart threadStart = new ParameterizedThreadStart(Test);
            Thread t = new Thread(threadStart);
            t.Start(50);//Be carefull currently it is not type safe it can take any datatype and will runtime exception

            // NOTE: Since ParameterizedThreadStart takes 'object', there's a risk of passing incompatible types at runtime.
            // Consider using lambda with strongly typed variables if using .NET 4.0+ or switch to Tasks for better type safety.

        }
    }
}
