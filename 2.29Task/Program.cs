using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._29Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Треугольник задан координатами своих вершин. Найти периметр и площадь треугольника
            // a = √(x2 - x1)^2 + (y2 - y1)^2
            // b = √(x3 - x2)^2 + (y3 - y2)^2
            // c = √(x1 - x3)^2 + (y1 - y3)^2
            // S = √p (p - a) (p - b) (p - c)
            // p = (a + b + c) / 2

            int x1 = 5, y1 = 3;

            int x2 = 7, y2 = 2;

            int x3 = 1, y3 = 7;

            double a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            double b = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));

            double c = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));

            double p = (a + b + c) / 2;

            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine($"Периметр треугольника P = {p}");

            Console.WriteLine($"Площадь треугольника S = {S}");
        }
    }
}
