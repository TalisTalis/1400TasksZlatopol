using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._17Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Написать программу, в которой рассчитывается сумма цифр двузначного числа,
            // вводимого с клавиатуры

            Console.Write("Введите двузначное число: ");

            int twoDigitNumber = int.Parse(Console.ReadLine());

            int firstDigit = twoDigitNumber / 10;

            int secondDigit = twoDigitNumber % 10;

            int sum = firstDigit + secondDigit;
            Console.WriteLine($"Сумма цифр двузначного числа равна {sum}");
        }
    }
}
