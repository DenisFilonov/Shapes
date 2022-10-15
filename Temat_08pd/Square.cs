using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temat_08pd
{
    internal class Square : GeometricShape
    {
        private double _side;
        public Square()
        {
            _side = 4;
        }
        public Square(double side)
        {
            _side = side;
        }
        public double Side
        {
            get
            {
                return _side;
            }
            set
            {
                _side = value;
            }
        }
        public override double ShapeArea()
        {
            return Math.Pow(_side,2); // S = a^2
        }
        public override double ShapePerimeter()
        {
            return 4 * _side; // S = 4*a
        }
        public override void Show()
        {
            Console.WriteLine($"Circle\nSide: {_side}");
        }
    }
}
