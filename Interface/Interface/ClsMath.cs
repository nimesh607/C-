using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class ClsMath : Program, IMath, IMath2
    {
        

    

        public void add(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        public void div(int a, int b)
        {
            Console.WriteLine(a/b);
        }

        public void mul(int a, int b)
        {
            Console.WriteLine(a*b);
        }

        public void sub(int a, int b)
        {
            Console.WriteLine(a/b);
        }

        static void Main()
        {
            ClsMath c = new ClsMath();
            IMath i1 = c; IMath2 i2 = c;
            i1.add(100, 250);
            i1.sub(200, 100);
            i2.mul(2, 5);
            i2.div(10, 2);
        }
    }
}
