using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Temat_08pd
{
    internal class Triangle : GeometricShape
    {
        private double _side1;
        private double _side2;
        private double _angleBetween;

        public Triangle()
        {
            _side1 = 9;
            _side2 = 9;
            _angleBetween = 90;
        }
        public Triangle(double side1, double side2, double angleBetween)
        {
            _side1 = side1;
            _side2 = side2;
            _angleBetween = angleBetween;
        }
        public double Side1
        {
            get
            {
                return _side1;
            }
            set
            {
                _side1 = value;
            }
        }
        public double Side2
        {
            get
            {
                return _side2;
            }
            set
            {
                _side2 = value;
            }
        }
        public double AngleBetween
        {
            get
            {
                return _angleBetween;
            }
            set
            {
                _angleBetween = value;
            }
        }
        public override double ShapeArea()
        {
            return 0.5 * _side1 * _side2 * Math.Sin(_angleBetween * Math.PI / 180); // S = 1/2*a*b*sin(alpha)
        }
        public override double ShapePerimeter()
        {
            //P = √a^2+b^2 - 2*a*b*cos(alpha)
            return Math.Sqrt(Math.Pow(_side1, 2) + Math.Pow(_side2, 2)) - 2 * _side1 * _side2 * Math.Cos(_angleBetween);
        }
        public override void Show()
        {
            Console.WriteLine($"Triangle\nSide1: {_side1}\nSide2: {_side2}");
        }
    }
}
