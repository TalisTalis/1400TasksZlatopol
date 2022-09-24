using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._62Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны вещественные положительные числа a, b, c, d.
            // Выяснить, можно ли прямоугольник со сторонами a, b
            // уместить внутри прямоугольника со сторонами c, d так,
            // чтобы каждая из сторон одного прямоугольника была параллельна 
            // или перпендикулярна каждой стороне второго прямоугольника

            Console.Write("Введите сторону первого прямоугольника a: ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите сторону первого прямоугольника b: ");

            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите сторону второго прямоугольника c: ");

            int c = int.Parse(Console.ReadLine());

            Console.Write("Введите сторону второго прямоугольника d: ");

            int d = int.Parse(Console.ReadLine());

            if (a <= c && b <= d || a <= d && b <= c)
            {
                Console.WriteLine("Прямоугольник со сторонами a и b уместится.");
            }
            else
            {
                Console.WriteLine("Прямоугольник не уместится.");
            }
        }
    }
}
