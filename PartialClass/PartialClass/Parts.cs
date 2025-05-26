using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PartialClass
{
    partial class Parts
    {
        public void Method1()
        {
            Console.WriteLine("Part 1: Method 1 ");
        }

        public void Method2()
        {
            Console.WriteLine("Part 2: Method 2");
        }
    }
}
