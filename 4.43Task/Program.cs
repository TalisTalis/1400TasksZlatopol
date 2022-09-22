using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._43Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны координаты точки на плоскости.
            // Определить, попадает ли точка в область I.
            // Для простоты принять, что координаты точки не равны соответствующим границам этой области.

            Console.Write("Введите координату x = ");

            int x = int.Parse(Console.ReadLine());

            Console.Write("Введите координату y = ");

            int y = int.Parse(Console.ReadLine());

            if (x > 3 & y > 2)
            {
                Console.WriteLine("Точка входит в область I.");
            }
            else
            {
                Console.WriteLine("Точка не входит в область I.");
            }
        }
    }
}
