using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._94Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны целое число k (1 ≤ k ≤ 180) и последовательность цифр 10111213...9899,
            // в которой выписаны подряд все двузначные числа.
            // Определить k-ю цифру
            // 10 11 12 13 14   15    16   17   18   19   20   21 22 23 24 25 26 27 28 29 30 
            // 12 34 56 78 910 1112  1314 1516 1718 1920 2122 2324 
            Console.Write("Введите число k (от 1 до 180): ");

            int k = int.Parse(Console.ReadLine());

            int digit = 0;

            if (k % 2 == 0)
            {
                digit = (k / 2 - 1) % 10;
            }
            else
            {
                digit = k / 20 + 1;
            }

            Console.WriteLine($"{k}-я цифра = {digit}.");
        }
    }
}
