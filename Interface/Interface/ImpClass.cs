using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Interface
{
    internal class ImpClass:Interface1,Interface2
    {
                /* If we come across any situation where two different immediate parent interface having child class and that child class is implementing both interfaces than, we can implement the    interface methods under class by using 2 different approaches:
                   1. Implement the method of both interfaces only for 1 time under the class and both interfaces will assume the implemented method is of its only and in this case, we can call the     method directly by using class instance.
                   2. We can also implement the method of both interfaces separately for each interface under the class by prefixing interface name before method name and we call this as explicit implementation, but in this case, we need to call the method by using reference of interface that is created with the help of a child class instance.   */
        public void Test()
        {
            Console.WriteLine("Declared in both interfaces");
        }
   
        void Interface1.Show() //Used Explicitly .No need to declare access modifier because already having interface name as prefix
        {
            Console.WriteLine("Hello, I am from Interface 1  Show method");
        }

        void Interface2.Show()//Used Explicitly .No need to declare access modifier because already having interface name as prefix
        {
            Console.WriteLine("Hello, I am from Interface 2 Show method");
        }

        static void Main()
        {
            ImpClass c1 = new ImpClass();
            Interface1 i1 = c1;//Call it by creeating interace reference because we opting for explicitly implementation
            Interface2 i2 = c1;
            i1.Show();
            i2.Show();
            c1.Test();
            Console.WriteLine();
        }
    }
}
