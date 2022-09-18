using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._32Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано трёхзначное число. Определить, равен ли квадрат
            // этого числа сумме кубов его цифр.

            Console.Write("Введите трёхзначное число: ");

            int n = int.Parse(Console.ReadLine());

            double quadNumber = Math.Pow(n, 2);

            int firstDigit = n / 100;

            int secondDigit = n % 100 / 10;

            int lastDigit = n % 10;

            double cubeFirstDigit = Math.Pow(firstDigit, 3);

            double cubeSecondDigit = Math.Pow(secondDigit, 3);

            double cubeLastDigit = Math.Pow(lastDigit, 3);

            double sumCubeDigit = cubeFirstDigit + cubeSecondDigit + cubeLastDigit;

            if (quadNumber == sumCubeDigit)
            {
                Console.WriteLine($"Квадрат числа {n} равен сумме кубов его цифр.");
            }
            else
            {
                Console.WriteLine($"Квадрат числа {n} не равен сумме кубов его цифр.");
            }
        }
    }
}
