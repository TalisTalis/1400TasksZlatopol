using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._21Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано трёхзначное число. Найти число, полученное при прочтении его цифр справа налево.

            Console.Write("Введите трёхзначное число: ");

            int number = int.Parse(Console.ReadLine());

            int hundrNumber = number / 100;

            int decNumber = number % 100 / 10;

            int unitNumber = number % 100 % 10;

            int reversNumber = unitNumber * 100 + decNumber * 10 + hundrNumber;

            Console.WriteLine($"Число, полученное при прочтении цифр числа {number} справа налево, равно {reversNumber}");
        }
    }
}
