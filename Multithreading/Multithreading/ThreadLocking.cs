using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class ThreadLocking
    {
        public void Display()
        {
            lock (this)//Only one thread can acccess method at a time after completing execution than second thread will acess.
            {
                Console.Write("CSharp is an ");
                Thread.Sleep(5000);
                Console.WriteLine("Object Oriented Language");
            }
        }

        static void Main(string[] args)
        {
            ThreadLocking obj = new ThreadLocking();
            //obj.Display();
            //obj.Display();
            //obj.Display();
            Thread t1 =new Thread(obj.Display);
            Thread t2 =new Thread(obj.Display);
            Thread t3 =new Thread(obj.Display);
            //Multiple threads acessing same Method

            t1.Start();
            t2.Start();
            t3.Start();
           
                
        }
    }
}
