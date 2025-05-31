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

            //Another  ways 
            var coll6 = from s in colors where s.IndexOf("B") == 0 select s; //both 5 & 6 are same .in first case  with index i am finding character and in 2nd case from char i am finding index. 0==B and B==0
            Console.WriteLine(String.Join(", ",coll6));

            var coll7 = from s in colors where s.StartsWith("B") select s;
            Console.WriteLine(String.Join(", ",coll7));

            var coll8 = from s in colors where s.Substring(0, 1) == "B" select s;
            Console.WriteLine(String.Join(", ",coll8));

            //last character
            var coll9 = from s in colors where s[s.Length - 1] == 'e' select s;
            Console.WriteLine(String.Join(", ",coll9));

            var coll10 = from s in colors where s.EndsWith("e") select s;
            Console.WriteLine(String.Join(", ",coll10));

            var coll11 = from s in colors where s.IndexOf('e') == s.Length-1 select s;
            Console.WriteLine(String.Join(", ",coll11));

            var coll12 = from s in colors where s.Substring(s.Length - 1,1)=="e"  select s;
            Console.WriteLine(String.Join(", ",coll12));

            var coll13 = from s in colors where s[2] == 'a' select s;
            Console.WriteLine(String.Join(", ",coll13));

            var coll14 = from s in colors where s.IndexOf("a") == 2 select s;
            Console.WriteLine(String.Join(", ",coll14));
           
            var coll15 = from s in colors where s.Substring(2,1) == "a" select s;
            Console.WriteLine(String.Join(", ",coll15));

            //Getting the list of colors whose name contains character "O or o" in it: 
            var coll16 = from s in colors where s.IndexOf('o') >=0 || s.IndexOf('O') >= 0 select s;
            Console.WriteLine(String.Join(", ",coll16));

            var coll17 = from s in colors where s.IndexOf('O') >= 0 || s.IndexOf('o') >= 0 select s;
            Console.WriteLine(String.Join(" ", coll17));
            var coll18 = from s in colors where s.ToUpper().Contains('O') select s;
            Console.WriteLine(String.Join(" ", coll18));
            var coll19 = from s in colors where s.ToLower().IndexOf('o') >= 0 select s;
            Console.WriteLine(String.Join(" ", coll19) + "\n");

            //Getting the list of colors whose name doesn’t contains character "O or o" in it: 
            var coll20 = from s in colors where s.Contains('O') == false && s.Contains('o') == false select s;
            Console.WriteLine(String.Join(" ", coll20));
            var coll21 = from s in colors where s.IndexOf('O') == -1 && s.IndexOf('o') == -1 select s;
            Console.WriteLine(String.Join(" ", coll21));
            var coll22 = from s in colors where s.ToUpper().Contains('O') == false select s;
            Console.WriteLine(String.Join(" ", coll22));
            var coll23 = from s in colors where s.ToLower().IndexOf('o') == -1 select s;
            Console.WriteLine(String.Join(" ", coll23) + "\n");
            Console.ReadLine();



        }
    }
}
