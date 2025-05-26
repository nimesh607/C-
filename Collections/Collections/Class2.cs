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
            list.Add(1);
            list.Add(true);
            list.Add(67.90);
            list.Add("Hello");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i] + " ");
                Console.WriteLine();
            }
        }
    }
}
