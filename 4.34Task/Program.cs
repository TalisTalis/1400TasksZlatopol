using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _4._34Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано трёхзначное число:
            // верно ли, что все его цифры одинаковые
            // определить, есть ли среди его цифр одинаковые

            Console.Write("Введите трёхзначное число: ");

            int n = int.Parse(Console.ReadLine());

            int firstDigit = n / 100;

            int secondDigit = n % 100 / 10;

            int lastDigit = n % 10;

            if (firstDigit == secondDigit && lastDigit == firstDigit)
            {
                Console.WriteLine($"Все цифры числа {n} одинаковы.");
            }
            else
            {
                Console.WriteLine($"Все цифры числа {n} не одинаковы.");
            }

            if (firstDigit == secondDigit || lastDigit == firstDigit || secondDigit == lastDigit)
            {
                Console.WriteLine($"Среди цифр числа {n} есть одинаковые.");
            }
            else
            {
                Console.WriteLine($"Среди цифр числа {n} нет одинаковых.");
            }
        }
    }
}
