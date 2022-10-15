using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temat_08pd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Задание 1.
             * Разработать абстрактный класс «Геометрическая Фигура» с методами «Площадь Фигуры» и «Периметр Фигуры»
             * Разработать классы-наследники: Треугольник, Квадрат, -Ромб-, Прямоугольник, -Параллелограмм-, -Трапеция-, Круг, -Эллипс-
             * Реализовать конструкторы, которые однозначно определяют объекты данных классов
             * Реализовать класс «Составная Фигура», который может состоять из любого количества «Геометрических Фигур» . 
             * Для данного класса определить метод нахождения площади фигуры + И ПЕРИМЕТРА ФИГУРЫ. Создать диаграмму взаимоотношений классов*/
            int menu;
            CompositeShape shapes = new CompositeShape();
            do
            {
                Console.WriteLine("\n\tMAIN MENU");
                Console.WriteLine("1. Add a shape");
                Console.WriteLine("2. Delete a shape");
                Console.WriteLine("3. Show shape's info");
                Console.WriteLine("4. Show all shapes info");
                Console.WriteLine("5. Get shape's area");
                Console.WriteLine("6. Get shape's perimeter");
                Console.Write("0. Exit\nChoice: ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        shapes.AddShape();
                        break;

                    case 2:
                        shapes.DelShape();
                        break;

                    case 3:
                        shapes.ShowShape();
                        break;

                    case 4:
                        shapes.ShowAllShapes();
                        break;

                    case 5:
                        shapes.FindAreaOfFigure();
                        break;

                    case 6:
                        shapes.FindPerimeterOfFigure();
                        break;

                    default:
                        if (menu > 5 || menu != 0 || menu < 0) Console.WriteLine("\tWrong menu item selected.\n");
                        break;
                }
            } while (menu != 0);
        }
    }
}
