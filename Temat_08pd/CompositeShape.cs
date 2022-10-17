using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temat_08pd
{
    internal class CompositeShape
    {
        List<GeometricShape> shapes = new List<GeometricShape>();
        /*Реализовать класс «Составная Фигура», который может состоять из любого количества «Геометрических Фигур». 
         Для данного класса определить метод нахождения площади фигуры + И ПЕРИМЕТРА ФИГУРЫ.*/
        public void AddShape()
        {
            double fval1, fval2, fval3;
            int menu;
            do
            {
                Console.WriteLine("\n\tMENU FOR ADDING FIGURES");
                Console.WriteLine("1) Add square");
                Console.WriteLine("2) Add triangle");
                Console.WriteLine("3) Add rectangle");
                Console.WriteLine("4) Add circle");
                Console.Write("0. Back to main menu\nChoice: ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.Write("\nInput a side: ");
                        fval1 = Double.Parse(Console.ReadLine());

                        shapes.Add(new Square(fval1));
                        break;

                    case 2:
                        Console.Write("\nInput first side: ");
                        fval1 = Double.Parse(Console.ReadLine());

                        Console.Write("Input second side: ");
                        fval2 = Double.Parse(Console.ReadLine());

                        Console.Write("Input angle between: ");
                        fval3 = Double.Parse(Console.ReadLine());

                        shapes.Add(new Triangle(fval1, fval2, fval3));
                        break;

                    case 3:
                        Console.Write("\nInput first side: ");
                        fval1 = Double.Parse(Console.ReadLine());

                        Console.Write("Input second side: ");
                        fval2 = Double.Parse(Console.ReadLine());

                        shapes.Add(new Rectangle(fval1, fval2));
                        break;

                    case 4:
                        Console.Write("\nInput radius: ");
                        fval1 = Double.Parse(Console.ReadLine());

                        shapes.Add(new Circle(fval1));
                        break;

                    default:
                        if (menu > 4 || menu != 0 || menu < 0) Console.WriteLine("\tWrong menu item selected.\n");
                        break;
                }
            } while (menu != 0);

        }
        public void DelShape()
        {
            if (shapes.Count != 0)
            {
                int id;
                Console.Write("\nInput the ID of the figure located in the system: ");
                id = int.Parse(Console.ReadLine());

                if (id >= 1 && id <= shapes.Count)
                {
                    shapes.RemoveAt(id - 1);
                    Console.WriteLine("\tThe shape deleted succesfully!");
                }
                else
                {
                    Console.WriteLine("\tWrong ID!\n");
                }
            }
            else
            {
                Console.WriteLine("\n\tThere's no shapes in this list. Add new shape.");
            }
        }
        public void FindAreaOfFigure()
        {
            if (shapes.Count != 0)
            {
                int id;
                Console.Write("\nInput the ID of the figure located in the system: ");
                id = int.Parse(Console.ReadLine());
                double result = shapes[id - 1].ShapeArea();
                Console.WriteLine("\tResult: {0:F2}", result);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\n\tThere's no shapes in this list. Add new shape.");
            }
        }
        public void FindPerimeterOfFigure()
        {
            if (shapes.Count != 0)
            {
                int id;
                Console.Write("\nInput the ID of the figure located in the system: ");
                id = int.Parse(Console.ReadLine());
                double result = shapes[id - 1].ShapePerimeter();
                Console.WriteLine("\tResult: {0:F2}", result);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\n\tThere's no shapes in this list. Add new shape.");
            }
        }
        public void ShowShape()
        {
            if (shapes.Count != 0)
            {
                int id;
                Console.Write("\nInput the ID of the figure located in the system: ");
                id = int.Parse(Console.ReadLine());
                if (id > 0 && id <= shapes.Count)
                {
                    Console.WriteLine();
                    shapes[id - 1].Show();
                }
                else
                {
                    Console.WriteLine("\n\tWrong ID entered!");
                }
            }
            else
            {
                Console.WriteLine("\n\tThere's no shapes in this list. Add new shape.");
            }
        }
        public void ShowAllShapes()
        {
            if (shapes.Count != 0)
            {
                for (int i = 0; i < shapes.Count; i++)
                {
                    Console.WriteLine($"\n\tShape # {i + 1}");
                    shapes[i].Show();
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("\n\tThere's no shapes in this list. Add new shape.");
            }
        }
    }
}
