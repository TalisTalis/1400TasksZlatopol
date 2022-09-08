using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._18Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано двузначное число. Получить число, образованное при перестановке цифр заданного числа

            Console.Write("Введите двузначное число: ");

            int a = int.Parse(Console.ReadLine());

            int firstNumber = a / 10;

            int secondNumber = a % 10;

            int res = secondNumber * 10 + firstNumber;

            Console.WriteLine($"Число, образованное при перестановке цифр числа {a}, равно {res}");
        }
    }
}
