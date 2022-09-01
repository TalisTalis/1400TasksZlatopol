using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._18Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Составить программу вычисления значений функций z = (x + (2 + y) / x^2) / (y + (1 / sqrt(x^2 + 10))) и
            // q = 7.25 * sinx - |y| при любых значениях x и y

            Console.Write("Введите значение x = ");

            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите значение y = ");

            double y = double.Parse(Console.ReadLine());

            double secondSummandDivisible = (2 + y) / Math.Pow(x, 2);

            double divisible = x + secondSummandDivisible;

            double secondSummandDivider = 1 / Math.Sqrt(Math.Pow(x, 2) + 10);

            double divider = y + secondSummandDivider;

            double z = divisible / divider;

            Console.WriteLine("Значение функции z = " + z);

            double q = 7.25 * Math.Sin(x) - Math.Abs(y);

            Console.WriteLine("Значение функции q = " + q);
        }
    }
}
