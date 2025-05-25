using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegates;


namespace Delegates
{
    //Note: while defining a delegate you should follow the same signature of the method i.e., parameters of delegateshould be same as the parameters of method and return types of delegates should be same as the return types of method, we want to call by using the delegate.

  
    internal class DelDemo1
    {
        public void AddNums(int x, int y, int z)
        {
            Console.WriteLine("Sum of given 3 no's is:" + (x + y + z));
        }

        public static string SayHello(string Name)
        {
            return $"Hello {Name},how are you";
        }

        static void Main(string[] args)
        {
            //Step2:Instantiate the delegate.In this process we create the instance of the delegate and bind the method we want to   call by using the delegate to the delegate.

            WishDelegate wishDelegate =new WishDelegate(DelDemo1.SayHello);//Binding  method with delegate .Another way=>   WishDelegate wishDelegate=DelDemo1.SayHello
            Console.WriteLine(wishDelegate("Alex"));
            Console.WriteLine(wishDelegate("Monash"));



            DelDemo1 demo1 = new DelDemo1();//nonstatic so first make instance
            CalculatorDelegate calculatorDelegate = new CalculatorDelegate(demo1.AddNums);//Binding  method with delegate.Another way to instiate demo1.AddNums
            calculatorDelegate(10,20,30); calculatorDelegate(100, 205, 310);
            Console.ReadLine();
        }

    }
}
