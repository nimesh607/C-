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
            this.id = id;
            name = "Vijay";
            balance = 5000.00;
        }

        public CopyConDemo(CopyConDemo cd )
        {
            this.id = cd.id;
            name = cd.name;
            balance = cd.balance;
            
        }


        public void Display()
        {
            Console.WriteLine($"Id : {id}; Name{name}; Balance{balance}");
        }
    }
}
                                                                           