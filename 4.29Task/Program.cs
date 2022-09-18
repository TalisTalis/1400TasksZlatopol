using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._29Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано двузначное число. Определить:
            // кратна ли трём сумма его цифр
            // кратна ли сумма его цифр числу a

            Console.Write("Введите двузначное число: ");

            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите число a: ");

            int a = int.Parse(Console.ReadLine());

            int sumDigit = n / 10 + n % 10;

            if (sumDigit % 3 == 0)
            {
                Console.WriteLine($"Сумма цифр числа {n} кратна трём.");
            }
            else
            {
                Console.WriteLine($"Сумма цифр числа {n} не кратна трём.");
            }

            if (sumDigit % a == 0)
            {
                Console.WriteLine($"Сумма цифр числа {n} кратна числу {a}");
            }
            else
            {
                Console.WriteLine($"Сумма цифр числа {n} не кратна числу {a}");
            }
        }
    }
}
