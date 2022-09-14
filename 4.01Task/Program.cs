using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._01Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны два различных вещественных числа. Определить:
            // какое из них больше
            // какое из них меньше

            Console.Write("Введите первое вещественное число: ");

            float firstNumber = float.Parse(Console.ReadLine());

            Console.Write("Введите второе вещественное число: ");

            float secondNumber = float.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"Из {firstNumber}, {secondNumber} число {firstNumber} больше.");
            }
            else
            {
                Console.WriteLine($"Из {firstNumber}, {secondNumber} число {secondNumber} больше.");
            }

            if (firstNumber < secondNumber)
            {
                Console.WriteLine($"Из {firstNumber}, {secondNumber} число {firstNumber} меньше.");
            }
            else
            {
                Console.WriteLine($"Из {firstNumber}, {secondNumber} число {secondNumber} меньше.");
            }
        }
    }
}
