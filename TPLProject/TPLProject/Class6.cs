using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLProject
{
    internal class Class6
    {

        /*
     * -------------------------------
     * Thread Synchronization in C#
     * -------------------------------
     * When working with multithreaded applications, multiple threads may try to access shared resources (e.g., variables, files).
     * If this access is not managed properly, it can lead to race conditions, inconsistent data, or application crashes.
     *
     * Synchronization ensures that only one thread can access a critical section of code at a time.
     * This is especially important for sensitive operations like banking transactions (deposit, withdraw).
     *
     * The 'lock' statement in C# is used to achieve synchronization.
     * It allows only one thread at a time to execute the locked section.
     */


        /*  public static void Print()
          {
              Console.Write("[CSharp Is ");
              Console.WriteLine("Object Oriented]");
          }

          static void Main()
          {
              Thread t1 = new Thread(Print);
              Thread t2 = new Thread(Print);
              Thread t3 = new Thread(Print);
              t1.Start(); t2.Start(); t3.Start();
              t1.Join(); t2.Join(); t3.Join();
          }*/

        /*
         * When you execute the above code we get un-expected results most of the time because the 3 Threads we
   have created are interrupting each other. We can use C# lock keyword to execute program synchronously. It is
   used to get lock for the current thread, execute the task and then release the lock. It ensures that other thread
   does not interrupt the execution until the execution finish. To resolve the problem re-write the Print() method.

         */

        public static void Print()
        {
            // Locking on the type ensures all threads respect the same lock object
            lock (typeof(Class6))
            {
                Console.Write("[CSharp Is ");
                Console.WriteLine("Object Oriented]");
            }
        }

        static void Main()
        {
            // Option 1: Creating and starting tasks individually (commented out for reference)
            /*  Task t1 = new Task(Print);
              Task t2 = new Task(Print);
              Task t3 = new Task(Print);
              t1.Start(); t2.Start(); t3.Start();
              t1.Wait(); t2.Wait(); t3.Wait();*/

            // Option 2 (recommended): Creating and starting tasks using Task.Factory
            Task t1 = Task.Factory.StartNew(Print);
            Task t2 = Task.Factory.StartNew(Print);
            Task t3 = Task.Factory.StartNew(Print);
            // Wait for all tasks to complete
            Task.WaitAll(t1, t2, t3);
        }
    }

}
