using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._46Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано вещественное число x. Вычислить f(x), если
            // f = sinx, при 0,2 <= x <= 0,9
            // f = 1, в противном случае.

            Console.Write("Введите число x = ");

            float x = float.Parse(Console.ReadLine());

            double f;

            if (x >= 0.2 && x <= 0.9)
            {
                f = Math.Sin(x);
            }
            else
            {
                f = 1;
            }

            Console.WriteLine($"Значение функции f(x) = {f}.");
        }
    }
}
