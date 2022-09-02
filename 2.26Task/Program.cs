using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._26Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны координаты на плоскости двух точек. Найти расстояние между этими точками.
            // d = √ (х А – х В) 2 + (у А – у В)

            double a1 = 5;

            double a2 = 8;

            double b1 = 2;

            double b2 = 7;

            double d = Math.Sqrt(Math.Pow((a1 - b1), 2) + Math.Pow((a2 - b2), 2));

            Console.WriteLine("Расстояние между двумя точками на плоскости d = " + d);
        }
    }
}
