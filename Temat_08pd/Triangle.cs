using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            Console.WriteLine("\tTriangle added successfully!\n");
        }
        public Triangle(double side1, double side2, double angleBetween)
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

            if (angleBetween > 0 && angleBetween < 180)
            {
                _angleBetween = angleBetween;
                check++;
            }
            else
            {
                Console.WriteLine("\tWrong value!");
                return;
            }

            if (check == 3)
            {
                Console.WriteLine("\tTriangle added successfully!\n");
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
        public double AngleBetween
        {
            get
            {
                return _angleBetween;
            }
            set
            {
                if (value > 0 && value < 180)
                {
                    _angleBetween = value;
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
