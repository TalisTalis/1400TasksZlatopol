using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._21Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны два прямоугольника, стороны которых параллельны или перпендикулярны
            // осям координат. Известны координаты левого нижнего угла каждого из них и длины их сторон.
            // Найти координаты левого нижнего и правого верхнего углов минимального прямоугольника,
            // содержащего указанные прямоугольника.

            Console.Write("Введите координату X первого левого нижнего угла: ");

            int x1 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату Y первого левого нижнего угла: ");

            int y1 = int.Parse(Console.ReadLine());

            Console.Write("Введите сторону первого: ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите сторону первого: ");

            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите координату X второго левого нижнего угла: ");

            int x2 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату Y второго левого нижнего угла: ");

            int y2 = int.Parse(Console.ReadLine());

            Console.Write("Введите сторону второго: ");

            int c = int.Parse(Console.ReadLine());

            Console.Write("Введите сторону правого: ");

            int d = int.Parse(Console.ReadLine());

            int x3, x4, y3, y4;

            if (x1 <= x2)
            {
                x3 = x1;
                
            }
            else
            {
                x3 = x2;
            }
            if (y1 <= y2)
            {
                y3 = y1;
            }
            else
            {
                y3 = y2;
            }

            if (x1 + b >= x2 + d)
            {
                x4 = x1 + b;
            }
            else
            {
                x4 = x2 + d;         
            }

            if (y1 + a >= y2 + c)
            {
                y4 = y1 + a;
            }
            else
            {
                y4 = y2 + c;
            }

            Console.WriteLine($"Координаты левого нижнего угла: x = {x3}, y = {y3}");

            Console.WriteLine($"Координаты правого верхнего угла: x = {x4}, y = {y4}");
        }
    }
}
