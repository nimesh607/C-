using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Student
    {
        public int sample = 67;

        // Auto-implemented property for RollNo
        public int RollNo { get; set; }

        public void Print()
        {
            // Creating a new Student object (though here it might be redundant)
            Student obj = new Student();
            Console.WriteLine("Get RollNo Value : " + RollNo);
        }
        // Nested class OuterClass
        public class OuterClass
        {
            public int a = 5;
        }

        // Nested class DerivedClass inheriting from OuterClass
        public class DerivedClass : OuterClass
        {
            // Field initialization using an object initializer
            OuterClass price = new OuterClass { a = 10 };

            // Alternatively, if you need to run additional logic,
            // you could use a constructor like this:
            /*
            OuterClass price;

            public DerivedClass()
            {
                price = new OuterClass();
                price.a = 10;
            }
            */

            // Example method to show the value of 'a' in both the inherited context and the 'price' object
            public void ShowValues()
            {
                // 'this.a' comes from the inherited OuterClass
                Console.WriteLine("Value of 'a' in DerivedClass (inherited): " + this.a);
                Console.WriteLine("Value of 'a' in price instance: " + price.a);
            }
        }
    
}
}
