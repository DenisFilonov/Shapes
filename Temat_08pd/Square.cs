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
            Console.WriteLine("\tSquare added successfully!\n");
        }
        public Square(double side)
        {
            if (side > 0)
            {
                _side = side;
                Console.WriteLine("\tSquare added successfully!\n");
            }
            else
            {
                Console.WriteLine("\tWrong value!");
                return;
            }
        }
        public double Side
        {
            get
            {
                return _side;
            }
            set
            {
                if (value > 0)
                {
                    _side = value;
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
