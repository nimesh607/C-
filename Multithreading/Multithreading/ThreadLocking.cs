using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class ThreadLocking
    {
        // Method that will be accessed by multiple threads
        public void Display()
        {
            // lock(this): Ensures only one thread at a time can enter this block for the same object instance
            lock (this)// Mutual exclusion: prevents race conditions
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
            // Threads will execute Display() one after the other due to locking
            // Without lock, output would overlap and become inconsistent

        }
    }
}
