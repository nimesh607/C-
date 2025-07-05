
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
        /*  static void Test() //this is signature is exactly matched  threadstart delegate (non value returning and doesnt accept any parameters)
          {
              for (int i = 0; i <= 50; i++)
              {
                  Console.WriteLine("Test : " + i);

              }
          }*/
        static void Test(object max)//this method signature is matching parameterisedThreadStart Delegate i.e.,non returning and accepting object type parameter
        {
            int num = Convert.ToInt32(max);//casted into int from obj
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("Test : " + i);

            }

        }

        static void Main(string[] args)
        {
            // Multiple ways to create threads in C#

            // 1️) Explicit delegate creation (non-parameterized):
            //ThreadStart is delegate .it is non value returning and no parameters 

            //ThreadStart obj = new ThreadStart(Test); // Instantiating and  binding  method with delegate , Works only if Test has no parameters.or you can also directly pass method without  creating delegate Internally CLR will create  instance of ThreadStart(Delegate) and pass method as a parameter. like this Thread  t = new Thread(Test).

            //Thread  t = new Thread(obj);//This is after delegate creation explicitly. 

            // 2️) Implicit delegate assignment:
            // ThreadStart obj = Test;

            // 3️) Anonymous delegate:
            // ThreadStart obj = delegate { Test(); };

            // 4️) Lambda expression:
            // ThreadStart obj = () => Test();
            // Thread thread = new Thread(obj); //or Thread t = new Thread(Test);
            //ParameterisedThreadStart obj will take object as a parameter
            ParameterizedThreadStart threadStart = new ParameterizedThreadStart(Test);
            Thread t = new Thread(threadStart);//there are four  constructor overloads are available under the Thread Class:
                                               //1)(ParameterisedThreadStart start) ,2)(ThreadStart start),3(ParameterisedThreadStart start,maxStackSize),4)(ThreadStart start,maxStackSize).

            t.Start(50);//Be carefull currently it is not type safe it can take any datatype and will runtime exception

            // NOTE: Since ParameterizedThreadStart takes 'object', there's a risk of passing incompatible types at runtime.
            // Consider using lambda with strongly typed variables if using .NET 4.0+ or switch to Tasks for better type safety.

        }
    }
}
