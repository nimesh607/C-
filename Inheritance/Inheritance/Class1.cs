using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Class1
    {
        private int b = 70;
        public Class1()
        {
            Console.WriteLine("Calling constructor of class 1");

        }
        public void print()
        {
            Console.WriteLine("Class 1 method");
        }
    }

   
}
