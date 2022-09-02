using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._21Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Составить программу расчёта значения функцийпри любых значениях e, f, h, g
            // a = (E - f/2)/3
            // b = |h^2 - g|
            // c = sqrt((g - h)^2 - 3sinE)

            Console.Write("Введите значение e = ");

            double e = double.Parse(Console.ReadLine());

            Console.Write("Введите значение f = ");

            double f = double.Parse(Console.ReadLine());

            Console.Write("Введите значение h = ");

            double h = double.Parse(Console.ReadLine());

            Console.Write("Введите значение g = ");

            double g = double.Parse(Console.ReadLine());

            double a = (Math.E - f / 2) / 3;

            double b = Math.Abs(Math.Pow(h, 2) - g);

            double c = Math.Sqrt(Math.Pow(g - h, 2) - 3 * Math.Sin(Math.E));

            Console.WriteLine("Значение функции a = " + a);

            Console.WriteLine("Значение функции b = " + b);

            Console.WriteLine("Значение функции c = " + c);
        }
    }
}
