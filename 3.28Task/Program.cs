using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._27Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Написать программу, в которой рассчитывается:
            // сумма цифр 4-значного числа, вводимого с клавиатуры
            // то же, 5-значного

            Console.Write("Введите число: ");

            int number = int.Parse(Console.ReadLine());

            int lengthNumber = number.ToString().Length;

            int sumNumber = 0;

            for (int i = 0; i < lengthNumber; i++)
            {
                sumNumber += (int)(number % Math.Pow(10, lengthNumber - i) / Math.Pow(10, lengthNumber - (1 + i)));

                //Console.WriteLine((int)(number % Math.Pow(10, lengthNumber - i) / Math.Pow(10, lengthNumber - (1 + i))));
            }

            Console.WriteLine($"Сумма цифр числа {number} равна {sumNumber}");
        }
    }
}
