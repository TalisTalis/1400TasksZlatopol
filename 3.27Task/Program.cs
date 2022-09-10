using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._28Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Написать программу, в которой рассчитывается:
            // сумма цифр 4-значного числа, вводимого с клавиатуры
            // число, образованное при перестановке первой и второй, третьей и четвёртой цифр 
            // заданного числа.
            // число, образуемое при перестановке второй и третьей цифр заданного числа.
            // число, образуемое при перестановке двух первых и двух последних цифр заданного числа.
            // Последнюю задачу решить двумя способами:
            // с выделением отдельных цифр заданного числа
            // без выделения отдельных цифр заданного числа

            Console.Write("Введите четырёхзначное число: ");

            int number = int.Parse(Console.ReadLine());

            int thousandNumber = number / 1000;

            int hundrNumber = number % 1000 / 100;

            int decNumber = number % 100 / 10;

            int unitNumber = number % 10;

            int sumDigit = thousandNumber + hundrNumber + decNumber + unitNumber;

            int a = hundrNumber * 1000 + thousandNumber * 100 + unitNumber * 10 + decNumber;

            int b = thousandNumber * 1000 + decNumber * 100 + hundrNumber * 10 + unitNumber;

            int c = decNumber * 1000 + unitNumber * 100 + thousandNumber * 10 + hundrNumber;

            int firstPartNumber = number / 100;

            int secondPartNumber = number % 100;

            int d = secondPartNumber * 100 + firstPartNumber;

            Console.WriteLine($"Сумма цифр числа {number} равна {sumDigit}");

            Console.WriteLine($"При перестановке первой и второй, третьей и четвертой цифр числа {number} получено число {a}");

            Console.WriteLine($"При перестановке второй и третьей цифр числа {number} получено число {b}");

            Console.WriteLine($"При перестановке двух первых и двух последних цифр числа {number}, с выделением отдельных цифр, получено число {c}");
            
            Console.WriteLine($"При перестановке двух первых и двух последних цифр числа {number}, без выделения отдельных цифр, получено число {d}");
        }
    }
}
