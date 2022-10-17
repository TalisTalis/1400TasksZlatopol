using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._100Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны два различных вещественных числа.
            // Определить наибольшее и наименьшее из них, не используя полный условный оператор, а применив:
            // а) два неполных условных оператора;
            // б) один неполный условный оператор.

            Console.Write("Введите первое число: ");

            double firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");

            double secondNumber = double.Parse(Console.ReadLine());

            double min, max;

            min = max = firstNumber;

            if (firstNumber > secondNumber)
            {
                min = secondNumber;
            }

            if (secondNumber > firstNumber)
            {
                max = secondNumber;
            }

            Console.WriteLine($"Наибольшее число - {max}; наименьшее число - {min}.");

            min = firstNumber;

            max = secondNumber;

            if (firstNumber > secondNumber)
            {
                min = secondNumber;

                max = firstNumber;
            }

            Console.WriteLine($"Наибольшее число - {max}; наименьшее число - {min}.");
        }
    }
}
