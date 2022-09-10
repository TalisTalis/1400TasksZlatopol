using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._26Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано трёхзначное число, в котором все цифры различны
            // Получить шесть чисел, образованных при перестановке цифр заданного числа

            Console.Write("Введите трёхзначное число: ");

            int number = int.Parse(Console.ReadLine());

            int hundrNumber = number / 100;

            int decNumber = number % 100 / 10;

            int unitNumber = number % 100 % 10;

            int oneNumber = unitNumber * 100 + decNumber * 10 + hundrNumber;

            int twoNumber = decNumber * 100 + unitNumber * 10 + hundrNumber;

            int threeNumber = decNumber * 100 + hundrNumber * 10 + unitNumber;

            int fourNumber = unitNumber * 100 + hundrNumber * 10 + decNumber;

            int fiveNumber = hundrNumber * 100 + unitNumber * 10 + decNumber;

            int sixNumber = hundrNumber * 100 + decNumber * 10 + unitNumber;

            Console.WriteLine($"Из числа {number} перестановкой цифр получается {oneNumber}, {twoNumber}, {threeNumber}, {fourNumber}, {fiveNumber}, {sixNumber}");
        }
    }
}
