using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._61Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны вещественные числа a, b, c (a != 0)
            // Решить уравнение ax2 + bx + c = 0
            // В числе возможных вариантов учесть вариант равенства корней уравнения

            Console.Write("Введите значение a: ");

            int a = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Значение a не должно быть равным нулю!");
                return;
            }

            Console.Write("Введите значение b: ");

            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите значение c: ");

            int c = int.Parse(Console.ReadLine());

            double D = Math.Pow(b, 2) - 4 * a * c;

            double x1, x2;

            if (D > 0)
            {
                x1 = ((-b) - Math.Sqrt(D)) / (2 * a);

                x2 = ((-b) + Math.Sqrt(D)) / (2 * a);

                Console.WriteLine($"Корни уравнения {a}x2 + {b}x + {c}: x1 = {x1}, x2 = {x2}.");
            }
            else if (D == 0)
            {
                x1 = (-b) / (2 * a);

                Console.WriteLine($"Корень уравнения {a}x2 + {b}x + {c}: x1 = {x1}.");
            }
            else
            {
                Console.WriteLine("Корней нет.");
            }
        }
    }
}
