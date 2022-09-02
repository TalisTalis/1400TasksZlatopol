using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._25Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны длины сторон прямоугольного параллелепипеда. Найти его объём и площадь боковой поверхности
            // V = abc
            // S = 2c(a + b)

            int a = 5, b = 3, c = 7;

            int P = a * b * c;

            int S = 2 * c * (a + b);

            Console.WriteLine("Объём прямоугольного параллелепипеда P = " + P);

            Console.WriteLine("Площадь боковой поверхности прямоугольного параллелепипеда S = " + S);
        }
    }
}
