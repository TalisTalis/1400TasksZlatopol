using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._45Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано вещественное число x. Вычислить f(x), если
            // f = x^2 при -2,4 <= x <= 5,7 и f = 4

            Console.Write("Введите вещественное число x: ");

            float x = float.Parse(Console.ReadLine());

            double f;

            if (x >= -2.4 && x <= 5.7)
            {
                f = Math.Pow(x, 2);
            }
            else
            {
                f = 4;
            }

            Console.WriteLine($"Значение функции f(x) = {f}.");
        }
    }
}
