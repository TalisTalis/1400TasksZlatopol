using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._99Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны два различных вещественных числа.
            // Определить наибольшее из них, не используя полный условный оператор,
            // а применив:
            // а) два неполных условных оператора;
            // б) один неполный условный оператор

            Console.Write("Введите первое число: ");

            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");

            int secondNumber = int.Parse(Console.ReadLine());

            int max = 0;

            if (firstNumber > secondNumber)
            {
                max = firstNumber;
            }

            if (secondNumber > firstNumber)
            {
                max = secondNumber;                
            }
            
            Console.WriteLine($"Наибольшее число {max}");

            max = secondNumber;

            if (firstNumber > secondNumber)
            {
                max = firstNumber;
            }

            Console.WriteLine($"Наибольшее число {max}");
        }
    }
}
