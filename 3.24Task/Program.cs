using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._24Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано трёхзначное число. Найти число, полученное при перестановке первой и второй цифры заданного числа.

            Console.Write("Введите трёхзначного число: ");

            int number = int.Parse(Console.ReadLine());

            int hundrNumber = number / 100;

            int decNumber = number / 10 % 10;

            int unitNumber = number % 100 % 10;

            int res = decNumber * 100 + hundrNumber * 10 + unitNumber;

            Console.WriteLine($"В числе {number} переставлены первая и вторая цифры и получено число {res}");
        }
    }
}
