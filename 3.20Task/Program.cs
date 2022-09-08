using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._20Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано трёхзначное число. Найти
            // число единиц в нём
            // число десятков в нём
            // сумму его цифр
            // произведение его цифр

            Console.Write("Введите трёхзначное число: ");

            int number = int.Parse(Console.ReadLine());

            int unitNumber = number % 100 % 10;

            int decNumber = number % 100 / 10;

            int hundrNumber = number / 100;

            int sum = hundrNumber + decNumber + unitNumber;

            int mult = hundrNumber * decNumber * unitNumber;

            Console.WriteLine($"В числе {number} {decNumber} десятков, {unitNumber} единиц.");

            Console.WriteLine($"Сумма цифр трёхзначного числа {number} равна {sum}");

            Console.WriteLine($"Произведение цифр трёхзначного числа {number} равно {mult}");
        }
    }
}
