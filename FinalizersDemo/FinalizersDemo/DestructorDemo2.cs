using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizersDemo
{
    internal class DestructorDemo2 : DestructorDemo //parent class const and destructor will execute
    {
        public DestructorDemo2()
        {
            Console.WriteLine("Instance2 is Created");
        }

        ~DestructorDemo2()
        {
            Console.WriteLine("Destructor2 is called ");
        }

        static void Main(string[] args)
        {
            DestructorDemo2 demo = new DestructorDemo2();
            Console.ReadLine();
        }
    }
}
