using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._80Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны вещественные положительные числа a, b, c.
            // Если существует треугольник со сторонами a, b, c,
            // то определить, является ли он прямоугольным.

            Console.Write("Введите число a: ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите число b: ");

            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите число c: ");

            int c = int.Parse(Console.ReadLine());

            if (a + b > c && b + c > a && c + a > b)
            {
                if (a > c && a > b)
                {
                    if (a*a == (b*b + c*c))
                    {
                        Console.WriteLine("Треугольник прямоугольный.");
                    }
                    else
                    {
                        Console.WriteLine("Треугольник не прямоугольный.");
                    }
                }
                else if (b > c && b > a)
                {
                    if (b*b == (a*a + c*c))
                    {
                        Console.WriteLine("Треугольник прямоугольный.");
                    }
                    else
                    {
                        Console.WriteLine("Треугольник не прямоугольный.");
                    }
                }
                else
                {
                    if (c > a && c > b)
                    {
                        if (c*c == (a*a + b*b))
                        {
                            Console.WriteLine("Треугольник прямоугольный.");
                        }
                        else
                        {
                            Console.WriteLine("Треугольник не прямоугольный.");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Треугольник не существует.");
            }
        }
    }
}
