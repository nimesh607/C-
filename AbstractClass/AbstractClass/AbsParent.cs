using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal abstract class AbsParent
    {
        public   void add(int a, int b)
        {
            Console.WriteLine(a += b);
        }

        public void sub(int a, int b) //Abstract class will also have non abstract  method (concreate method)
        {
            Console.WriteLine(a -= b);
        }

        public abstract  void mul(int a, int b); //1) abstract members should only be in abstract class .it will not allow in non abstract class to have abstract members
        public abstract void div(int a, int b); //2) There will be no instance of abstract class
        //3)Abstract class is parent class

        //3)As there is no instace of abstract class to access the member of this ,it's only possoble  through child class.

    }
}
