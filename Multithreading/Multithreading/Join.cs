using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class Join
    {
        static void Test1()
        {
            Console.WriteLine("Thread1 is Starting");
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Thread1: " + i);
               

            }
            Thread.Sleep(5000);//Here after exiting Thread 1 ,Main thread will exits
            Console.WriteLine("Thread1 is Exiting");
        }
        static void Test2()
        {
            Console.WriteLine("Thread2 is Starting");
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Thread2 :"+i);
            }
            Console.WriteLine("Thread2 is Exiting");
        }
        static void Test3()
        {
            Console.WriteLine("Thread3 is Starting");
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Thread3 :"+i);

            }
            Console.WriteLine("Thread3 is exiting");
        }
        static void Main(string[] args)
        {
            /*
             * Here in this snippet  Main thread will start  and will not wait untill all thread are exited it will exited in middle .its purpose is to create child thread after completing its work it will exited right away.
             * In this problem is Main thread should not be exited before all child threads exit .So i will use Join so main thread will not exited in the middle .Main thread will wait untill all child threads are executed 
             * Console.WriteLine("Main Thread Started");
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start();t2.Start();t3.Start();
            Console.WriteLine("Main Thread is Exiting");*/

            Console.WriteLine("Main Thread Started");
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start(); t2.Start(); t3.Start();
            t1.Join(3000);t2.Join();t3.Join();//the calling thread  cannot exit from the program untill child threads are exiting from the program.But if are giving time than main thread will wait for that time and will exits even child thread are exits or not 
            Console.WriteLine("Main Thread is Exiting");    
        }
    }
}
