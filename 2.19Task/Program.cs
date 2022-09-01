using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._19Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Составить программу расчёта значения функций при любых значениях a и b

            Console.Write("Введите значение a = ");
            
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите значение b = ");

            double b = double.Parse(Console.ReadLine());
            
            double firstSummandDivisible = 2 / (Math.Pow(a, 2) + 25);

            double divisible = firstSummandDivisible + b;

            double secondSummandDivider = (a + b) / 2;

            double divider = Math.Sqrt(b) + secondSummandDivider;

            double x = divisible / divider;

            Console.WriteLine("Значение функции x = " + x);

            double y = (Math.Abs(a) + 2 * Math.Sin(b)) / (5.5 * a);

            Console.WriteLine("Значение функции y = " + y);
        }
    }
}
