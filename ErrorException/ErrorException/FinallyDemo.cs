using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorException
{
    internal class FinallyDemo
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter 1st number: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter 2nd number: ");
                int y = int.Parse(Console.ReadLine());
                if (y == 1)
                {
                    return;
                }
                int z = x / y;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The result of division is: " + z);
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            finally//even after control exits from method when y==1 than also finally block will execute . 
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Finally block got executed.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("End of the Program.");
        }
    }
}
