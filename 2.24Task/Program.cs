using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._24Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны два числа. Найти их сумму, разность, произведение, а также частное от деления первого числа на второе

            Console.Write("Введите первое число: ");

            double firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");

            double secondNumber = double.Parse(Console.ReadLine());

            double sum = firstNumber + secondNumber;

            Console.WriteLine("Сумма чисел " + firstNumber + " и " + secondNumber + " = " + sum);

            double sub = firstNumber - secondNumber;

            Console.WriteLine("Разность чисел " + firstNumber + " и " + secondNumber + " = " + sub);

            double mult = firstNumber * secondNumber;

            Console.WriteLine("Произведение чисел " + firstNumber + " и " + secondNumber + " = " + mult);

            double div = firstNumber / secondNumber;

            Console.WriteLine("Частное от деления числа " + firstNumber + " на " + secondNumber + " = " + div);
        }
    }
}
