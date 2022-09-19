using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._37Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Определить, является ли число a делителем числа b?
            // А наоборот? 

            Console.Write("Введите число a: ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите число b: ");

            int b = int.Parse(Console.ReadLine());

            if (b % a == 0)
            {
                Console.WriteLine($"Число a является делителем числа b.");
            }
            else
            {
                Console.WriteLine($"Число a не является делителем числа b.");
            }

            if (a % b == 0)
            {
                Console.WriteLine($"Число b является делителем числа a.");
            }
            else
            {
                Console.WriteLine($"Число b не является делителем числа a.");
            }
        }
    }
}
