using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._25Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано трёхзначное число. Найти число, полученное при перестановке второй и третьей цифр заданного числа

            Console.Write("Введите трёхзначное число: ");

            int number = int.Parse(Console.ReadLine());

            int hundrNumber = number / 100;

            int decNumber = number % 100 / 10;

            int unitNumber = number % 100 % 10;

            int res = hundrNumber * 100 + unitNumber * 10 + decNumber;

            Console.WriteLine($"Число, полученное при перестановке второй и третьей цифры числа {number}, равно {res}");
        }
    }
}
