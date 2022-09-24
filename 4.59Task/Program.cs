using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._59Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Определить, является ли треугольник со сторонами a, b, c
            // равносторонним
            // равнобедренным

            Console.Write("Введите a: ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите b: ");

            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите c: ");

            int c = int.Parse(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.WriteLine("Треугольник равносторонний.");
            }

            if (a == b || b == c || c == a)
            {
                Console.WriteLine("Треугольник равнобедренный.");
            }
        }
    }
}
