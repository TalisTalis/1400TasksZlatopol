using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._33Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано трёхзначное число. Определить:
            // является ли сумма его цифр двузначным числом
            // является ли произведение его цифр трёхзначным числом
            // больше ли числа a произведение его цифр
            // кратна ли пяти сумма его цифр
            // кратна ли сумма его цифр числу a

            Console.Write("Введите трёхзначное число: ");

            int n = int.Parse(Console.ReadLine());

            int firstDigit = n / 100;

            int secondDigit = n % 100 / 10;

            int lastDigit = n % 10;

            int sumDigits = firstDigit + secondDigit + lastDigit;

            if (sumDigits / 10 == 1)
            {
                Console.WriteLine($"Сумма цифр числа {n} является двузначном числом.");
            }
            else
            {
                Console.WriteLine($"Сумма цифр числа {n} не является двузначным числом.");
            }

            int multiDigits = firstDigit * secondDigit * lastDigit;

            if (multiDigits / 100 == 1)
            {
                Console.WriteLine($"Произведение цифр числа {n} является трёхзначным числом.");
            }
            else
            {
                Console.WriteLine($"Произведение цифр числа {n} не является трёхзначным числом.");
            }

            Console.Write("Введите число a: ");

            int a = int.Parse(Console.ReadLine());

            if (multiDigits > a)
            {
                Console.WriteLine($"Произведение цифр числа {n} больше числа {a}.");
            }
            else
            {
                Console.WriteLine($"Произведение цифр числа {n} меньше числа {a}");
            }

            if (sumDigits % 5 == 0)
            {
                Console.WriteLine($"Сумма цифр числа {n} кратна 5.");
            }
            else
            {
                Console.WriteLine($"Сумма цифр числа {n} не кратна 5.");
            }

            if (sumDigits % a == 0)
            {
                Console.WriteLine($"Сумма цифр числа {n} кратна числу {a}.");
            }
            else
            {
                Console.WriteLine($"Сумма цифр числа {n} не кратна числу {a}.");
            }
        }
    }
}
