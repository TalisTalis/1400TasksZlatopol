using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._97Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны целое число k (1 ≤ k ≤ 222) и последовательность цифр 123...91011...9899100101...109110,
            // в которой выписаны подряд все натуральные числа от 1 до 110.Определить k - ю цифру.
            // 1 2 3 4 5 6 7 8 9  10   11   12   13   14   15   16   17   18   19   20   21   22   23   24
            // 1 2 3 4 5 6 7 8 9 1011 1213 1415 1617 1819 2021 2223 2425 2627 2829 3031 3233 3435 3637 3839

            Console.Write("Введите число k (от 1 до 222): ");

            int k = int.Parse(Console.ReadLine());

            int digit = 0;

            if (k < 10)
            {
                digit = k;
            }
            else if (k <= 100)
            {
                if (k % 2 == 0)
                {
                    digit = k / 30 + 1;
                }
                else
                {
                    digit = k % 10 - k % 2;
                }
            }

            Console.WriteLine($"{k}-я цифра это {digit}.");
        }
    }
}
