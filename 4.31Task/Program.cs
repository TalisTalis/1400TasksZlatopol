using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._31Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано трёхзначное число. Определить, какая из его цифр больше:
            // первая или последняя
            // первая или вторая
            // вторая или последняя

            Console.Write("Введите трёхзначное число: ");

            int n = int.Parse(Console.ReadLine());

            int firstDigit = n / 100;

            int secondDigit = n % 100 / 10;

            int lastDigit = n % 10;

            if (firstDigit > lastDigit)
            {
                Console.WriteLine("Первая цифра больше последней.");
            }
            else if (firstDigit < lastDigit)
            {
                Console.WriteLine("Последняя цифра больше первой.");
            }

            if (firstDigit > secondDigit)
            {
                Console.WriteLine("Первая цифра больше второй.");
            }
            else if (firstDigit < secondDigit)
            {
                Console.WriteLine("Вторая цифра больше первой.");
            }

            if (secondDigit > lastDigit)
            {
                Console.WriteLine("Вторая цифра больше последней.");
            }
            else if(secondDigit < lastDigit)
            {
                Console.WriteLine("Последняя цифра больше второй.");
            }
        }
    }
}
