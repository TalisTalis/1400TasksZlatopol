using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._23Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны стороны прямоугольника. Найти его периметр и длину диагонали.
            // P = 2(a + b)
            // Диагональ прямоугольника это гипотенуза прямоугольного треугольника образованного диагональю 
            // c^2 = a^2 + b^2

            double a = 5;

            double b = 10;

            double P = 2 * (a + b);

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine("Периметр прямоугольника P = " + P);

            Console.WriteLine("Длина диагонали c = " + c);
        }
    }
}
