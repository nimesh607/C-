using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            List<int> Coll1 = new List<int>();//

            Coll1.Add(10); Coll1.Add(20); Coll1.Add(30); Coll1.Add(40);

            for (int i = 0; i < Coll1.Count; i++)
            {
                Console.Write(Coll1[i] + " ");
                
            }
            Console.WriteLine();
            Coll1.Remove(10);
            Coll1.RemoveAt(0);

            foreach (int i in Coll1)
            {
                Console.WriteLine("After removal :"+i + " ");
           
            }
            Console.WriteLine();
            Coll1.Insert(2, 50);
            Coll1.Insert(3, 70);
            foreach (int i in Coll1)
            {
                Console.WriteLine("After inserting :" + i + " ");
              
            }

            Console.WriteLine();
            List<int> Coll2 = new List<int>(Coll1);
            foreach (int i in Coll2)
            {
                Console.WriteLine(i + " ");
            }
        
           
        }
    }
}
