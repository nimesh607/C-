using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Class1
    {
        int a = 10;

        public void Display ()
        {
            Console.WriteLine("Hello I am Display method  From Class 1 ");
        }

        public static void Show()
        {
            Console.WriteLine("Hello I am show method  From Class 1 ");
        }

        public virtual void Show2()
        {
            Console.WriteLine("Hello I am show2 method  From Class 1 ");
        }

    }
}
