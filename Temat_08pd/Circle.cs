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
        }
        public Circle(double radius)
        {
            _radius = radius;
        }
        public double Radius 
        {
            get
            { 
                return _radius; 
            } 
            set
            {
                _radius = value;
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
