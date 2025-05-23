using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorException
{
    internal class ApplicationExceptions
    {

        public static void Main(string[] args)
        {
            
                Console.Write("Enter 1st number: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter 2nd number: ");
                int y = int.Parse(Console.ReadLine());
                
                if(y % 2 > 0)
                {
                //  throw new ApplicationException();//By default 'Error in the application.' message will display which will be Exception (Parent) Class
               //throw new ApplicationException("Value of divisor should not be an odd number");//Parameterised Constructor
                throw new DivideByOddNoException(); // custom Exception class 
            }
            int z = x / y; //exception manager will identify and Creates the instance of matching exception  
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The result of division is: " + z);
                Console.WriteLine("End of the Program");
            
}
    }
}
