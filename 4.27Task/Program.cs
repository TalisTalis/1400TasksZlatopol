using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._27Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано двузначное число. Определить, равен ли квадрат этого числа
            // учетверённой сумме кубов его цифр.
            // (a2a1)^2 == a2^3 + a1^3

            Console.Write("Введите двузначное число: ");

            int a = int.Parse(Console.ReadLine());

            double quadA = Math.Pow(a, 2);

            double digitDecCube = Math.Pow(a / 10, 3);

            double digitUnitCube = Math.Pow(a % 10, 3);

            double sumDigit = digitDecCube + digitUnitCube;

            if (quadA == 4 * sumDigit)
            {
                Console.WriteLine($"Квадрат числа {a} равен учетверённой сумме кубов цифр числа {a}");
            }
            else
            {
                Console.WriteLine($"Квадрат числа {a} не равен учетверённой сумме кубов цифр числа {a}");
            }
        }
    }
}
