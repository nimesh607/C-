using System.Xml.Serialization;

namespace AccessDemo2
{
    //Consuming members of a class from child class from another project
    internal class Class4 : AccessModifier.Program
    {
        //internal: types and members  that are declared as internal are accessible only within this project both from child and non-child class also .the default scope for types  is internal only.

        //Private Protected: Members that are declared as private protected with in a class are accessible  only to it's child class in a same project .we can use private-protected modifiers only on members but not on types .

        //private & protected => if private and protected is accessible than privateprotected is also accessible 
        //internal or protected =>if protected or internal  is accessible than protected internal is accessible.

        static void Main(string[] args)
        {
            Class4 class4 = new Class4();
            class4.ProtectedInternalMethod();
            class4.ProtectedMethod();//Can consume protected because it is child class
            class4.PublicMethod();
        }
    }
}
