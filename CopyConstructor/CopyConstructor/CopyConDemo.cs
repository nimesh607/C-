using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    internal class CopyConDemo
    {
        public int id;
         public string name;
        double balance;
     
        public CopyConDemo( int id)
        {
            this.id = id;//loading values from Db just for example
            name = "Vijay";
            balance = 5000.00;
        }

        public CopyConDemo(CopyConDemo cd )// string can be a parameter than CopyConDemo can also be a parameter because it is class just like string
        {
            this.id = cd.id;//Now for the new instance we are Copying value from old instance to new instance 
            name = cd.name;
            balance = cd.balance;
            
        }


        public void Display()
        {
            Console.WriteLine($"Id : {id}; Name{name}; Balance{balance}");
        }
    }
}
                                                                           
