using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._46Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны целое число k (1 <= k <= 150) и последовательность цифр
            // 101102103...149150, в которой выписаны подряд все трёхзначные числа от 101 до 150
            // Определить k-ю цифру, если известно, что
            // k - число, кратное трём
            // k - одно из чисел 1, 4, 7,...
            // k - одно из чисел 2, 5, 8,...

            Console.Write("Введите число k: ");

            int k = int.Parse(Console.ReadLine());

            if (k < 1 || k > 150)
            {
                Console.WriteLine("Число вне диапазона!");

                return;
            }

            int a, b, c;

            if (k % 3 == 0) // если к кратно 3
            {
                a = k / 3 % 10;

                Console.WriteLine($"{k}-я цифра, если число {k} кратно трём, равно {a}");
            }
            else if ((k - (k / 3 + 1)) % 2 == 0) // если К первая цифра в каждой группе
            {
                b = k / 100 + 1;

                Console.WriteLine($"{k}-я цифра, если число {k} одно из чисел 1, 4, 7..., равно {b}");

            }
            else if ((k - (k / 3 + 1)) % 2 == 1) // если К вторая цифра в каждой группе
            {
                c = k / 10 % 10;

                Console.WriteLine($"{k}-я цифра, если число {k} одно из чисел 2, 5, 8..., равно {c}");
            }
            
        }
    }
}
