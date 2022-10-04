using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._79Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны вещественные положительные числа a, b, c.
            // Выяснить, существует ли треугольник со сторонами a, b, c.

            Console.Write("Введите число a: ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите число b: ");

            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите число c: ");

            int c = int.Parse(Console.ReadLine());

            if (a + b > c && b + c > a && c + a > b)
            {
                Console.WriteLine("Треугольник существует.");
            }
            else
            {
                Console.WriteLine("Треугольник не существует.");
            }
        }
    }
}
