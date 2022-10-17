using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            Console.WriteLine("\tRectangle added successfully!\n");
        }
        public Rectangle(double side1, double side2)
        {
            int check = 0;
            if (side1 > 0)
            {
                _side1 = side1;
                check++;
            }
            else
            {
                Console.WriteLine("\tWrong value!");
                return;
            }

            if (side2 > 0)
            {
                _side2 = side2;
                check++;
            }
            else
            {
                Console.WriteLine("\tWrong value!");
                return;
            }

            if (check == 2)
            {
                Console.WriteLine("\tRectangle added successfully!\n");
            }
        }
        public double Side1
        {
            get
            {
                return _side1;
            }
            set
            {
                if (value > 0)
                {
                    _side1 = value;
                }
                else
                {
                    Console.WriteLine("\tWrong value!");
                    return;
                }
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
                if (value > 0)
                {
                    _side2 = value;
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
