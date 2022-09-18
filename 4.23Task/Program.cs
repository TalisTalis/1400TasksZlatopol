using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._23Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Определить, является ли число a делителем числа n.

            Console.Write("Введите значение n: ");

            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите значение a: ");

            int a = int.Parse(Console.ReadLine());

            if (n % a == 0)
            {
                Console.WriteLine($"Число {a} является делителем {n}.");
            }
            else
            {
                Console.WriteLine($"Число {a} не является делителем {n}.");
            }
        }
    }
}
