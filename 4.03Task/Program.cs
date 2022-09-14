using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._03Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Рассчитать значение y при заданном значении x
            // y = sinx^2 при x > 0
            // y = 1 + 2 sin^2x в противном случае

            double y;

            Console.Write("Введите значение x: ");

            int x = int.Parse(Console.ReadLine());

            if (x > 0)
            {
                y = Math.Sin(Math.Pow(x, 2));
            }
            else
            {
                y = 1 + 2 * Math.Pow(Math.Sin(x), 2);
            }

            Console.WriteLine($"При значении x = {x} y = {y}");
         }
    }
}
