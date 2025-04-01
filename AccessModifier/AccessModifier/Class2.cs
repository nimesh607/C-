using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    internal class Class2:Program
    {
        //Consuming members of program(parent) class from child class class in a same project

        //private:members(fields,methods,cons,finalizers,props,events,indexers,decons) that are declared as private in a class or structure are accessible only within the type.the default scope for members of class and structure is private only whereas it is public incase of interface.we can use private modifiers only on members but not on types (class,interface,structure,enum,delegate).
        static void Main()
        {
            Class2 c2 = new Class2();
            c2.ProtectedInternalMethod();
            c2.InternalMethod();
            c2.ProtectedMethod();
            c2.ProtectedInternalMethod();
            c2.PrivateProtectedMethod();
        }
    }
}
