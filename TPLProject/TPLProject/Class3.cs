using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLProject
{
    internal class Class3
    {
        static int GetLength()//value returning without parameters
        {
            string str = "";
            for (int i = 1; i <= 100000; i++)
            {
                str += i;
            }
            return str.Length;
        }
        static string ToUpper()
        {
            string str = "Hello World";
            return str.ToUpper();
        }

        static void Main()
        {
            //Calling value returning methods with-out parameters by using Tasks
           
            /*Task<int> t1 = new Task<int>(GetLength);
            Task<int> t2 = new Task<int>(ToUpper);
            t1.Start();
            t2.Start();*/

            //Alternative way 
            Task<int> t1 = Task.Factory.StartNew(GetLength);
            Task<string> t2 = Task.Factory.StartNew(ToUpper);
            int result1= t1.Result;//Result is obtained after the method execution.so result will call wait internally.
            string result2 = t2.Result;
            Console.WriteLine("Result1 : "+result1);
            Console.WriteLine("Result2 : "+result2);
            Console.WriteLine("Main thread is exiting");
        }
    }
}
