using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLProject
{
    internal class Class5
    {
        static void GetLength(int ub)//value returning , parameterised
        {
            string str = "";
            for (int i = 1; i <= ub; i++)
            {
                str += i;
            }
            Console.WriteLine(str.Length);
        }
        static void ToUpper(string str)
        {
            str = str.ToUpper();
            Console.WriteLine(str);
            
        }

        static void Main(string[] args)
        {
            //Remember value returning Generic Task<> if noon value returning NonGeneric Task Class to use .and we dont require to call delegates using Task
            Task t1= new Task(()=>GetLength(75000));
            Task t2 = new Task(() => ToUpper("Hello"));

            t1.Start();t2.Start();
            
            Console.WriteLine("Thread Main is Exiting");

            //Now here output will only "Thread Main is Exiting" because main do not have any work to do because  after creating instance of t1 and t2 will do their work but main does not have anything to do.Consedering this scenario once main exits in task parellism all threads will also exits.so to avoid this it is mandatorily to call "Wait" .if you call "Result" than no need to call wait 
        }
    }
}
