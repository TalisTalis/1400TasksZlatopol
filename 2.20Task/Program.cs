using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._20Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Составить программу расчёта значения функции при любых значениях e, f, g, h
            // a = Math.Sqrt(Math.Pow(Math.Abs(Math.E - 3/f), 3) + g)
            // b = Math.Sin(Math.E) + Math.Pow(Math.Cos, 2)
            // c = 33 * g / e * f - 3

            Console.Write("Введите значение e = ");

            double e = double.Parse(Console.ReadLine());

            Console.Write("Введите значение f = ");

            double f = double.Parse(Console.ReadLine());

            Console.Write("Введите значение h = ");

            double h = double.Parse(Console.ReadLine());

            Console.Write("Введите значение g = ");

            double g = double.Parse(Console.ReadLine());

            double a = Math.Sqrt(Math.Pow(Math.Abs(Math.E - 3/f), 3));

            double b = Math.Sin(Math.E) + Math.Pow(Math.Cos(h), 2);

            double c = 33 * g / (e * f - 3);

            Console.WriteLine("Значение функции a = " + a);

            Console.WriteLine("Значение функции b = " + b);

            Console.WriteLine("Значение функции c = " + c);
        }
    }
}
