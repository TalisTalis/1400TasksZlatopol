using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._67Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Определить, является ли заданное шестизначное число счастливым.
            // Счастливым называют такое шестизначное число, в котором сумма его 
            // первых трёх цифр равна сумме его последних трёх цифр)

            Console.Write("Введите шестизначное число: ");

            int number = int.Parse(Console.ReadLine());

            int firstDigit = number / 100000;

            int secondDigit = number % 100000 / 10000;

            int thirdDigit = number % 10000 / 1000;

            int fourDigit = number % 1000 / 100;

            int fifthDigit = number % 100 / 10;

            int sixthDigit = number % 10;

            int firstPart = firstDigit + secondDigit + thirdDigit;

            int secondPart = fourDigit + fifthDigit + sixthDigit;

            if (firstPart == secondPart)
            {
                Console.WriteLine("Число счастливое!");
            }
            else
            {
                Console.WriteLine("Число не счастливое.");
            }
        }
    }
}
