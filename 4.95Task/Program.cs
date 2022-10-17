using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._95Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дана последовательность цифр,
            // представляющая собой записанные подряд ноль и 20 первых натуральных чисел.
            // Найти цифру с номером n в этой последовательности(1 ≤ n ≤ 32).
            // 0 1 2 3 4 5 6 7 8 9   10   11   12   13   14   15   16   17   18   19   20
            // 1 2 3 4 5 6 7 8 9 10 1112 1314 1516 1718 1920 2122 2324 2526 2728 2930 3132
            
            Console.Write("Введите n (от 1 до 32): ");

            int n = int.Parse(Console.ReadLine());

            int digit = 0;

            if (n <= 10)
            {
                digit = n - 1;
            }
            else if (n > 10)
            {
                if (n % 2 == 0)
                {
                    digit = (n - 2) / 2;
                }
                else
                {
                    digit = n / 30 + 1;
                }
            }

            Console.WriteLine($"Цифра с номером {n} - {digit}.");
        }
    }
}
