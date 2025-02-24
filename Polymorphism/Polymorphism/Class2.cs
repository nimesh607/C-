using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Class2:Class1
    {
        public override void Show2()
        {
            Console.WriteLine("Hello I am show2 method  From Class 2 ");
        }

        public new void Show() //Hiding/Shadowing using new keyword. 2)Static methods can't be override becaause it's belong to class.3)Here it will treat as  new instance member
        {
            Console.WriteLine("Hello I am show method  From Class 2 ");
        }
        
        public void Show3()
        {
            base.Show2();//you can call by using base keyword parent version of method even thoug if you overrriden it.
        }
    }
}
