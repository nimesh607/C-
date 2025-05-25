using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegates;
namespace Delegates
{
    internal class DelDemo3
    {
        static void Main()
        {
            WishDelegate wd = delegate (string Name)//Anonymous method.No return type of  this method .compiler will take it from Delegate itself.whatever delegate return is that will be return type of method
            {
                return $"{Name} ,very good morning";
            };
            Console.WriteLine(wd("Raju"));

            CalculatorDelegate cd = delegate (int a, int b, int c)//Anonymous method
            {
                Console.WriteLine("Product of given 3 nos "+(a+b+c));
            };
            cd(10, 30, 50);



        }
    }
}
