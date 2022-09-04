using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._38Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Напишите программу, в которой вычисляется сумма, разность, произведение, частное и среднее арифметическое
            // двух целых чисел, введённых с клавиатуры.

            Console.Write("Введите первое число: ");

            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");

            int secondNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber; // Вычисление суммы

            int sub = firstNumber - secondNumber; // Вычисление разности

            int mult = firstNumber * secondNumber; // Вычисление произведения

            decimal div = (decimal)firstNumber / (decimal)secondNumber; // Вычисление частного

            float arithmeticMean = (float)sum / 2; // Вычисление среднего арифметического

            Console.Write($"{firstNumber}+{secondNumber}={sum} ");

            Console.Write($"{firstNumber}-{secondNumber}={sub} ");

            Console.Write($"{firstNumber}*{secondNumber}={mult} ");

            Console.Write($"{firstNumber}/{secondNumber}={div} ");

            Console.Write($"({firstNumber}+{secondNumber})/2={arithmeticMean}");

            Console.WriteLine();
        }
    }
}
