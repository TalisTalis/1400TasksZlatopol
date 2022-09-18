using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._25Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано целое число n. Вывести на экран следующее за ним четное число

            Console.Write("Введите число n: ");

            int n = int.Parse(Console.ReadLine());

            int t;

            if (n % 2 == 0)
            {
                t = n + 2;
            }
            else
            {
                t = n + 1;
            }

            Console.WriteLine($"Следующее чётное число после числа {n} равно {t}.");
        }
    }
}
