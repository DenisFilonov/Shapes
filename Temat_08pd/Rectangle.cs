using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Temat_08pd
{
    internal class Rectangle : GeometricShape
    {
        private double _side1;
        private double _side2;

        public Rectangle()
        {
            _side1 = 10;
            _side2 = 5;
        }
        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
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
        public override double ShapeArea()
        {
            return _side1 * _side2; // S = a * b
        }
        public override double ShapePerimeter()
        {
            return 2 * (_side1 + _side2); // P = 2 * (a + b)
        }
        public override void Show()
        {
            Console.WriteLine($"Rectangle\nSide1: {_side1}\nSide2: {_side2}");
        }

    }
}
