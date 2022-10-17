using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temat_08pd
{
    internal class Circle : GeometricShape
    {
        private double _radius;
        public Circle()
        {
            _radius = 5;
            Console.WriteLine("\tCircle added successfully!\n");
        }
        public Circle(double radius)
        {
            if (radius > 0)
            {
                _radius = radius;
                Console.WriteLine("\tCircle added successfully!\n");
            }
            else
            {
                Console.WriteLine("\tWrong value!");
                return;
            }
        }
        public double Radius 
        {
            get
            { 
                return _radius; 
            } 
            set
            {
                if (value > 0)
                {
                    _radius = value;
                }
                else
                {
                    Console.WriteLine("\tWrong value!");
                    return;
                }
            }
        }
        public override double ShapeArea()
        {
            return Math.PI * Math.Pow(_radius, 2); // S = п*r^2
        }
        public override double ShapePerimeter()
        {
            return 2 * Math.PI * _radius; // P = 2*п*r
        }
        public override void Show()
        {
            Console.WriteLine($"Circle\nRadius: {_radius}");
        }
    }
}
