using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Circle1
    {
        double _Radius;
        const float _PI = 3.14f;

        public Circle1(double radius)
        {
            _Radius = radius;
        }


        public void Deconstruct(out double Radius)
        {
            Radius = _Radius;
        }

        ~Circle1 ()
        {
            Console.WriteLine("Instancee is destroyed");
        }

        public float Pi
        { get {return _PI;} }

        public double Radius 
            { get { return _Radius;} }
       
        public double GetArea()
        {
            return _PI * _Radius *_Radius;
        }

        public double GetPerimeter()
        {
            return 2*_PI * _Radius;
        }


    }
}
