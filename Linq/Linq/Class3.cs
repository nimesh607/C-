using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            // An array of color names
            string[] colors = { "Red", "Blue", "Green", "Black", "White", "Brown", "Orange", "Purple", "Yellow", "Aqua" };

            // LINQ Query 1: Select all colors from the array
            // This simply fetches all items in the same order
            var coll1 = from c in colors select c;
            Console.WriteLine("All Colors:");
            Console.WriteLine(String.Join(", ", coll1));

            // LINQ Query 2: Select all colors and sort them in ascending (alphabetical) order
            var coll2 = from s in colors orderby s select s;
            Console.WriteLine("\nColors in Ascending Order:");
            Console.WriteLine(String.Join(", ", coll2));

            // LINQ Query 3: Select all colors and sort them in descending (reverse alphabetical) order
            var coll3 = from s in colors orderby s descending select s;
            Console.WriteLine("\nColors in Descending Order:");
            Console.WriteLine(String.Join(", ", coll3));

            // LINQ Query 4: Select only those colors whose length is exactly 5 characters
            var coll4 = from s in colors where s.Length == 5 select s;
            Console.WriteLine("\nColors with Length 5:");
            Console.WriteLine(String.Join(", ", coll4));

            // LINQ Query 5: Select colors that start with the letter 'B'
            var coll5 = from s in colors where s[0] == 'B' select s;//s[0] uses an indexer!
            Console.WriteLine("\nColors Starting with 'B':");
            Console.WriteLine(String.Join(", ", coll5));

            //Another  way 
            var coll6 = from s in colors where s.IndexOf("B") == 0 select s; //both 5 & 6 are same .in first case  with index i am finding character and in 2nd case from char i am finding index. 0==B and B==0
            Console.WriteLine(String.Join(", ",coll6));


        }
    }
}
