using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._02Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Рассчитать значение y при заданном значение x:
            // y = sin^2x при x > 0
            // y = 1 - 2sinx^2 в противном случае

            double y;

            Console.Write("Введите значение x: ");

            int x = int.Parse(Console.ReadLine());

            if (x > 0)
            {
                y = Math.Pow(Math.Sin(x), 2);
            }
            else
            {
                y = 1 - 2 * Math.Sin(Math.Pow(x, 2));
            }

            Console.WriteLine($"При x = {x}, y = {y}");
        }
    }
}
