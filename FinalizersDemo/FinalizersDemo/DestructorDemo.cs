using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizersDemo
{
    internal class DestructorDemo
    {
        public DestructorDemo() 
        {
            Console.WriteLine("Instance1 is Created");
        }

        ~DestructorDemo()
        {
            Console.WriteLine("Destructor2 is called ");
        }
        

        static void Main(string[] args)
        {
            DestructorDemo demo1 = new DestructorDemo();
            DestructorDemo demo2 = new DestructorDemo();
            DestructorDemo demo3 = new DestructorDemo();
            demo1 = null;//unused  instance destroyed by gc when they come into action  
            demo3 = null;
            GC.Collect();
            Console.ReadLine();
            //demo2 will be implicit call we cant see that .its not on developer control . 
            
        }
    }
}
