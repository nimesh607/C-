using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class AbsChild:AbsParent
    {
        public override void mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public override void div(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        static void Main()
        {
            AbsChild c = new AbsChild();
            AbsParent c1 = c; 
                               //INSTANCE CREATION IS NOT POSSIBLE OF ABSTRACT CLASS BUT REFERENCE CREAATION IS POSSIBLE USING CHILD  CLASS INSTANCE
                               //CAN WE CALL (MUL,DIV) CHILD CLASS MEMEBERS ?
                              //ANS,IS YES THEY ARE NOT PURELY DEFINE IN CHILD CLASS .tHEY ARE OVERRIDEN MEMBERS.PARENT REFERENCE CAN CALL OVERRIDEN MEMBERS BUT NOT PURELY CHILD CLASS MEMBERS.
            c.add(10,20);
            c.div(10,20);
            c.sub(10,20);   
            c.mul(10,20);

            c1.mul(10,40);
            c1.div(10, 40);
        }

    }
}
