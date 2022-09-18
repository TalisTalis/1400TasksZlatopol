using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._07Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Составить программу для вычисления значения функции f(x)

            Console.Write("Введите значение x: ");

            int x = int.Parse(Console.ReadLine());

            int k = 0, f = 0;

            if (Math.Sin(x) < 0)
            {
                k = (int)Math.Pow(x, 2);
            }
            else if (Math.Sin(x) >= 0)
            {
                k = Math.Abs(x);
            }

            if (k < x)
            {
                f = k * x;
            }
            else if (k >= x)
            {
                f = k + x;
            }

            Console.WriteLine($"Значение функции f(x) = {f}");
        }
    }
}
