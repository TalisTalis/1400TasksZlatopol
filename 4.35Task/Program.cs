using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано четырёхзначное число. Определить:
            // равна ли сумма двух первых его цифр сумме двух его последних цифр
            // кратна ли трём сумма его цифр
            // кратно ли четырём произведение его цифр
            // кратно ли произведение его цифр числу a

            Console.Write("Введите четырёхзначное число: ");

            int n = int.Parse(Console.ReadLine());

            int firstDigitNumber = n / 1000;

            int secondDigitNumber = n % 1000 / 100;

            int thirdDigitNumber = n % 100 / 10;

            int fourthDigitNumber = n % 10;

            int sumFirstCouple = firstDigitNumber + secondDigitNumber;

            int sumSecondCouple = thirdDigitNumber + fourthDigitNumber;

            if (sumFirstCouple == sumSecondCouple)
            {
                Console.WriteLine("Сумма двух первых цифр равна сумме двух последних цифр.");
            }

            int sumDigits = firstDigitNumber + secondDigitNumber + thirdDigitNumber + fourthDigitNumber;

            if (sumDigits % 3 == 0)
            {
                Console.WriteLine("Сумма цифр числа кратна 3.");
            }

            int multiDigits = firstDigitNumber * secondDigitNumber * thirdDigitNumber * fourthDigitNumber;

            if (multiDigits % 4 == 0)
            {
                Console.WriteLine("Произведение цифр числа кратно 4.");
            }

            Console.Write("Введите число a: ");

            int a = int.Parse(Console.ReadLine());

            if (multiDigits % a == 0)
            {
                Console.WriteLine($"Произведение цифр числа кратно числу {a}.");
            }
        }
    }
}
