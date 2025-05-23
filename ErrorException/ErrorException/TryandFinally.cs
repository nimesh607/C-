using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorException
{
    internal class TryandFinally
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
            //// catch (Exception ex)
            // {
            //     Console.ForegroundColor = ConsoleColor.Red;
            //     Console.WriteLine(ex.Message);
            //     Console.ForegroundColor = ConsoleColor.White;
            // }
            finally//: in this case exceptions that occur in the program are not caught because there is no catch block so abnormal termination will take place but still the code under finally block gets executed.

            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Finally block got executed.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("End of the Program.");
        }
    }
}
