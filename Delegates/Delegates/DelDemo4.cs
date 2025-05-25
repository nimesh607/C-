using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class DelDemo4
    {
        static void Main()
        {
            WishDelegate wd =  ( Name)=>//Simplified way of Anonymous method i.e.,Lambda method 
            {
                return $"{Name} ,very good morning";
            };
            Console.WriteLine(wd("Raju"));
        }
    }
}
