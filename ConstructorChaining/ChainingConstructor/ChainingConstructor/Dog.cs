using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainingConstructor
{
    internal class Dog
    {
        public string Name;
        public int Age;

        // Constructor 1: No parameters → calls Constructor 2 with default name
        public Dog() : this("Unknown")
        {
            Console.WriteLine("Constructor 1: No parameters");
        }

        // Constructor 2: One parameter → calls Constructor 3 with default age
        public Dog(string name) : this(name, 0)
        {
            Console.WriteLine("Constructor 2: Name only");
        }

        // Constructor 3: All parameters → does the actual initialization
        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine($"Constructor 3: Name = {Name}, Age = {Age}");
        }
    }
}
