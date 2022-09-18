using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._20Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны два прямоугольника, стороны которых параллельны или перпендикулярны осям координат.
            // Известны координаты левого нижнего и правого верхнего углов каждого из них.
            // Найти координаты левого нижнего и правого верхнего углов минимального прямоугольника,
            // содержащего указанные прямоугольника.

            Console.Write("Введите координату X первого левого нижнего угла: ");

            int x1 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату Y первого левого нижнего угла: ");

            int y1 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату X первого правого верхнего угла: ");

            int x2 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату Y первого правого верхнего угла: ");

            int y2 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату X второго левого нижнего угла: ");

            int x3 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату Y второго левого нижнего угла: ");

            int y3 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату X второго правого верхнего угла: ");

            int x4 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату Y второго правого верхнего угла: ");

            int y4 = int.Parse(Console.ReadLine());

            int x5, x6, y5, y6;

            if (x1 <= x3 && y1 <= y3)
            {
                x5 = x1;

                y5 = y1;
            }
            else
            {
                x5 = x3;
                y5 = y3;
            }

            if (x4 >= x2 && y4 >= y2)
            {
                x6 = x4;

                y6 = y4;
            }
            else
            {
                x6 = x2;

                y6 = y2;
            }

            Console.WriteLine($"Координаты нижнего левого угла: x = {x5}, y = {y5}");

            Console.WriteLine($"Координаты верхнего верхнего угла: x = {x6}, y = {y6}");
        }
    }
}
