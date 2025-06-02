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
           // ThreadStart obj = new ThreadStart(Test);//explicitly instantiating delegate in Test1 we directly pass the methos and CLR will implicitly instantiate delegate and bound the method with delegate .
                                                    //2nd way instanting method with delegate 
                                                    // ThreadStart obj1 = Test
                                                    // 3rd way 
           // ThreadStart obj = delegate { Test(); };
           //4th way
            //ThreadStart obj= () => Test();
           // Thread thread = new Thread(obj); //or Thread t = new Thread(Test);
           //ParameterisedThreadStart obj will take object as a parameter
           ParameterizedThreadStart threadStart = new ParameterizedThreadStart(Test);
            Thread t = new Thread(threadStart);
            t.Start(50);//Be carefull currently it is not type safe it can take any datatype and will runtime exception
            
            
        }
    }
}
