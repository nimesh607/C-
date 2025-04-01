using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Class2:Class1
    {
       public Class2()
        {
            Console.WriteLine("Calling Constructor of class 2");
            
        }
   
        public void print2()
        {
            Console.WriteLine("Class 2 method");
            
        }
    }
}
