using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._58Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны три вещественных числа a, b, c.
            // Определить, имеется ли среди них хотя бы одна пара равных между собой чисел

            Console.Write("Введите число a: ");

            float a = float.Parse(Console.ReadLine());

            Console.Write("Введите число b: ");

            float b = float.Parse(Console.ReadLine());

            Console.Write("Введите число c: ");

            float c = float.Parse(Console.ReadLine());

            if (a == b || b == c || c == a)
            {
                Console.WriteLine("Среди чисел имеется хотя бы одна пара.");
            }
            else
            {
                Console.WriteLine("Среди чисел нет пар.");
            }
        }
    }
}
