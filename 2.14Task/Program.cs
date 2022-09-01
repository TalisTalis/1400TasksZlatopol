using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._14Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны катеты прямоугольного треугольника.
            // Найти его гипотенузу 
            // a^2 + b^2 = c^2

            Console.WriteLine("Введите длину первого катета a ");

            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину второго катета b ");

            double b = double.Parse(Console.ReadLine());

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine("Длина гипотенузы прямоугольного треугольника с = " + c);

        }
    }
}
