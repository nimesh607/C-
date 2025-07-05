using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLProject
{
    internal class Class4
    {
        static int GetLength(int ub)//value returning , parameterised
        {
            string str = "";
            for (int i = 1; i <= ub; i++)
            {
                str += i;
            }
            return str.Length;
        }
        static string ToUpper(string str)
        {
            
            return str.ToUpper();
        }
        static void Main(string[] args)
        {
          /*  Task<int> t1 = new Task<int>(()=>GetLength(50000));//Passing parameters to method
            Task<string> t2 = new Task<string>(() => ToUpper("Hello"));
            
            t1.Start();
            t2.Start();*/

            Task<int> t1 = Task.Factory.StartNew(() => GetLength(50000));
            Task<string> t2 = Task.Factory.StartNew(()=>ToUpper("Hello"));

            int result=t1.Result;
            string result2 = t2.Result;

            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine("Thread main exiting");

        }
    }
}
