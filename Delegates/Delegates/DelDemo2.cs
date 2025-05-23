using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MathDelegate(int a, int b);
    internal class DelDemo2
    {
        public void Add(int x, int y)
        {
            Console.WriteLine($"Add: {x + y}");
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine($"Sub: {x - y}");
        }
        public void Mul(int x, int y)
        {
            Console.WriteLine($"Mul: {x * y}");
        }

        public void Div(int x, int y)
        {
            Console.WriteLine($"Div: {x / y}");
        }

        static void Main()
        {
            //create instance of class first because methods are non static
            DelDemo2 delDemo2 = new DelDemo2();
            MathDelegate md = delDemo2.Add;
            md += delDemo2.Sub;//MultiCast Delegates.binding multiple methods with single delegate.Muliticasting can be done with only non-returning method i.e.,void 
            md += delDemo2.Mul;//Multicast Delegates.include
            md(100, 300);
            Console.WriteLine();
            md(250, 50);//one call four results.no need to make 4 calls.1 calls four methods will execute
            Console.WriteLine();
            //Now i do not want multiply than do like this
            md -= delDemo2.Mul;//exclude
            md(400, 20);
        }
    }
}
