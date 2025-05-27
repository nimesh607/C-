using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Console.WriteLine("Initial Capacity : " + list.Capacity);
            list.Add(1);
            Console.WriteLine("After adding 1 element Capacity is  : " + list.Capacity);//auto-risizing doubles capacity when there is no space
            list.Add(true);
            list.Add(67.90);
            list.Add("Hello");
            list.Add(true);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i] + " ");
                Console.WriteLine();
            }

            // list.Remove((true));//first occurence
            //list.RemoveAt(4);//3rd index, 2nd occurence
             list.RemoveRange(2, 2);

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
                Console.WriteLine();
            }

            ArrayList list2 = new ArrayList(50);//allocation capacity through parameterized capacity
            ArrayList list3 = new ArrayList(list);//used copy constructor 
            Console.WriteLine("Initial Capacity of list3 : " + list3.Capacity);
            for (int i = 0;i < list3.Count; i++)
            {
                Console.Write(list3[i] + " ");
                Console.WriteLine( );
            }

            list3.Add("Hello");
            list3.Add("Animals");

            Console.WriteLine("capacity of after adding elements in existing array : " + list3.Capacity);
            for (int i = 0; i < list3.Count; i++)
            {
                Console.Write(list3[i] + " ");
                Console.WriteLine();
            }
             list3.TrimToSize();

            Console.WriteLine("after trimming  : " + list3.Capacity);
        }
    }
}
