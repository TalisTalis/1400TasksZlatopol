using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._47Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны три вещественных числа a, b, c. Проверить:
            // выполняется ли неравенство a < b < c
            // выполняется ли неравенство b > a > c

            Console.Write("Введите значение a: ");

            float a = float.Parse(Console.ReadLine());

            Console.Write("Введите значение b: ");

            float b = float.Parse(Console.ReadLine());

            Console.Write("Введите значение c: ");

            float c = float.Parse(Console.ReadLine());

            if (b > a && b < c)
            {
                Console.WriteLine("Выполняется неравенство a < b < c.");
            }
            else
            {
                Console.WriteLine("Не выполняется неравенство a < b < c.");
            }

            if (a < b && a > c)
            {
                Console.WriteLine("Выполняется неравенство b > a > c.");
            }
            else
            {
                Console.WriteLine("Не выполняется неравенство b > a > c.");
            }
        }
    }
}
