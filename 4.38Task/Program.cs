using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._38Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Имеется стол прямоугольной формы с размерами axb (a и b - целые числа, a > b)
            // В каком случае на столе можно разместить большее количество картонных 
            // прямоугольников с размерами cxd (c и d - целые числа, c > d) при размещении
            // их длинной стороной вдоль длинной стороны стола или вдоль короткой?
            // Прямоугольники не должны лежать один на другом и не должны свисать со стола.

            Console.Write("Введите сторону стола a (a > b): ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите сторону стола b: ");

            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите сторону коробки c (c > d): ");

            int c = int.Parse(Console.ReadLine());

            Console.Write("Введите сторону коробки d: ");

            int d = int.Parse(Console.ReadLine());

            int v = a / c; // количество широких сторон в широкой стороне

            int v2 = a / d; // количество узких сторон в широкой стороне

            int g = b / d; // количество узких сторон в узкой стороне

            int g2 = b / c; // количество широких сторон в узкой стороне

            if (v * g > v2 * g2)
            {
                Console.WriteLine("Больше - разместить длиной стороной.");
            }
            else
            {
                Console.WriteLine("Больше - разместить короткой стороной.");
            }
        }
    }
}
