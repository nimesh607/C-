using System.Xml.Serialization;

namespace AccessDemo2
{
    internal class Class4 : AccessModifier.Program
    {
        //internal: ypes and members  that are declared as internal are accessible only withoin this project both from child and non-child class also .the default scope for types  is internal only.

        //Private Protected: Members that are declared as private protected with in a class are accessible  only to it's child class in a same project .we can use private-protected modifiers only on members but not on types .

        //internal & protected => private protected
        //internal or protected => protected internal

        static void Main(string[] args)
        {
            Class4 class4 = new Class4();
            class4.ProtectedInternalMethod();
            class4.ProtectedMethod();
            class4.PublicMethod();
        }
    }
}
