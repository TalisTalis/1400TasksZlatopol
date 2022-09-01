using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._16Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны катеты прямоугольного треугольника. Найти его периметр. P = a + b + c
            // c = sqrt (a^2 + b^2)

            double a = 5;
            
            double b = 3;

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            double P = a + b + c;

            Console.WriteLine("Периметр прямоугольного треугольника P = " + P);
        }
    }
}
