using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._17Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны основания и высота равнобедренной трапеции. Найти ее периметр P = a + b + c + d
            // Так как трапеция равнобедренная, то c = d => P = a + b + 2c
            // Высота на основание дает прямоугольный треугольник, где катет на основании равен f = (a - b) / 2 
            // так как с противоположной стороны такой же треугольник с такой же длиной катета на основании
            // Гипотенуза такого треугольника равна с = sqrt(h^2 + f^2)
            // Периметр равен P = a + b + 2 * sqrt(h^2 + ((a - b) / 2)^2)

            double a = 5; // основание трапеции

            double b = 8; // основание трапеции

            double h = 4; // высота трапеции

            double f = (Math.Abs(a - b)) / 2; // вычисление катета прямоугольного треугольника образованного высотой

            double c = Math.Sqrt(Math.Pow(h, 2) + Math.Pow(f, 2)); // вычисление гипотенузы, то есть длины одной стороны трапеции

            double P = a + b + 2 * c;

            Console.WriteLine("Периметр равнобедренной трепеции равен P = " + Math.Round(P, 3));
        }
    }
}
