using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._24Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано натуральное число. Определить:
            // является ли оно четным
            // оканчивается ли оно на 7

            Console.Write("Введите число: ");

            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine($"Число {a} является чётным");
            }

            if (a % 10 == 7) // Делить на 10 пока не останется последняя цифра
            {
                Console.WriteLine("Число оканчивается на 7.");
            }
        }
    }
}
