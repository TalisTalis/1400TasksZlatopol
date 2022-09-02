using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._27Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны основания и высота равнобедренной трапеции. Найти периметр трапеции
            // P = a + b + c + d
            // c = d
            // h выделяет треугольник где гипотенуза = c, катет = h, второй катет = (b-a)/2
            // c = √ h^2 + (b-a)/2

            double a = 6;

            double b = 9;

            double h = 3;

            double c = Math.Sqrt(Math.Pow(h, 2) + Math.Pow((b - a) / 2, 2));

            double P = a + b + 2 * c;

            Console.WriteLine("Периметр равнобедреной трапеции при основаниях " + a + " и " + b + " и высоте " + h + " P = " + P);
        }
    }
}
