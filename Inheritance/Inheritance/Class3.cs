using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Class3
    {
         int x = 5;
        public void Display()
        {
            Console.WriteLine(x);
        }
       public class Class4
        {
            public static void Main()
            {
                Class3 obj = new Class3();
                obj.Display();
            }
        }
    }
}
