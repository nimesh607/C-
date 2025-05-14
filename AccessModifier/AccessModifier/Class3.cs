using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    internal class Class3 //Non Child class 
    {
        //Consuming members of program(parent) class from non-child class in a same project

        //Protected: Members that are declared as protected in a class are accessible only to the child class i.e,a non-child can't access them.we can use private modifiers only on members but not on types (class,interface,structure,enum,delegate).

        static void Main()
        {
            Program p = new Program();
            p.InternalMethod();
            p.ProtectedInternalMethod();
            p.PublicMethod();
        }
    }
}
