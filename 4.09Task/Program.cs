using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._09Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Определить максимальное и минимальное значения 
            // из двух вещественных чисел.
            // Использовать один условный оператор

            Console.Write("Введите первое число: ");

            float firstNumber = float.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");

            float secondNumber = float.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"Максимальное значение = {firstNumber}");
            }

            Console.WriteLine($"Минимальное значение = {secondNumber}");
        }
    }
}
