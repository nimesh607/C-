using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Circle2
    {
        //Simplified way using expression bodied Members(introduced in C#6.0 & 7.0) if you want to use method at once  or your method have 2-3 lines than use this 
        double _Radius;
        const float _PI = 3.14f;

        public Circle2(double radius) => _Radius = radius;



        public void Deconstruct(out double Radius) => Radius = _Radius; 
       
        ~Circle2() => Console.WriteLine("Instancee is destroyed");
        

        public float Pi =>_PI;
        

        public double Radius
        { get => _Radius;
            set => _Radius = value;
                }

        public double GetArea()=> _PI * _Radius * _Radius;
        
        public double GetPerimeter() => 2 * _PI * _Radius;

    }
}
