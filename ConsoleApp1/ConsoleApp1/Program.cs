using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int b ;

        static Program()
        {
            Console.WriteLine("Static Constructor called {0}",b);
        }

        Program()
        {
            b = 5;
            Console.WriteLine("Default Constructor Called {0}",b );
        }
            static void Main(string[] args)
        {
          /*  Console.WriteLine("Helllo World");
            Program program = new Program();
            Program.b = 10;*/
        }
    }
}
