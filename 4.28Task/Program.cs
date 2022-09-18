using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._28Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано двузначное число. Определить:
            // является ли сумма его цифр двузначным число
            // больше ли числа a сумма его цифр

            Console.Write("Введите двузначное число: ");

            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите число a: ");

            int a = int.Parse(Console.ReadLine());

            int sumDigit = n % 10 + n / 10;

            if (sumDigit / 10 == 1)
            {
                Console.WriteLine($"Сумма цифр числа {n} является двузначным числом.");
            }
            else
            {
                Console.WriteLine($"Сумма цифр числа {n} не является двузначным числом.");
            }

            if (sumDigit > n)
            {
                Console.WriteLine($"Сумма цифр числа {n} больше {a}.");
            }
            else
            {
                Console.WriteLine($"Сумма цифр числа {n} меньше {a}.");
            }
        }
    }
}
