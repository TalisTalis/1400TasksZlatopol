using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._72Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны два прямоугольника, стороны которых параллельны или перпендикулярныосям координат.
            // Известны координаты левого нижнего угла каждого из них и длины сторон.
            // Один из прямоугольников назовем первым, другой - вторым. Определить:
            // принадлежат ли все точки первого прямоугольника второму
            // принадлежат ли все точки одного из прямоугольников другому
            // пересекаются ли эти прямоугольники.

            Console.Write("Введите координату левого нижнего угла первого прямоугольника x1: ");

            int x1 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату левого нижнего угла первого прямоугольника y1: ");

            int y1 = int.Parse(Console.ReadLine());

            Console.Write("Введите длину первого прямоугольника a: ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите ширину первого прямоугольника b: ");

            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите координату левого нижнего угла второго прямоугольника x2: ");

            int x2 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату левого нижнего угла второго прямоугольника y2: ");

            int y2 = int.Parse(Console.ReadLine());

            Console.Write("Введите длину второго прямоугольника c: ");

            int c = int.Parse(Console.ReadLine());

            Console.Write("Введите ширину второго прямоугольника d: ");

            int d = int.Parse(Console.ReadLine());

            if (x1 >= x2 && y1 >= y2 && 
                x1 + a <= x2 + c && y1 + b <= y2 + d)
            {
                Console.WriteLine("Все точки первого прямоугольника принадлежат второму.");
            }
            else
            {
                Console.WriteLine("Не все точки первого прямоугольника принадлежат второму.");
            }

            if (x1 >= x2 && y1 >= y2 &&
                x1 + a <= x2 + c && y1 + b <= y2 + d ||
                x2 >= x1 && y2 >= y1 &&
                x2 + c <= x1 + a && y2 + d <= y1 + b)
            {
                Console.WriteLine("Все точки одного прямоугольника принадлежат другому.");
            }
            else
            {
                Console.WriteLine("Не все точки одного прямоугольника принадлежат другому.");
            }

            if (x2 < x1 + a &&
                y2 < y1 + b &&
                x2 + c > x1 + a &&
                y2 + d > y1 + b ||
                x1 < x2 + c &&
                y1 < y2 + d &&
                x1 + a > x2 + c &&
                y1 + b > y2 + d)
            {
                Console.WriteLine("Прямоугольники пересекаются.");
            }
            else
            {
                Console.WriteLine("Прямоугольники не пересекаются.");
            }
        }
    }
}
